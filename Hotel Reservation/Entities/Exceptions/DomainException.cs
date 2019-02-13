using System;
namespace Hotel_Reservation.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base (message)
        {

        }
    }
}
