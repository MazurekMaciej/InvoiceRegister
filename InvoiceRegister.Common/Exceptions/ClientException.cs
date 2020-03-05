using System;

namespace InvoiceRegister.Common.Exceptions
{
    public class ClientException : Exception
    {
        public ClientException() { }

        public ClientException(string message)
        : base(message) { }

        public ClientException(string message, Exception inner)
      : base(message, inner) { }
    }
}
