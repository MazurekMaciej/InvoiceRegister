using InvoiceRegister.Common;
using InvoiceRegister.Common.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceRegister
{
    public class Seller
    {
        ISellerManager _sellerManager;
        public Seller(ISellerManager sellerManager)
        {
            _sellerManager = sellerManager;
        }

        public void CreateSeller(Sprzedawca seller)
        {
            try
            {
                _sellerManager.CreateSeller(seller);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
