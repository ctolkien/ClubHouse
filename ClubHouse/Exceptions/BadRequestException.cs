using System;
using System.Collections.Generic;
using System.Text;

namespace ClubHouse.Exceptions
{
    [Serializable]
    public class BadRequestException : Exception
    {
        public BadRequestException()
        {

        }
    }

    [Serializable]
    public class NotFoundException : Exception
    {

    }

    [Serializable]
    public class UnprocessableException : Exception
    {

    }
}
