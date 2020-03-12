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
    public class ClientManager : IClientManager
    {
        private IAccountManager _accountManager;
        public ClientManager(IAccountManager accountManager)
        {
            _accountManager = accountManager ?? throw new ArgumentNullException(nameof(accountManager));
        }
        public void CreateClient(Klient client)
        {
            Klient client2 = new Klient();
            client2 = client;
            var user = _accountManager.GetLoggedUser();
            DatabaseContext dbContext = new DatabaseContext();
            try
            {
                var user2 = dbContext.Uzytkownicy.Where(u => u.Id == user.Id).FirstOrDefault();
                client2.Uzytkownik = user2;
                dbContext.Klienci.Add(client2);
                dbContext.SaveChanges();
            }
            catch (ClientException)
            {
                throw new ClientException("Nie udalo sie stworzyc klienta");
            }
        }

        public Klient GetClient(int Id)
        {
            DatabaseContext dbContext = new DatabaseContext();
            try
            {
                Klient client = dbContext.Klienci.Where(c => c.Id == Id).SingleOrDefault();
                return client;
            }
            catch (ClientException)
            {
                throw new ClientException("Klient nie znaleziony");
            }
        }
    }
}
