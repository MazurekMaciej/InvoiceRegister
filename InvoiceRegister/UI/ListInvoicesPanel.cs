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

namespace InvoiceRegister
{
    public partial class ListInvoicesPanel : UserControl
    {
        public ListInvoicesPanel()
        {
            InitializeComponent();
           // ListInvoices();
        }

        public void ListInvoices()
        {
            Invoice invoice = DependencyResolver.Container.Resolve<Invoice>();
            Account account = DependencyResolver.Container.Resolve<Account>();
            var invoicesList = invoice.ListInvoices(account.GetLoggedUser());
            invoicesListData.DataSource = invoicesList;

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
