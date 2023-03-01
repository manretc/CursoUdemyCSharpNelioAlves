using System;
using Course.Entities;
using Course.Entities.Exceptions;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aula 143
            /*
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("check-in (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("check-out (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());
            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation");
                Console.Write("check-in (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("check-out (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be future dates");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);
                }
            }*/

            //Aula 144
            /*Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("check-in (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("check-out (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());
            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation");
                Console.Write("check-in (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("check-out (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = reservation.UpdateDates(checkIn, checkOut);
                if (error != null)
                {
                    Console.WriteLine("Error in reservation: " + error);
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);
                }
            }*/

            //Aula 145
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("check-in (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("check-out (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation");
                Console.Write("check-in (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("check-out (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
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
