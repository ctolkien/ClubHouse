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
    }
}
