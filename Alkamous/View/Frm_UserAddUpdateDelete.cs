using Alkamous.Controller;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_UserAddUpdateDelete : Form
    {

        Model.CTB_Users MTB_Users = new Model.CTB_Users();
        ClsOperationsofUsers ClsOperationsofUsers = new ClsOperationsofUsers();

        public Frm_UserAddUpdateDelete()
        {
            InitializeComponent();
        }

        private void Frm_UserAddUpdateDelete_Load(object sender, EventArgs e)
        {

            LoadData();


        }

        private void BtnAddNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                string passwordLoginAsAdmin = "Admin" + DateTime.Now.ToString("hhMMdd");
                MessageBox.Show("To Add User Need a Code", "Message ahmd");
                if (passwordLoginAsAdmin == txtLoginAsAdmin.Text.Trim())
                {
                    var (Password, UserKey, UserIV) = Chelp.encryptedPassword(TxtPassword.Text.Trim());

                    MTB_Users.UserName = TxtUserName.Text;
                    MTB_Users.UserPassword = Password;
                    MTB_Users.UserAESKey = UserKey;
                    MTB_Users.UserAESIV = UserIV;

                    if (ClsOperationsofUsers.AddNew(MTB_Users))
                    {
                        MessageBox.Show($"the UserName is = {MTB_Users.UserName} Add ");
                        TxtUserName.Text = string.Empty;
                        TxtPassword.Text = string.Empty;
                        txtLoginAsAdmin.Text = string.Empty;

                        List<Model.CTB_Users> userList = ClsOperationsofUsers.Get_ALL();
                        DGVUsers.Rows.Clear();
                        for (int i = 0; i < userList.Count; i++)
                        {
                            DGVUsers.Rows.Add(userList[i].User_AutoNum, userList[i].UserName);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"problem ");
                    }
                }
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }


        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            
            try
            {
                string passwordLoginAsAdmin = "Admin" + DateTime.Now.ToString("hhMMdd");
                MessageBox.Show("To Delete User Need a Code", "Message ahmd");
                if (passwordLoginAsAdmin == txtLoginAsAdmin.Text.Trim())
                {
                    if (DGVUsers.RowCount > 0)
                    {

                        if (MessageBox.Show("Are you sure you want to Delete  " + Environment.NewLine
                            + Environment.NewLine + "User    : " + DGVUsers.CurrentRow.Cells[1].Value.ToString()

                            , "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            Cursor.Current = Cursors.WaitCursor;

                            MTB_Users.UserName = DGVUsers.CurrentRow.Cells[1].Value.ToString();
                            bool Result = ClsOperationsofUsers.Delete(MTB_Users);


                            if (Result)
                            {
                                Chelp.RegisterUsersActionLogs("Delete User", DGVUsers.CurrentRow.Cells[1].Value.ToString());
                                MessageBox.Show("Data Deleted Successfully ");
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Sorry, there is a mistake !!");
                            }
                            Cursor.Current = Cursors.Default;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                string MethodNames = System.Reflection.MethodBase.GetCurrentMethod().Name.ToString();
                Chelp.WriteErrorLog(Name + " => " + MethodNames + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadData()
        {
            DGVUsers.Columns.Add("User_AutoNum", "ID");
            DGVUsers.Columns.Add("UserName", "UserName");
            DGVUsers.Rows.Clear();
            List<Model.CTB_Users> userList = ClsOperationsofUsers.Get_ALL();
            if (userList != null)
            {
                for (int i = 0; i < userList.Count; i++)
                {
                    DGVUsers.Rows.Add(userList[i].User_AutoNum, userList[i].UserName);
                }
            }

        }
    }
}
