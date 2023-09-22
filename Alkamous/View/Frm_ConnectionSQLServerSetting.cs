using Alkamous.Controller;
using System;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_ConnectionSQLServerSetting : Form
    {
        public Frm_ConnectionSQLServerSetting()
        {
            InitializeComponent();
        }

        private void BtnSaveConfiguration_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to Save Configuration Setting", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Properties.Settings.Default.ServerName = txtServerName.Text;
                    Properties.Settings.Default.Database = txtDataBase.Text;
                    Properties.Settings.Default.Userid = txtUserName.Text;
                    Properties.Settings.Default.password = txtPassword.Text;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("The data has been saved successfully. The program will be restarted");
                    Application.Restart();

                }
            }
            catch (Exception ex)
            {
                var Btn = sender as Button;
                Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_ConnectionSQLServerSetting_Load(object sender, EventArgs e)
        {
            txtServerName.Text = Properties.Settings.Default.ServerName;
        }
    }
}
