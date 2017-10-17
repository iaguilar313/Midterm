using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    class Cash:Payment
    {
        public override void getTotals(double Gtotal)



        {

            double change =0;

            Console.WriteLine("Please enter the amount cash provided");


            double payment = double.Parse(Console.ReadLine());


             change = payment - Gtotal;


            Console.WriteLine("Your paymet of"+" "+ Gtotal+" "+ "has been processed");
            Console.WriteLine("Your change is" +" "+"$"+ change);
           

            Console.WriteLine(" ");
            Console.WriteLine(" ");

        }


    }
}
