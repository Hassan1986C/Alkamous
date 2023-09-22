using Alkamous.Controller;
using System;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_CustomersOptionsForm : Form
    {
        public Frm_CustomersOptionsForm()
        {
            InitializeComponent();
        }

        private void BtnCustomersUpdateInvoices_Click(object sender, EventArgs e)
        {
            try
            {
                Chelp chelp = new Chelp();

                // to never open from if already opened
                if (chelp.CheckOpened("Frm_Customers"))
                    return;

                chelp.ShowForm(new Frm_Customers());
            }
            catch (Exception ex)
            {
                var Btn = sender as Button;
                Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                // MessageBox.Show(ex.Message);
            }
        }

        private void BtnCustomersAddNewInvoices_Click(object sender, EventArgs e)
        {
            try
            {
                Chelp chelp = new Chelp();

                // to never open from if already opened
                if (chelp.CheckOpened("Frm_CustomersAddNewInvoices"))
                    return;

                chelp.ShowForm(new Frm_CustomersAddNewInvoices());
            }
            catch (Exception ex)
            {
                var Btn = sender as Button;
                Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
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
    }
}
