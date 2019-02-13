using System;
using Hotel_Reservation.Entities;
using Hotel_Reservation.Entities.Exceptions;
namespace Hotel_Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime chekIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out data (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(number, chekIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                chekIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(chekIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
