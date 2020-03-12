using InvoiceRegister.UI;
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
           // this.Opacity = 0.0f;
            //this.ShowInTaskbar = false;
           // this.Hide();
            var form2 = DependencyResolver.Container.Resolve<InvoicesForm>();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void testListButton_Click(object sender, EventArgs e)
        {
           // this.Opacity = 0.0f;
           // this.ShowInTaskbar = false;
           // this.Hide();
            var form2 = DependencyResolver.Container.Resolve<InvoicesForm>();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
