using System;

namespace InvoiceRegister.Common.Exceptions
{
    public class SellerException : Exception
    {
        public SellerException() { }

        public SellerException(string message)
        : base(message) { }

        public SellerException(string message, Exception inner)
      : base(message, inner) { }
    }
}
