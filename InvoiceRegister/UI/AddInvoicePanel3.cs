using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using InvoiceRegister.Common.DomainModel;

namespace InvoiceRegister.UI
{
    public partial class AddInvoicePanel3 : UserControl
    {
        public AddInvoicePanel3()
        {
            InitializeComponent();
        }

        public Sprzedawca MakeSeller()
        {
            Account account = DependencyResolver.Container.Resolve<Account>();
            Seller seller = DependencyResolver.Container.Resolve<Seller>();

            Sprzedawca sellerInstance = new Sprzedawca
            {
                Nazwa = nameField.Text,
                NIP = nipField.Text,
                PESEL = peselField.Text,
                Miejscowosc = placeField.Text,
                Kod_pocztowy = postField.Text,
                Ulica = streetField.Text,
                Numer_domu = int.Parse(buildingField.Text),
                Numer_lokalu = int.Parse(houseField.Text)
               // Uzytkownik = account.GetLoggedUser()
            };

            seller.CreateSeller(sellerInstance);
            return sellerInstance;
        }

        public void MakeInvoicePart()
        {
            Invoice invoice = DependencyResolver.Container.Resolve<Invoice>();
            Faktura invoiceInstance;
            invoiceInstance = AddInvoicePanel2.invoice2;
            invoiceInstance.Sprzedawca = MakeSeller();

            invoice.CreateInvoice(invoiceInstance);
            //return invoice;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            MakeInvoicePart();
            this.Visible = false;
            this.Parent.Controls[8].Visible = true;
            this.Parent.Controls[0].Visible = true;
            this.Parent.Controls[1].Visible = true;
            this.Parent.Controls[2].Visible = true;
        }

        private void clientTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
