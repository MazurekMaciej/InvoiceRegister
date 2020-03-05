using InvoiceRegister.Common.DomainModel;

namespace InvoiceRegister.Common
{
    public interface IClientManager
    {
        void CreateClient(Klient client);
        Klient GetClient(int Id);
    }
}
