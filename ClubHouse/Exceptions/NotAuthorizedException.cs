using System;

namespace ClubHouse.Exceptions
{
    /// <summary>
    /// Not Authorized - HTTP401. Check the Clubhouse API token which was supplied.
    /// </summary>
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
