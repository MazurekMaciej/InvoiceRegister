using InvoiceRegister.Common;
using InvoiceRegister.Common.DomainModel;
using InvoiceRegister.Common.Exceptions;
using InvoiceRegister.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceRegister.Business.Managers
{
    public class InvoiceManager : IInvoiceManager
    {
        private IAccountManager _accountManager;
        public InvoiceManager(IAccountManager accountManager)
        {
            _accountManager = accountManager ?? throw new ArgumentNullException(nameof(accountManager));
        }
        public List<Faktura> ListInvoices(Uzytkownik user)
        {
            List<Faktura> listInvoices = new List<Faktura>();
            //DatabaseContext dbContext = new DatabaseContext();
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                var loggedUser = _accountManager.GetLoggedUser();
                int id = loggedUser.Id;
                listInvoices = dbContext.Faktury.Where(inv => inv.Id == id).ToList();
                return listInvoices;
            }
        }
        public void CreateInvoice(Faktura invoice)
        {
            // DatabaseContext dbContext = new DatabaseContext();
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                try
                {
                    dbContext.Faktury.Add(invoice);
                    dbContext.SaveChanges();
                }
                catch (InvoiceException)
                {
                    throw new InvoiceException("Invoice cannot be created");
                }
            }
        }

        public void DeleteInvoice(Faktura invoice)
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                try
                {
                    dbContext.Faktury.Remove(invoice);
                    dbContext.SaveChanges();
                }
                catch (InvoiceException)
                {
                    throw new InvoiceException("Invoice cannot be deleted");
                }
            }
        }

        public void UpdateInvoice(Faktura invoice)
        {
            DatabaseContext dbContext = new DatabaseContext();
            Faktura invoiceToUpdate = dbContext.Faktury.Where(inv => inv.Id == invoice.Id).SingleOrDefault();

            if (invoiceToUpdate != null)
            {
                try
                {
                    invoiceToUpdate.Numer = invoice.Numer;
                    invoiceToUpdate.Data_wystawienia = invoice.Data_wystawienia;
                    invoiceToUpdate.Data_sprzedazy = invoice.Data_sprzedazy;
                    invoiceToUpdate.Sposob_platnosci = invoice.Sposob_platnosci;
                    invoiceToUpdate.Suma = invoice.Suma;
                    invoiceToUpdate.Wplacono = invoice.Wplacono;
                    invoiceToUpdate.Uwagi = invoice.Uwagi;
                    invoiceToUpdate.Klient = invoice.Klient;
                    invoiceToUpdate.Sprzedawca = invoice.Sprzedawca;

                    dbContext.SaveChanges();
                }
                catch (InvoiceException)
                {
                    throw new InvoiceException("Invoice cannot be updated");
                }
            }
            else
            {
                throw new InvoiceException("Invoice cannot be updated. There is no such a invoice.");
            }

        }

        public Faktura GetInvoice(int Id)
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                Faktura invoice = dbContext.Faktury.Where(inv => inv.Id == Id).SingleOrDefault();
                if (invoice != null)
                {
                    return invoice;
                }
                else
                {
                    throw new InvoiceException("Invoice not found");
                }
            }
        }

    }
}
