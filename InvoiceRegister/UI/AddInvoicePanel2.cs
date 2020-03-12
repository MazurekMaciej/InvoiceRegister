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
    public partial class AddInvoicePanel2 : UserControl
    {
        public static Faktura invoice2;
        public AddInvoicePanel2()
        {
            InitializeComponent();
        }

        public Klient MakeClient()
        {
            Account account = DependencyResolver.Container.Resolve<Account>();
            Client client = DependencyResolver.Container.Resolve<Client>();

            Klient clientInstance = new Klient
            {
                Nazwa = nameField.Text,
                NIP = nipField.Text,
                PESEL = peselField.Text,
                Miejscowosc = placeField.Text,
                Kod_pocztowy = postField.Text,
                Ulica = streetField.Text,
                Numer_domu = int.Parse(buildingField.Text),
                Numer_lokalu = int.Parse(houseField.Text)
                //Uzytkownik = account.GetLoggedUser()
            };

            client.CreateClient(clientInstance);
            return clientInstance;
        }

        public void MakeInvoicePart()
        {
            Faktura invoice;
            invoice = AddInvoicePanel.invoice1;
            invoice.Klient = MakeClient();
            invoice2 = invoice;
           // return invoice;
        }

        private void clientTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            MakeInvoicePart();
            this.Visible = false;
            this.Parent.Controls[6].Visible = true;
        }
    }
}
