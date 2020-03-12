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

namespace InvoiceRegister.UI
{
    public partial class InvoicesForm : Form
    {
        public InvoicesForm()
        {
            InitializeComponent();
        }

        public void ListInvoices()
        {
            listInvoicesPanel1.ListInvoices();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void listInvoicesPanel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void listInvoicesPanel1_Load(object sender, EventArgs e)
        {

        }

        private void InvoicesForm_Load(object sender, EventArgs e)
        {
            ListInvoices();
            listInvoicesPanel1.Visible = true;
            addButton.Visible = true;
            editButton.Visible = true;
            refreshButton.Visible = true;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            listInvoicesPanel1.ListInvoices();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            addButton.Visible = false;
            editButton.Visible = false;
            refreshButton.Visible = false;
            listInvoicesPanel1.Visible = false;
            editInvoicePanel1.Visible = true;
            editInvoicePanel1.LoadInvoices();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addButton.Visible = false;
            editButton.Visible = false;
            refreshButton.Visible = false;
            listInvoicesPanel1.Visible = false;
            addInvoicePanel1.Visible = true;
        }
    }
}
