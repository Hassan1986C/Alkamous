using Alkamous.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_Main : Form
    {
        #region var
        Chelp chelp = new Chelp();
        private static Frm_Main frmMain;

        public static Frm_Main FrmMain  // this methode to make a new form same as orgnal from
        {
            get { return frmMain; }
        }

        #endregion

        public Frm_Main()
        {
            InitializeComponent();
            frmMain = this;

            try
            {
                // مهنم لوضع اكون للبرنامج
                Icon = Icon.ExtractAssociatedIcon($"{System.Diagnostics.Process.GetCurrentProcess().ProcessName}.exe");
            }
            catch (Exception ex)
            {
                Chelp.WriteErrorLog("ICon =>" + ex.Message);
            }
        }

        private void BtnNewQuotation_Click(object sender, EventArgs e)
        {
            try
            {


                // to never open from if already opened
                if (chelp.CheckOpened("Frm_CustomersOptionsForm"))
                    return;

                chelp.ShowForm(new Frm_CustomersOptionsForm());
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnConnection_Click(object sender, EventArgs e)
        {
            try
            {


                // to never open from if already opened
                if (chelp.CheckOpened("Frm_UsersOptionsForm"))
                    return;

                chelp.ShowForm(new Frm_UsersOptionsForm());
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void IsLogin()
        {
            // to never open from if already opened
            if (chelp.CheckOpened("Frm_Login"))
                return;

            chelp.ShowForm(new Frm_Login());

        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            LBUserName.Text = string.Empty;

            if (Properties.Settings.Default.IsLogin)
            {
                foreach (Control btn in panelLesft.Controls)
                {
                    if (btn is Button)
                    {
                        btn.Enabled = true;
                    }
                }
                LBUserName.Text = Properties.Settings.Default.UserName;
                Chelp.RegisterUsersActionLogs($"Auto Login ", $"Login By {Environment.MachineName.ToString()}");
                Chelp chelp = new Chelp();
                chelp.ShowForm(new Frm_WlcomeScreen());
            }
            else
            {
                IsLogin();
            }


            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();
            timer.Tick += Timer_Tick;


            LbServerName.Text = Properties.Settings.Default.ServerName;


            LBData.Text = $"Date  : {DateTime.Now.ToString("dd/MM/yyyy")}";

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LBTime.Text = $"Time :  {DateTime.Now.ToString("hh:mm:ss tt")}";
        }

        private void PicLogo_Click(object sender, EventArgs e)
        {
            try
            {
                if (LBUserName.Text != string.Empty)
                {

                    // to never open from if already opened
                    if (chelp.CheckOpened("Frm_WlcomeScreen"))
                        return;

                    chelp.ShowForm(new Frm_WlcomeScreen());
                }
                else
                {
                    IsLogin();
                }

            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }



        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BtnManage_Click(object sender, EventArgs e)
        {
            try
            {
                // to never open from if already opened
                if (chelp.CheckOpened("Frm_CustomersOptionsOthersForm"))
                    return;

                chelp.ShowForm(new Frm_CustomersOptionsOthersForm());
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCustomerInfo_Click(object sender, EventArgs e)
        {
            try
            {
                // to never open from if already opened
                if (chelp.CheckOpened("Frm_CTB_CustomerInfo"))
                    return;

                chelp.ShowForm(new Frm_CustomerInfo());
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }

        }
    }
}
