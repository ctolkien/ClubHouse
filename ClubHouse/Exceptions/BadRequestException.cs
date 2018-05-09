using System;

namespace ClubHouse.Exceptions
{
    /// <summary>
    /// Bad Request - HTTP400. Typically this will be caused if the JSON model does not match what Clubhouse.io expects
    /// </summary>
    [Serializable]
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base(message)
        {
        }

        public BadRequestException()
        {
        }

        public BadRequestException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
