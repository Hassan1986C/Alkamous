using Alkamous.Controller;
using System;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_CustomersOptionsOthersForm : Form
    {
        public Frm_CustomersOptionsOthersForm()
        {
            InitializeComponent();
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            try
            {
                Chelp chelp = new Chelp();

                // to never open from if already opened
                if (chelp.CheckOpened("Frm_ProductsAddDeleteUpdate"))
                    return;

                chelp.ShowForm(new Frm_ProductsAddDeleteUpdate());
            }
            catch (Exception ex)
            {
                var Btn = sender as Button;
                Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnTerms_Click(object sender, EventArgs e)
        {
            try
            {
                Chelp chelp = new Chelp();

                // to never open from if already opened
                if (chelp.CheckOpened("Frm_TermsAddDeleteUpdate"))
                    return;

                chelp.ShowForm(new Frm_TermsAddDeleteUpdate());
            }
            catch (Exception ex)
            {
                var Btn = sender as Button;
                Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnBanks_Click(object sender, EventArgs e)
        {
            try
            {
                Chelp chelp = new Chelp();

                // to never open from if already opened
                if (chelp.CheckOpened("Frm_BanksAccountAddUpdateDelete"))
                    return;

                chelp.ShowForm(new Frm_BanksAccountAddUpdateDelete());
            }
            catch (Exception ex)
            {
                var Btn = sender as Button;
                Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
