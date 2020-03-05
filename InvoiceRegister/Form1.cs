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
    public partial class Form1 : Form
    {
        public static bool IsLoggedIn { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account account = DependencyResolver.Container.Resolve<Account>();
            string user = username.Text;
            string pass = password.Text;
            if (user == "" || pass == "")
                MessageBox.Show("You didn't fill username or password");
            else
                account.Register(user, pass);

        }
    }
}
