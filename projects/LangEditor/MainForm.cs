using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LangEditor
{
    public partial class MainForm : Form
    {
        private string _opened_file;

        private string OpenedFileName
        {
            get { return _opened_file; }
            set
            {
                _opened_file = value;
                Text = string.Format("FISCA 語系編輯器 {0}", _opened_file);
            }
        }


        public MainForm()
        {
            InitializeComponent();
            OpenedFileName = string.Empty;
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "*.resources|*.resources";
                dialog.Title = "開啟語言檔";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    dgvLang.Rows.Clear();

                    ResourceReader rr = new ResourceReader(dialog.FileName);
                    IDictionaryEnumerator rcset = rr.GetEnumerator();
                    while (rcset.MoveNext())
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dgvLang, rcset.Key, rcset.Value);
                        dgvLang.Rows.Add(row);
                    }
                    rr.Close();
                    OpenedFileName = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            try
            {
                GenerateResourceFile(OpenedFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GenerateResourceFile(string fileName)
        {
            ResourceWriter rw = new ResourceWriter(fileName);

            dgvLang.CommitEdit(DataGridViewDataErrorContexts.Commit);
            foreach (DataGridViewRow each in dgvLang.Rows)
            {
                if (each.IsNewRow)
                    continue;

                string key = each.Cells[chKey.Name].Value + "";
                string value = each.Cells[chValue.Name].Value + "";

                rw.AddResource(key, value);
            }
            rw.Generate();
            rw.Close();
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> langs = new List<string>();
                langs.Add("中性(*.resources)|*.resources");
                langs.Add("英文(*.en-US.resources)|*.en-US.resources");
                langs.Add("繁體(*.zh-TW.resources)|*.zh-TW.resources");
                langs.Add("簡體(*.zh-CN.resources)|*.zh-CN.resources");
                langs.Add("自定(*.*)|*.*");

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = string.Join("|", langs.ToArray());
                dialog.Title = "另存語言檔";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    GenerateResourceFile(dialog.FileName);
                    OpenedFileName = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exportXmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> langs = new List<string>();
                langs.Add("Language.xml)|Language.xml");

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = string.Join("|", langs.ToArray());
                dialog.Title = "另存語言檔";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    GenerateXmlLanguage(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GenerateXmlLanguage(string fileName)
        {
            XElement lang = new XElement("Internationalization");
            XElement def = new XElement("Default");

            lang.Add(new XElement("Assembly",
                new XAttribute("Name", "FISCA"),
                def));

            dgvLang.CommitEdit(DataGridViewDataErrorContexts.Commit);
            foreach (DataGridViewRow each in dgvLang.Rows)
            {
                if (each.IsNewRow)
                    continue;

                string key = each.Cells[chKey.Name].Value + "";
                string value = each.Cells[chValue.Name].Value + "";

                def.Add(new XElement("String",
                    new XAttribute("Name", key),
                    value));
            }

            lang.Save(fileName);
        }
    }
}
