using InvoiceRegister.Common;
using InvoiceRegister.Common.DomainModel;
using InvoiceRegister.Common.Exceptions;
using InvoiceRegister.Data;
using System;
using System.Linq;

namespace InvoiceRegister.Business.Managers
{
    public class AccountManager : IAccountManager
    {
        public static int IDActualUser { get; set; }
        public AccountManager()
        {

        }

        public Uzytkownik Login(string userName, string password)
        {
            DatabaseContext dbContext = new DatabaseContext();
            var user = dbContext.Uzytkownicy.Where(u => u.Login == userName).SingleOrDefault();

            if (user != null)
            {
                if (password == user.Hasło)
                {
                    IDActualUser = user.Id;
                    return user;
                }
                else
                {
                    throw new PasswordInvalidException("Nieprawidłowe hasło");
                }
            }
            else
            {
                throw new UsernameInvalidException("Nie znaleziono uzytkownika");
            }
        }

        public void Logout(Uzytkownik user)
        {
            if (!IsLoggedIn())
            {
                throw new UserNotFoundException("Uzytkownik nie jest zalogowany");
            }

        }

        public void Register(Uzytkownik user)
        {
            DatabaseContext dbContext = new DatabaseContext();
            if (user.Login == "" || user.Hasło == "")
            {
                throw new RegistrationException("Login/hasło nie wprowadzone");
            }
            else
            {
                try
                {
                    dbContext.Uzytkownicy.Add(user);
                    dbContext.SaveChanges();
                }
                catch (Exception)
                {
                    throw new RegistrationException("Ten uzytkownik juz istnieje");
                }
            }
        }

        public Uzytkownik GetLoggedUser()
        {
            DatabaseContext dbContext = new DatabaseContext();
            try
            {
                var user = dbContext.Uzytkownicy.Where(u => u.Id == IDActualUser).SingleOrDefault();
                return user;
            }
            catch
            {
                throw new UserNotFoundException("Nie znaleziono zalogowanego uzytkownika");
            }
        }

        public bool IsLoggedIn()
        {
            return GetLoggedUser() != null;
        }

    }
}
