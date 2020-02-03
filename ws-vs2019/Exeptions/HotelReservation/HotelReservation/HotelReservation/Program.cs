using System;
using HotelReservation.Entities;
using HotelReservation.Entities.Exceptions;
namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Console.WriteLine("*=*=*=*=*=*=*= HOTEL RESERVATION SYSTEM *=*=*=*=*=*=*=");

                Console.WriteLine("ENTER THE RESERVATION DATA");

                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/mm/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/mm/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

                Console.WriteLine("Enter data to UpDate the Reservation: ");

                Console.Write("Check-In date (dd/mm/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-Out date (dd/mm/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservarion: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            // tipo mais generico de exceção
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

        }
    }
}
