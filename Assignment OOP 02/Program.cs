using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
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

            #endregion
    }
    }
}
