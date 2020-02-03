using System;
using HotelReservation.Entities.Exceptions;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Ceck-out date must be after Check-In date!");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                // Quando cai no Throw, corta o método, nem executa o que está abaixo
                throw new DomainException("Reservation dates for update must be FUTURE DATES!");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Ceck-out date must be after Check-In date!");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room: "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/mm/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/mm/yyyy")
                + ", "
                + Duration()
                + " nights.";
        }


    }
}
