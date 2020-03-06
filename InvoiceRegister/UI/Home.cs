using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace InvoiceRegister
{
    public partial class Home : Form
    {
        public static bool IsLoggedIn { get; set; }
        public Home()
        {
            InitializeComponent();
            loginPanel1.Visible = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void zalogujButton_Click(object sender, EventArgs e)
        {
            loginPanel1.Visible = true;
            registerPanel1.Visible = false;
        }

        private void zarejestrujButton_Click(object sender, EventArgs e)
        {
            registerPanel1.Visible = true;
            loginPanel1.Visible = false;
        }

        public void showInvoicesPanel()
        {
            listInvoicesPanel1.Visible = true;
            registerPanel1.Visible = false;
            loginPanel1.Visible = false;
        }

        private void testListButton_Click(object sender, EventArgs e)
        {
            listInvoicesPanel1.Visible = true;
            registerPanel1.Visible = false;
            loginPanel1.Visible = false;
            ListInvoicesPanel listInvoicesPanel = DependencyResolver.Container.Resolve<ListInvoicesPanel>();
            listInvoicesPanel.ListInvoices();
        }
    }
}
