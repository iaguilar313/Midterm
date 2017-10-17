using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    class Credit : Payment
    {
        private string cardnum;

        private string ccv;

        private string exdate;


        public string Cardnum

        {
            set { cardnum = value; }

            get { return cardnum; }
        }

        public string Ccv

        {
            set { ccv = value; }
            get { return ccv; }
        }

        public string ExDate
            {
            set { exdate = value; }
            get { return exdate; }
            }

        public Credit()

        {
            ExDate = " ";
            Ccv = " ";
            Cardnum = " ";

        }
        public Credit(string pCardnum, string pExDate, string pccv)

        {

            Cardnum = pCardnum;
            ExDate = pExDate;
            Ccv = pccv;
        }

        public static string GetValidCCV()
        {

            string ccv = Console.ReadLine();



            if (ccv.Length != 3)

            {
                Console.WriteLine(" Enter a valid Cvv");
                ccv = Console.ReadLine();

            }

            return ccv;
        }

        public static string GetvalidCnumber()

        {
            string Cardnum = Console.ReadLine();

            if (Cardnum.Length != 16)

            {
                Console.WriteLine("Please enter a valid credit card number");

                Cardnum = Console.ReadLine();

            }

            return Cardnum;

        }

        public static string GetValidDate()
        {

            string dateinput = Console.ReadLine();

            if (dateinput.Length !=4)
            {
                Console.WriteLine("Please enter your card's expiration date (MMYY):");
                Console.WriteLine("4 consective digits");
            }
            
           
                return dateinput;
            
            
        }
             

        //bool CheckValidDateTime(int year, int month, int day)
        //{
        //    bool check = false;

        //    while (check == false)

        //        if (year <= DateTime.MaxValue.Year && year >= DateTime.MinValue.Year)

        //        {
        //            if (month >= 1 && month <= 12)

        //            {

        //                if (DateTime.DaysInMonth(year, month) >= day && day >= 1)

        //                    check = true;
        //            }

        //        }

        //    return check;

        //}

        public override void getTotals(double Gtotal)

        {

            Console.WriteLine("Please enter your card number:");

            GetvalidCnumber();

            Console.WriteLine("Please enter your card's CVV:");

            GetValidCCV();

            Console.WriteLine("Please enter your card's expiration date (MM/YY):");

            GetValidDate();

            Console.WriteLine("Your Payment of" +Gtotal+ " "+ "has been processed, Thank you");

            Console.WriteLine(" ");
            Console.WriteLine(" ");


        }



    }
}
