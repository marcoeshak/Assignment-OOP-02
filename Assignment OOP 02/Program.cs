using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Net.Sockets;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_OOP_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            /*

            a)
                Public fields allow direct access to class data.

                No control or validation over modifying the balance.

                The internal state of the object can be changed from outside the class.



            b)

             Change public fields to private.

            Use public properties to access data.
 
            Apply validation inside properties or methods.


            c) 

            Breaks encapsulation.

            Allows uncontrolled access to data.

            Makes the class harder to maintain and extend.

            */
            #endregion

            #region Q02 
            /*

              Field: Stores data directly.

              Property: Provides controlled access to data using getters and setters.

              Can a property contain logic?

              Yes, properties can include logic such as validation or calculations

            */

            #endregion

            #region Q03

            /*
              a)
               It is called an Indexer.

               It allows objects to be accessed like arrays.

                It provides indexed access to class data.

            b)

            A runtime error (IndexOutOfRangeException) will occur.

           This happens because the index is outside the array bounds.

           How to make the indexer safer

           Add index range validation.

           Prevent access if the index is invalid.

            c)
            Yes, a class can have more than one indexer.

           Indexers can be overloaded using different parameter types.

         Example:

              One indexer using int

             Another indexer using string

            */

            #endregion

            #region Q04
            /*

            a)

            static means the member belongs to the class, not to an object.

            The value is shared among all instances of the class.

            Item is an instance field and is unique for each object.

            b)

            No, a static method cannot access instance fields directly.

           Static members do not belong to a specific object.

           Instance data requires an object reference.
               
             */

            #endregion


            #region Part 2 

            #region Q01
            /*
            بعمل كلاس جديد وبغيره ل enum

            public enum TicketType
           {
            Standard,
            VIP,
            IMAX
            }

            */

            #endregion

            #region Q02

            /*
            بعمل كلاس جديد وبغيره ل Struct
            public struct SeatLocation
        {
            public char Row;
            public int Number;

            public SeatLocation(char row, int number)
            {
                Row = row;
                Number = number;
            }

            public override string ToString()
            {
                return $"{Row}-{Number}";
            }
        }

            */

            #endregion

            #region Q03

            /*
            public class Ticket
        {
            private string movieName;
            private double price;

            private static int ticketCounter = 0;

            public int TicketId { get; }

            public string MovieName
            {
                get => movieName;
                set
                {
                    if (!string.IsNullOrEmpty(value))
                        movieName = value;
                }
            }

            public TicketType Type { get; set; }
            public SeatLocation Seat { get; set; }

            public double Price
            {
                get => price;
                set
                {
                    if (value > 0)
                        price = value;
                }
            }

            public double PriceAfterTax => Price * 1.14;

            public Ticket(string movieName, TicketType type, SeatLocation seat, double price)
            {
                TicketId = ++ticketCounter;
                MovieName = movieName;
                Type = type;
                Seat = seat;
                Price = price;
            }

            public static int GetTotalTicketsSold()
            {
                return ticketCounter;
            }
        }
            */

            #endregion

            #region Q04

            /*
            بعمل كلاس جديد باسم Cinema
            public class Cinema
        {
            private Ticket[] tickets = new Ticket[20];

            public Ticket this[int index]
            {
                get
                {
                    if (index < 0 || index >= tickets.Length)
                        return null;
                    return tickets[index];
                }
                set
                {
                    if (index < 0 || index >= tickets.Length)
                        return;
                    tickets[index] = value;
                }
            }

            public bool AddTicket(Ticket t)
            {
                for (int i = 0; i < tickets.Length; i++)
                {
                    if (tickets[i] == null)
                    {
                        tickets[i] = t;
                        return true;
                    }
                }
                return false;
            }

            public Ticket GetMovieByName(string movieName)
            {
                foreach (var t in tickets)
                {
                    if (t != null && t.MovieName == movieName)
                        return t;
                }
                return null;
            }
        }

            */

            #endregion

            #region Q05

            /*
            بعمل كلاس جديد باسم BookingHelper
            public static 
            lass BookingHelper
        {
            private static int counter = 0;

            public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
            {
                double total = numberOfTickets * pricePerTicket;
                if (numberOfTickets >= 5)
                    return total * 0.9;
                return total;
            }

            public static string GenerateBookingReference()
            {
                counter++;
                return $"BK-{counter}";
            }
        }
            */
            #endregion

            #region Q06

            /*

              Cinema cinema = new Cinema();

              for (int i = 0; i < 3; i++)
              {
                  Console.WriteLine($"Enter data for Ticket {i + 1}:");

                  Console.Write("Movie Name: ");
                  string name = Console.ReadLine();

                  Console.Write("Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
                  TicketType type = (TicketType)int.Parse(Console.ReadLine());

                  Console.Write("Seat Row: ");
                  char row = char.Parse(Console.ReadLine());

                  Console.Write("Seat Number: ");
                  int number = int.Parse(Console.ReadLine());

                  Console.Write("Price: ");
                  double price = double.Parse(Console.ReadLine());

                  Ticket t = new Ticket(name, type, new SeatLocation(row, number), price);
                  cinema.AddTicket(t);
              }

              Console.WriteLine("\n========== All Tickets ==========");
              for (int i = 0; i < 3; i++)
              {
                  Ticket t = cinema[i];
                  Console.WriteLine(
                      $"Ticket #{t.TicketId} | {t.MovieName} | {t.Type} | Seat: {t.Seat} | Price: {t.Price} | After Tax: {t.PriceAfterTax}");
              }

              Console.Write("\nEnter movie name to search: ");
              string search = Console.ReadLine();
              Ticket found = cinema.GetMovieByName(search);

              if (found != null)
                  Console.WriteLine($"Found: Ticket #{found.TicketId} | {found.MovieName}");
              else
                  Console.WriteLine("Not found");

              Console.WriteLine($"\nTotal Tickets Sold: {Ticket.GetTotalTicketsSold()}");

              Console.WriteLine($"Booking Reference 1: {BookingHelper.GenerateBookingReference()}");
              Console.WriteLine($"Booking Reference 2: {BookingHelper.GenerateBookingReference()}");

              double discount = BookingHelper.CalcGroupDiscount(5, 80);
              Console.WriteLine($"Group Discount (5 x 80): {discount}");

            */
            #endregion

            #endregion
        }
    }
}
