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
       // private IAccountManager _accountManager;
        public ClientManager(/*IAccountManager accountManager*/)
        {
           // _accountManager = accountManager ?? throw new ArgumentNullException(nameof(accountManager));
        }
        public void CreateClient(Klient client)
        {
            DatabaseContext dbContext = new DatabaseContext();
            try
            {
                dbContext.Klienci.Add(client);
                dbContext.SaveChanges();
            }
            catch (ClientException)
            {
                throw new ClientException("Client cannot be created");
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
                throw new ClientException("Client not found");
            }
        }
    }
}
