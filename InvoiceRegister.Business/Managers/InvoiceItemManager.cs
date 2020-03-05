using InvoiceRegister.Common;
using InvoiceRegister.Common.DomainModel;
using InvoiceRegister.Data;
using InvoiceRegister.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceRegister.Business.Managers
{
    public class InvoiceItemManager : IInvoiceItemManager
    {
        public InvoiceItemManager()
        {

        }
        public void CreateItem(Pozycja_faktury invoice_item)
        {
            DatabaseContext dbContext = new DatabaseContext();
            try
            {
                dbContext.Pozycje_faktury.Add(invoice_item);
                dbContext.SaveChanges();
            }
            catch (InvoiceItemException)
            {
                throw new InvoiceItemException("Invoice Item cannot be created");
            }
        }

        public Pozycja_faktury GetInvoiceItem(int Id)
        {
            DatabaseContext dbContext = new DatabaseContext();
            try
            {
                Pozycja_faktury invoice_item = dbContext.Pozycje_faktury.Where(i => i.Id_pozycja == Id).SingleOrDefault();
                return invoice_item;
            }
            catch (InvoiceItemException)
            {
                throw new InvoiceItemException("Invoice Item not found");
            }
        }
    }
}
