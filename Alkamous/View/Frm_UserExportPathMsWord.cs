using System;
using System.IO;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_UserExportPathMsWord : Form
    {
        public Frm_UserExportPathMsWord()
        {
            InitializeComponent();
        }

        private void BtnOpenPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.Description = "Choose the path To Export the Word File";
            //FBD.ShowNewFolderButton = false;
            //FBD.RootFolder = Environment.SpecialFolder.Desktop;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                txtNewPth.Text = FBD.SelectedPath;
            }
        }

        private void CheckedIsDefult(bool Result)
        {
            BtnDefultPath.Checked = Result;
            BtnNewPath.Checked = !(Result);

            BtnDefultPath.Enabled = !(Result);
            BtnNewPath.Enabled = Result;

            BtnOpenPath.Visible = !(Result);
            txtNewPth.Visible = !(Result);
        }

        private void BtnDefultPath_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnDefultPath.Checked == true)
            {
                CheckedIsDefult(true);
            }
        }

        private void BtnNewPath_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnNewPath.Checked == true)
            {
                CheckedIsDefult(false);
            }

        }

        private void Frm_UserExportPathMsWord_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ExportPath == "DefaultPath")
            {
                CheckedIsDefult(true);
            }
            else
            {
                CheckedIsDefult(false);
                txtNewPth.Text = Properties.Settings.Default.ExportPath;
            }

        }

        private void BtnSaveConfiguration_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want save the Export Path", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (BtnNewPath.Checked == true)
                {
                    if (!(Directory.Exists(Path.Combine($@"{txtNewPth.Text.Trim()}"))))
                    {
                        MessageBox.Show("The Export Path doesn't exist please check again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    Properties.Settings.Default.ExportPath = txtNewPth.Text.Trim();
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.ExportPath = "DefaultPath";
                    Properties.Settings.Default.Save();
                }
                MessageBox.Show("Done Saved");
            }

        }
    }
}
