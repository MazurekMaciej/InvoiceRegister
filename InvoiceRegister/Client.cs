using InvoiceRegister.Common;
using InvoiceRegister.Common.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceRegister
{
    public class Client
    {
        IClientManager _clientManager;
        public Client(IClientManager clientManager)
        {
            _clientManager = clientManager;
        }

        public void CreateClient(Klient client)
        {
            try
            {
                _clientManager.CreateClient(client);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
