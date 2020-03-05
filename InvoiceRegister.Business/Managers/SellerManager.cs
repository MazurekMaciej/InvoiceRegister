using InvoiceRegister.Common;
using InvoiceRegister.Common.DomainModel;
using InvoiceRegister.Common.Exceptions;
using InvoiceRegister.Data;
using System;
using System.Linq;

namespace InvoiceRegister.Business.Managers
{
    public class SellerManager : ISellerManager
    {
        public SellerManager()
        {

        }
        public void CreateSeller(Sprzedawca seller)
        {
            DatabaseContext dbContext = new DatabaseContext();
            try
            {
                dbContext.Sprzedawcy.Add(seller);
                dbContext.SaveChanges();
            }
            catch (ClientException)
            {
                throw new ClientException("Client cannot be created");
            }
        }

        public Sprzedawca GetSeller(int Id)
        {
            DatabaseContext dbContext = new DatabaseContext();
            try
            {
                Sprzedawca seller = dbContext.Sprzedawcy.Where(c => c.Id == Id).SingleOrDefault();
                return seller;
            }
            catch (ClientException)
            {
                throw new ClientException("Client not found");
            }
        }
    }
}
