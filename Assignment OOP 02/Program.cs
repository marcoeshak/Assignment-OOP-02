using System.ComponentModel.DataAnnotations;

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
        }
    }
}
