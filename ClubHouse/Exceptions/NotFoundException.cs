using System;

namespace ClubHouse.Exceptions
{
    [Serializable]
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {
        }

        public NotFoundException()
        {
        }

        public NotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
