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
            using (DatabaseContext dbContext = new DatabaseContext())
            {
               // var loggedUser = _accountManager.GetLoggedUser();
              //  int id = loggedUser.Id;
                listInvoices = dbContext.Faktury.Include("Klient").Where(inv => inv.Uzytkownik.Id == user.Id).ToList();
                return listInvoices;
            }
        }
        public void CreateInvoice(Faktura invoice)
        {
            var clientId = invoice.Klient.Id;
            var sellerId = invoice.Sprzedawca.Id;
            
            Faktura invoice2 = new Faktura();
            invoice2 = invoice;
            var actualUser = _accountManager.GetLoggedUser();
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                try
                {
                    var user = dbContext.Uzytkownicy.Where(u => u.Id == actualUser.Id).FirstOrDefault();
                    var client = dbContext.Klienci.Where(c => c.Id == invoice.Klient.Id).FirstOrDefault();
                    var seller = dbContext.Sprzedawcy.Where(s => s.Id == invoice.Sprzedawca.Id).FirstOrDefault();
                    invoice2.Klient = client;
                    invoice2.Sprzedawca = seller;
                    invoice2.Uzytkownik = user;
                    dbContext.Faktury.Add(invoice2);
                    dbContext.SaveChanges();
                }
                catch (InvoiceException)
                {
                    throw new InvoiceException("Blad, faktura nie utworzona");
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
                    throw new InvoiceException("Blad, faktura nie usunieta");
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
                    invoiceToUpdate.Przedmiot_transakcji = invoice.Przedmiot_transakcji;
                    invoiceToUpdate.Suma = invoice.Suma;
                    invoiceToUpdate.Wplacono = invoice.Wplacono;
                    invoiceToUpdate.Uwagi = invoice.Uwagi;
                   // invoiceToUpdate.Klient = invoice.Klient;
                   // invoiceToUpdate.Sprzedawca = invoice.Sprzedawca;

                    dbContext.SaveChanges();
                }
                catch (InvoiceException)
                {
                    throw new InvoiceException("Blad, faktura nie zaktualizowana");
                }
            }
            else
            {
                throw new InvoiceException("Nie ma takiej faktury");
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
                    throw new InvoiceException("Faktura nie znaleziona");
                }
            }
        }

    }
}
