using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    class Check:Payment
    {
        public override void getTotals(double Gtotal)

        {

            Console.WriteLine("Please enter your Check Number");

            string ValidateChecknum = Console.ReadLine();



            if (ValidateChecknum.Length!= 9)

            {

                Console.WriteLine("Please enter a valid check number with 9 digits");

            }

            else

            {
                Console.WriteLine("Your Check of" + " " + Gtotal+ "has been processed");
                Console.WriteLine("Thank you for your payment");
                Console.WriteLine(" ");
                Console.WriteLine(" ");

            }



          

        }

    }
}
