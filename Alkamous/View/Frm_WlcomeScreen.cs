using System;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_WlcomeScreen : Form
    {
        public Frm_WlcomeScreen()
        {
            InitializeComponent();
        }

        private void Frm_WlcomeScreen_Load(object sender, EventArgs e)
        {
            LbWelcome.Text = $"Welcome Mr. {Frm_Main.FrmMain.LBUserName.Text}";
        }
    }
}
