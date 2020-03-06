using InvoiceRegister.Common;
using InvoiceRegister.Common.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace InvoiceRegister
{
    public class Invoice
    {
        IInvoiceManager _invoiceManager;
        public Invoice(IInvoiceManager invoiceManager)
        {
            _invoiceManager = invoiceManager ?? throw new ArgumentNullException(nameof(invoiceManager));
        }

        public List<Faktura> ListInvoices(Uzytkownik user)
        {
            List<Faktura> invoicesList = new List<Faktura>();
            Account account = DependencyResolver.Container.Resolve<Account>();
            try
            {
                Uzytkownik user2 = new Uzytkownik { Id = 2 };
                invoicesList = _invoiceManager.ListInvoices(user2);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return invoicesList;
        }

        public void CreateInvoice(Faktura invoice)
        {

        }
    }
}
