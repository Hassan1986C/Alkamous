using Alkamous.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alkamous.View
{
    public partial class Frm_CustomersOptionsImportExportForm : Form
    {
        public Frm_CustomersOptionsImportExportForm()
        {
            InitializeComponent();
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

            try
            {
                Chelp chelp = new Chelp();

                // to never open from if already opened
                if (chelp.CheckOpened("Frm_ProductsImportExport"))
                    return;

                chelp.ShowForm(new Frm_ProductsImportExport());
            }
            catch (Exception ex)
            {
                var Btn = sender as Button;
                Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnImportExportBankAccount_Click(object sender, EventArgs e)
        {
            try
            {
                Chelp chelp = new Chelp();

                // to never open from if already opened
                if (chelp.CheckOpened("Frm_BanksAccountImportExport"))
                    return;

                chelp.ShowForm(new Frm_BanksAccountImportExport());
            }
            catch (Exception ex)
            {
                var Btn = sender as Button;
                Chelp.WriteErrorLog(Name + " => " + Btn.Name.ToString() + " => " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnImportExportContactDetails_Click(object sender, EventArgs e)
        {
            try
            {
                Chelp chelp = new Chelp();

                // to never open from if already opened
                if (chelp.CheckOpened("Frm_CustomerInfoImportExport"))
                    return;

                chelp.ShowForm(new Frm_CustomerInfoImportExport());
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
