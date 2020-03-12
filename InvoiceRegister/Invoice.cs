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
                var user2 = account.GetLoggedUser();
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
            try
            {
                _invoiceManager.CreateInvoice(invoice);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        public void UpdateInvoice(Faktura invoice)
        {
            try
            {
                _invoiceManager.UpdateInvoice(invoice);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public Faktura GetInvoice(int id)
        {
            try
            {
                Faktura invoice = _invoiceManager.GetInvoice(id);
                return invoice;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

    }
}
