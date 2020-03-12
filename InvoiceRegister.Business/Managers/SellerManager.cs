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
        private IAccountManager _accountManager;
        public SellerManager(IAccountManager accountManager)
        {
            _accountManager = accountManager ?? throw new ArgumentNullException(nameof(accountManager));
        }
        public void CreateSeller(Sprzedawca seller)
        {
            Sprzedawca seller2 = new Sprzedawca();
            seller2 = seller;
            var user = _accountManager.GetLoggedUser();
            DatabaseContext dbContext = new DatabaseContext();
            try
            {
                var actualUser = dbContext.Uzytkownicy.Where(u => u.Id == user.Id).FirstOrDefault();
                seller2.Uzytkownik = actualUser;
                dbContext.Sprzedawcy.Add(seller2);
                dbContext.SaveChanges();
            }
            catch (ClientException)
            {
                throw new ClientException("Blad, sprzedawca nie utworzony");
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
                throw new ClientException("Blad, sprzedawca nie znaleziony");
            }
        }
    }
}
