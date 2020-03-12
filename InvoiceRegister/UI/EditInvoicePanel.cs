using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvoiceRegister.Common.DomainModel;
using Unity;

namespace InvoiceRegister.UI
{
    public partial class EditInvoicePanel : UserControl
    {
        public EditInvoicePanel()
        {
            InitializeComponent();
        }

        public void LoadInvoices()
        {
            Invoice invoice = DependencyResolver.Container.Resolve<Invoice>();
            Account account = DependencyResolver.Container.Resolve<Account>();
            var listInvoices = invoice.ListInvoices(account.GetLoggedUser());
            invoiceChooserBox.ValueMember = "Id";
            invoiceChooserBox.DisplayMember = "Numer";
            invoiceChooserBox.DataSource = listInvoices;
            invoiceChooserBox.SelectedIndex = listInvoices.Count > 0 ? 0 : -1;
        }

        public void GetInvoice(int id)
        {
            Invoice invoice = DependencyResolver.Container.Resolve<Invoice>();
            Faktura selectedInvoice = invoice.GetInvoice(id);

            numerField.Text = selectedInvoice.Numer;
            data_wystawField.Text = selectedInvoice.Data_wystawienia.ToString();
            data_sprzedazField.Text = selectedInvoice.Data_sprzedazy.ToString();
            platnoscField.Text = selectedInvoice.Sposob_platnosci;
            productField.Text = selectedInvoice.Przedmiot_transakcji;
            sumaField.Text = selectedInvoice.Suma.ToString();
            wplaconoField.Text = selectedInvoice.Wplacono.ToString();
            commentsField.Text = selectedInvoice.Uwagi.ToString();
        }

        public void UpdateInvoice()
        {
            Invoice invoice = DependencyResolver.Container.Resolve<Invoice>();
            Faktura invoiceToUpdate = new Faktura
            {
                Id = int.Parse(invoiceChooserBox.SelectedValue.ToString()),
                Numer = numerField.Text,
                Data_wystawienia = Convert.ToDateTime(data_wystawField.Text),
                Data_sprzedazy = Convert.ToDateTime(data_sprzedazField.Text),
                Sposob_platnosci = platnoscField.Text,
                Przedmiot_transakcji = productField.Text,
                Suma = double.Parse(sumaField.Text),
                Wplacono = double.Parse(wplaconoField.Text),
                Uwagi = commentsField.Text
            };
            invoice.UpdateInvoice(invoiceToUpdate);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
                UpdateInvoice();
        }

        private void invoiceChooserBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (invoiceChooserBox.SelectedValue != null)
            {
                var invoiceId = invoiceChooserBox.SelectedValue.ToString();
                GetInvoice(int.Parse(invoiceId));
            }

        }

        private void backToListButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;           
            this.Parent.Controls[8].Visible = true;
            this.Parent.Controls[0].Visible = true;
            this.Parent.Controls[1].Visible = true;
            this.Parent.Controls[2].Visible = true;
        }
    }
}
