using Alkamous.Controller;
using Alkamous.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_UsersLog : Form
    {
        ClsOperationsofUserLogFile ClsOperationsofUserLogFile = new ClsOperationsofUserLogFile();
        public Frm_UsersLog()
        {
            InitializeComponent();
        }

        private void DGVColumnHeaderTextAndWidth()
        {
            DGVUserLOG.Columns.Add("0", "NO");
            DGVUserLOG.Columns.Add("1", "User Name");
            DGVUserLOG.Columns.Add("2", "Description");
            DGVUserLOG.Columns.Add("3", "Details");
            DGVUserLOG.Columns.Add("4", "Date");

            DGVUserLOG.Columns[0].Width = 20;
            DGVUserLOG.Columns[1].Width = 50;
            DGVUserLOG.Columns[2].Width = 50;
            DGVUserLOG.Columns[3].Width = 50;
            DGVUserLOG.Columns[4].Width = 130;

        }

        private void LoadData(string Search = "..........")
        {
            try
            {

                DGVUserLOG.Rows.Clear();
                List<CTB_UserLog> ListOfUserLOG = new List<CTB_UserLog>();

                if (Search == "..........")
                {
                    ListOfUserLOG = ClsOperationsofUserLogFile.Get_ALL();
                }
                else
                {
                    ListOfUserLOG = ClsOperationsofUserLogFile.Get_AllLOGBySearc(Search);

                }
                if (ListOfUserLOG != null)
                {
                    // we can use foreach or normal for 
                    // normal for faster 
                    //foreach (var item in ListOfUserLOG)
                    //{
                    //    DGVUserLOG.Rows.Add(
                    //   item.UserLog_Autonum,
                    //   item.UserLog_UserName,
                    //   item.UserLog_Opration_type,
                    //   item.UserLog_opration,
                    //   item.UserLog_datatime);
                    //}

                    for (int i = 0; i < ListOfUserLOG.Count; i++)
                    {
                        DGVUserLOG.Rows.Add(
                        ListOfUserLOG[i].UserLog_Autonum,
                        ListOfUserLOG[i].UserLog_UserName,
                        ListOfUserLOG[i].UserLog_Opration_type,
                        ListOfUserLOG[i].UserLog_opration,
                        ListOfUserLOG[i].UserLog_datatime);
                    }
                }

                LbCount.Text = DGVUserLOG.RowCount.ToString();
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteALLUserLOG_Click(object sender, EventArgs e)
        {
            string passwordLoginAsAdmin = Frm_Main.FrmMain.LBUserName.Text + DateTime.Now.ToString("ddMM");
            MessageBox.Show($" Mr. {Frm_Main.FrmMain.LBUserName.Text} can you please let us know why need to delete the Log file of the users ? ",
                                  "Message - dM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (passwordLoginAsAdmin == txtCode.Text.Trim())
            {

                if (!(string.IsNullOrEmpty(txtWhyDelete.Text.Trim())))
                {
                    ClsOperationsofUserLogFile.Delete(null);
                    Chelp.RegisterUsersActionLogs("Deleted All the Data Logs of Users ", txtWhyDelete.Text.Trim());
                    txtCode.Text = string.Empty;
                    txtWhyDelete.Text = string.Empty;
                    TxtSearch.Text = string.Empty;
                    LoadData();
                    MessageBox.Show("ll the Data Logs of Users Deleted !!!");
                }
                else
                {
                    txtWhyDelete.Focus();
                }
            }

        }

        private void Frm_UsersLog_Load(object sender, EventArgs e)
        {
            DGVColumnHeaderTextAndWidth();
            LoadData();

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(TxtSearch.Text.Trim())))
            {
                LoadData(TxtSearch.Text.Trim());
            }

        }
    }
}
