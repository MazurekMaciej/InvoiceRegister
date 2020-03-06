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
    public partial class LoginPanel : UserControl
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Account account = DependencyResolver.Container.Resolve<Account>();
            Home home = DependencyResolver.Container.Resolve<Home>();

            string user = username.Text;
            string pass = password.Text;
            if (user == "" || pass == "")
                MessageBox.Show("You didn't fill username or password");
            else
            {
                account.LogIn(user, pass);
                home.showInvoicesPanel();
            }
                 
        }
    }
}
