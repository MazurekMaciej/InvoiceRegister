using InvoiceRegister.Common.DomainModel;
using System.Collections.Generic;

namespace InvoiceRegister.Common
{
    public interface IInvoiceManager
    {
        void CreateInvoice(Faktura invoice);
        void UpdateInvoice(Faktura invoice);
        void DeleteInvoice(Faktura invoice);
        List<Faktura> ListInvoices(Uzytkownik user);
        Faktura GetInvoice(int Id);


    }
}
