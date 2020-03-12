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
using InvoiceRegister.UI;

namespace InvoiceRegister
{
    public partial class ListInvoicesPanel : UserControl
    {
        public ListInvoicesPanel()
        {
            InitializeComponent();  
        }

        public void ListInvoices()
        {
            Invoice invoice = DependencyResolver.Container.Resolve<Invoice>();
            Account account = DependencyResolver.Container.Resolve<Account>();
            var invoicesList = invoice.ListInvoices(account.GetLoggedUser());

            DataTable dt = new DataTable("Invoices");
            dt.Columns.Add("Numer", System.Type.GetType("System.String"));
            dt.Columns.Add("Data wystawienia", System.Type.GetType("System.DateTime"));
            dt.Columns.Add("Przedmiot transakcji", System.Type.GetType("System.String"));
            dt.Columns.Add("Suma", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Wplacono", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Klient", System.Type.GetType("System.String"));

            foreach (var row in invoicesList)
            {
                if (row.Klient == null)
                    dt.Rows.Add(new object[] { row.Numer, row.Data_wystawienia, row.Przedmiot_transakcji, row.Suma, row.Wplacono, row.Klient });
                else
                    dt.Rows.Add(new object[] { row.Numer, row.Data_wystawienia, row.Przedmiot_transakcji, row.Suma, row.Wplacono, row.Klient.Nazwa});

            }
            invoicesListData.DataSource = dt;
            invoicesListData.MultiSelect = false;
            invoicesListData.ClearSelection();

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void invoicesListData_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
