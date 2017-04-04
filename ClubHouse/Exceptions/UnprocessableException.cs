using System;

namespace ClubHouse.Exceptions
{
    [Serializable]
    public class UnprocessableException : Exception
    {
        public UnprocessableException(string message) : base(message)
        {
        }
    }
}
