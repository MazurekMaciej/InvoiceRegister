using InvoiceRegister.Common.DomainModel;

namespace InvoiceRegister.Common
{
    public interface IInvoiceItemManager
    {
        void CreateItem(Pozycja_faktury invoice_item);
        Pozycja_faktury GetInvoiceItem(int Id);
    }
}
