using System;

namespace InvoiceRegister.Common.Exceptions
{
    public class UsernameInvalidException : Exception
    {
        public string UserName { get; }

        public UsernameInvalidException() { }

        public UsernameInvalidException(string message)
        : base(message) { }

        public UsernameInvalidException(string message, Exception inner)
      : base(message, inner) { }

        public UsernameInvalidException(string message, string userName)
            : this(message)
        {
            UserName = userName;
        }
    }
}
