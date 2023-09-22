using Alkamous.Controller;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_UserChangePassword : Form
    {
        Model.CTB_Users MTB_Users = new Model.CTB_Users();
        ClsOperationsofUsers ClsOperationsofUsers = new ClsOperationsofUsers();

        public Frm_UserChangePassword()
        {
            InitializeComponent();
        }


        private string CheckStrength(string password)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewPass.Text.Trim()))
                {
                    LbPassLevel.Visible = false;
                }
                else
                {
                    LbPassLevel.Visible = true;
                }

                int score = 0;

                if (password.Length <= 3)
                {
                    LbPassLevel.BackColor = Color.LightCoral;
                    return "Password Weak";
                }
                if (password.Length >= 4)
                    score++;
                if (Regex.Match(password, "[0-9]").Success)
                    score++;
                if (Regex.Match(password, "[A-z]").Success)
                    score++;
                if (Regex.Match(password, "[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]").Success)
                    score++;

                if (score >= 4)
                {
                    LbPassLevel.BackColor = Color.LightGreen;
                    return "Password Strong";

                }
                else if (score >= 2)
                {
                    LbPassLevel.BackColor = Color.LightYellow;
                    return "Password Medium";
                }
                else
                {
                    LbPassLevel.BackColor = Color.Red;
                    return "Password Weak";
                }
            }
            catch (Exception)
            {
                return "";
            }

        }

        private bool CheckOldpassword()
        {
            if (!((string.IsNullOrEmpty(txtOldPass.Text.Trim())) & (string.IsNullOrEmpty(txtNewPass.Text.Trim()))))
            {
                MTB_Users = ClsOperationsofUsers.Get_AllBySearch(Frm_Main.FrmMain.LBUserName.Text);
                if (MTB_Users != null)
                {
                    string result = ClsAESEncryption.AESDecrypt(MTB_Users.UserPassword, MTB_Users.UserAESKey, MTB_Users.UserAESIV);
                    if (result.Equals(txtOldPass.Text.Trim()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;

                }
            }
            return false;
        }

        private void BtnSavePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOldPass.Text) || string.IsNullOrWhiteSpace(txtOldPass.Text))
                {
                    txtOldPass.Focus();
                    MessageBox.Show("insert the current password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
                else if (string.IsNullOrEmpty(txtNewPass.Text) || string.IsNullOrWhiteSpace(txtNewPass.Text))
                {
                    txtNewPass.Focus();
                    MessageBox.Show("insert the new password ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
                else if (txtNewPass.TextLength < 4)
                {
                    txtNewPass.Focus();
                    MessageBox.Show("The new password is too short", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (string.IsNullOrEmpty(txtConformpass.Text) || string.IsNullOrWhiteSpace(txtConformpass.Text))
                {
                    txtConformpass.Focus();
                    MessageBox.Show("Please confirm the new password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (txtNewPass.Text != txtConformpass.Text)
                {

                    MessageBox.Show("Confirm password does not match", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {


                    // check
                    if (CheckOldpassword())
                    {                        // To Change Password and Save in Properties
                        bool MSresult = MessageBox.Show("Do you want to save a new password  ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                        if (MSresult)
                        {
                            // here code



                            var (Password, UserKey, UserIV) = Chelp.encryptedPassword(txtNewPass.Text.Trim());

                            MTB_Users.UserName = Frm_Main.FrmMain.LBUserName.Text;
                            MTB_Users.UserPassword = Password;
                            MTB_Users.UserAESKey = UserKey;
                            MTB_Users.UserAESIV = UserIV;

                            // check if auto login checked
                            if (BtnAutoLogin.Checked)
                            {

                                Properties.Settings.Default.IsLogin = true;
                                Properties.Settings.Default.UserName = Frm_Main.FrmMain.LBUserName.Text;
                                // Properties.Settings.Default.password = txtNewPass.Text.Trim();
                                Properties.Settings.Default.Save();
                            }
                            else
                            {
                                Properties.Settings.Default.IsLogin = false;
                                Properties.Settings.Default.UserName = "";
                                Properties.Settings.Default.password = "";
                                Properties.Settings.Default.Save();
                            }

                            if (ClsOperationsofUsers.Update(MTB_Users))
                            {
                                Chelp.RegisterUsersActionLogs("Change Password", "Change Password");
                                MessageBox.Show("Password changed successfully the application will restart to login with a new password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Application.Restart();
                            }
                            else
                            {
                                MessageBox.Show($"problem ");
                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("Your current password is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtOldPass.Focus();
                        txtOldPass.SelectAll();
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

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            LbPassLevel.Text = CheckStrength(txtNewPass.Text).ToString();
        }

        private void BtnShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnShowPassword.Checked == true)
            {
                txtNewPass.UseSystemPasswordChar = false;
                txtConformpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPass.UseSystemPasswordChar = true;
                txtConformpass.UseSystemPasswordChar = true;

            }
        }

        private void BtnAutoLogin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
