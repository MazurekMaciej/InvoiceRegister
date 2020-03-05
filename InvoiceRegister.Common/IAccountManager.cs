using InvoiceRegister.Common.DomainModel;

namespace InvoiceRegister.Common
{
    public interface IAccountManager
    {
        Uzytkownik Login(string userName, string password);
        void Logout(Uzytkownik user);
        void Register(Uzytkownik user);
        //int? GetLoggedUserId();
        bool IsLoggedIn();
        Uzytkownik GetLoggedUser();
    }
}
