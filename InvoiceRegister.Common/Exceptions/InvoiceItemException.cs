using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceRegister.Common.Exceptions
{
    public class InvoiceItemException : Exception
    {
        public InvoiceItemException() { }

        public InvoiceItemException(string message)
        : base(message) { }

        public InvoiceItemException(string message, Exception inner)
      : base(message, inner) { }
    }
}
