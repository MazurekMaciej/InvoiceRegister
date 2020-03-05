using InvoiceRegister.Common.DomainModel;

namespace InvoiceRegister.Common
{
    public interface ISellerManager
    {
        void CreateSeller(Sprzedawca seller);
        Sprzedawca GetSeller(int Id);
    }
}
