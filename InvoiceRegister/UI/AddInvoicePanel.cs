using System;
using System.Windows.Forms;
using InvoiceRegister.Common.DomainModel;
using Unity;

namespace InvoiceRegister.UI
{
    public partial class AddInvoicePanel : UserControl
    {
        public static Faktura invoice1;
        public AddInvoicePanel()
        {
            InitializeComponent();
        }

        public Faktura MakeInvoicePart()
        {
            Account account = DependencyResolver.Container.Resolve<Account>();
            Faktura invoice = new Faktura
            {
                Numer = numerField.Text,
                Data_wystawienia = Convert.ToDateTime(data_wystawField.Text),
                Data_sprzedazy = Convert.ToDateTime(data_sprzedazField.Text),
                Sposob_platnosci = platnoscField.Text,
                Przedmiot_transakcji = productField.Text,
                Suma = double.Parse(sumaField.Text),
                Wplacono = double.Parse(wplaconoField.Text),
                Uwagi = commentsField.Text
              //  Uzytkownik = account.GetLoggedUser()
            };
            return invoice;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            invoice1 = MakeInvoicePart();
            this.Visible = false;
            this.Parent.Controls[6].Visible = true;
        }
    }
}
