using System;
using System.Collections.Generic;
using System.Text;

namespace ClubHouse.Exceptions
{
    public class NotAuthorizedException : Exception
    {
        public NotAuthorizedException(string message) : base(message)
        {
        }

        public NotAuthorizedException()
        {
        }

        public NotAuthorizedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
