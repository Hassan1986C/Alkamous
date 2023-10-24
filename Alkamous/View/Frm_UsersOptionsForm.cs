
using Alkamous.Controller;
using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_UsersOptionsForm : Form
    {
        public Frm_UsersOptionsForm()
        {
            InitializeComponent();

        }

        private void BtnConnectionSQLServerSetting_Click(object sender, EventArgs e)
        {
            try
            {
                Chelp chelp = new Chelp();

                // to never open from if already opened
                if (chelp.CheckOpened("Frm_ConnectionSQLServerSetting"))
                    return;

                chelp.ShowForm(new Frm_ConnectionSQLServerSetting());
            }
            catch (Exception ex)
            {
                var Btn = sender as Button;
                Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnUserAddUpdateDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Chelp chelp = new Chelp();

                // to never open from if already opened
                if (chelp.CheckOpened("Frm_UserAddUpdateDelete"))
                    return;

                chelp.ShowForm(new Frm_UserAddUpdateDelete());
            }
            catch (Exception ex)
            {
                var Btn = sender as Button;
                Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUserChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                Chelp chelp = new Chelp();

                // to never open from if already opened
                if (chelp.CheckOpened("Frm_UserChangePassword"))
                    return;

                chelp.ShowForm(new Frm_UserChangePassword());
            }
            catch (Exception ex)
            {
                var Btn = sender as Button;
                Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUsersLog_Click(object sender, EventArgs e)
        {
            try
            {
                Chelp chelp = new Chelp();

                // to never open from if already opened
                if (chelp.CheckOpened("Frm_UsersLog"))
                    return;

                chelp.ShowForm(new Frm_UsersLog());
            }
            catch (Exception ex)
            {
                var Btn = sender as Button;
                Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExportPathWord_Click(object sender, EventArgs e)
        {
            try
            {
                Chelp chelp = new Chelp();

                // to never open from if already opened
                if (chelp.CheckOpened("Frm_UserExportPathMsWord"))
                    return;

                chelp.ShowForm(new Frm_UserExportPathMsWord());
            }
            catch (Exception ex)
            {
                var Btn = sender as Button;
                Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnFixWordTempletefiles_Click(object sender, EventArgs e)
        {
            string tempFilePath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"Temp\TempFile.docx");
            string zipFilePath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"Temp\TempFile.zip");
            string extractPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"Temp");
            if (MessageBox.Show("Make Sure you closed all Word files before clicking yes ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    if (File.Exists(tempFilePath))
                    {
                        File.Delete(tempFilePath);
                    }

                    ZipFile.ExtractToDirectory(zipFilePath, extractPath);

                    MessageBox.Show("Extraction successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    var Btn = sender as Button;
                    Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnImportExportTerms_Click(object sender, EventArgs e)
        {

            try
            {
                Chelp chelp = new Chelp();

                // to never open from if already opened
                if (chelp.CheckOpened("Frm_TermsImportExport"))
                    return;

                chelp.ShowForm(new Frm_TermsImportExport());
            }
            catch (Exception ex)
            {
                var Btn = sender as Button;
                Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnImportExportProducts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry this option is Not ready at this time", "Message");
        }
    }
}
