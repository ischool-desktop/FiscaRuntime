using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;

namespace XmlLangEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //string a = Convert.ToBase64String(Encoding.UTF8.GetBytes("1234"));

            try
            {
                string fpath = Path.Combine(Application.StartupPath, "Language.xml");
                XElement xmllang = new XElement("Internationalization");
                if (File.Exists(fpath))
                    xmllang = XElement.Load(fpath);

                foreach (XElement asm in xmllang.Elements("Assembly"))
                {
                    string asmname = asm.Attribute("Name").Text();
                    XElement enus = asm.XPathSelectElement("Language[@Code='en-US']");
                    XElement zhcn = asm.XPathSelectElement("Language[@Code='zh-CN']");

                    foreach (XElement str in asm.XPathSelectElement("Language").Elements("String"))
                    {
                        string name = str.Attribute("Name").Text();
                        string val = str.Value;
                        string enusVal = enus.XPathSelectElement("String[@Name='" + name + "']").Text();
                        string zhcnVal = zhcn.XPathSelectElement("String[@Name='" + name + "']").Text();

                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dgv, asmname, name, val, zhcnVal, enusVal);
                        dgv.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            string values = (string)Clipboard.GetData(DataFormats.UnicodeText);
            DataGridViewCell cell = dgv.CurrentCell;

            if (cell.ColumnIndex <= 1)
                return;

            dgv.EndEdit();

            StringReader sr = new StringReader(values);
            int index = cell.RowIndex;
            while (sr.Peek() >= 0)
            {
                dgv.Rows[index].Cells[cell.ColumnIndex].Value = sr.ReadLine();
                dgv.Rows[index].Cells[cell.ColumnIndex].Selected = true;
                index++;
            }
        }

        private void dgv_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewCell cell in dgv.SelectedCells)
                {
                    if (cell.ColumnIndex >= 2)
                        cell.Value = string.Empty;
                }
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            XElement xmllang = new XElement("Internationalization");

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                string asm = row.Cells[chAssembly.Index].Value + "";
                string code = row.Cells[chKey.Index].Value + "";
                string val = row.Cells[chDefault.Index].Value + "";
                string zhcnV = row.Cells[chzhCN.Index].Value + "";
                string enusV = row.Cells[chenUS.Index].Value + "";

                XElement asmelm = GetAssemblyElement(xmllang, asm);

                XElement defElm = GetLanguageElement(asmelm, "");
                XElement zhcnElm = GetLanguageElement(asmelm, "zh-CN");
                XElement enusElm = GetLanguageElement(asmelm, "en-US");

                defElm.Add(new XElement("String",
                    new XAttribute("Name", code),
                    val));

                zhcnElm.Add(new XElement("String",
                    new XAttribute("Name", code),
                    zhcnV));

                enusElm.Add(new XElement("String",
                    new XAttribute("Name", code),
                    enusV));
            }

            xmllang.Save(Path.Combine(Application.StartupPath, "Language.xml"));
        }

        private XElement GetLanguageElement(XElement langs, string code)
        {
            XElement lang = langs.XPathSelectElement("Language[@Code='" + code + "']");

            if (lang == null)
                langs.Add(new XElement("Language", new XAttribute("Code", code)));
            else
                return lang;

            return GetLanguageElement(langs, code);
        }

        private XElement GetAssemblyElement(XElement xmllang, string asmName)
        {
            XElement asm = xmllang.XPathSelectElement("Assembly[@Name='" + asmName + "']");

            if (asm == null)
                xmllang.Add(new XElement("Assembly",
                    new XAttribute("Name", asmName)));
            else
                return asm;

            return GetAssemblyElement(xmllang, asmName);
        }

        private void mnuImport_Click(object sender, EventArgs e)
        {

        }
    }

    internal static class XAttribute_Ext
    {
        public static string Text(this XAttribute att)
        {
            if (att == null)
                return string.Empty;
            else
                return att.Value;
        }

        public static string Text(this XElement elm)
        {
            if (elm == null)
                return string.Empty;
            else
                return elm.Value;
        }
    }
}
