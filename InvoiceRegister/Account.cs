using InvoiceRegister.Common;
using InvoiceRegister.Common.DomainModel;
using InvoiceRegister.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceRegister
{
    public class Account
    {
        IAccountManager _accountManager;
        public Account(IAccountManager accountManager)
        {
            _accountManager = accountManager ?? throw new ArgumentNullException(nameof(accountManager));
        }

        public void LogIn(string username, string password)
        {
            try
            {
                var user = _accountManager.Login(username, password);
                Home.IsLoggedIn = true;
                MessageBox.Show("You successfully logged in");
            }
            catch(UsernameInvalidException e)
            {
                MessageBox.Show(e.Message);
            }
            catch(PasswordInvalidException e)
            {
                MessageBox.Show(e.Message);
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        public void Register(string username, string password)
        {
            Uzytkownik user = new Uzytkownik
            {
                Login = username,
                Hasło = password
            };
            try
            {
                _accountManager.Register(user);
                MessageBox.Show("You successfully registered. Now you can Log in");
            }
            catch (RegistrationException e)
            {
                MessageBox.Show(e.Message);
            }
            catch
            {
                MessageBox.Show("Try again with different credentials");
            }
        }

        public Uzytkownik GetLoggedUser()
        {
            Uzytkownik user = new Uzytkownik();
            try
            {
                user = _accountManager.GetLoggedUser();
                return user;
            }
            catch(UserNotFoundException e)
            {
                MessageBox.Show("No logged user found");
            }
            catch
            {
                MessageBox.Show("Try again with different credentials");
            }
            return user;
        }

    }
}
