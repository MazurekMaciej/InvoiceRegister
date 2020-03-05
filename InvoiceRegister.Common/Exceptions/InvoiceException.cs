using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceRegister.Common.Exceptions
{
    public class InvoiceException : Exception
    {
        public InvoiceException() { }

        public InvoiceException(string message)
        : base(message) { }

        public InvoiceException(string message, Exception inner)
      : base(message, inner) { }
    }
}
