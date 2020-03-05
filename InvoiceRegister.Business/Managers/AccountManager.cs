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
                    throw new PasswordInvalidException("Invalid password");
                }
            }
            else
            {
                throw new UsernameInvalidException("User cannot be found");
            }
        }

        public void Logout(Uzytkownik user)
        {
            if (!IsLoggedIn())
            {
                throw new UserNotFoundException("User is not logged in");
            }

        }

        public void Register(Uzytkownik user)
        {
            DatabaseContext dbContext = new DatabaseContext();
            if (user.Login == "" || user.Hasło == "")
            {
                throw new RegistrationException("Registration error. Username/passoword not provided");
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
                    throw new RegistrationException("Registration failed. User already exists");
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
                throw new UserNotFoundException("No logged user found");
            }
        }

        public bool IsLoggedIn()
        {
            return GetLoggedUser() != null;
        }

    }
}
