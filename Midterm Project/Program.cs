using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rocket FinTech");
            Console.WriteLine(" ");

            //Mortgages sevenYrFx = new Mortgages(7, 2000, .03);


            //Console.WriteLine("Below is a full list of our Amazing Products");
            Console.WriteLine(" ");
            //Console.WriteLine("Product\t" + "   " + "MonthlyCost\tInterestRate");

            //StreamWriter fs = new StreamWriter("FSProducts.txt");
            #region Products
            //fs.WriteLine("1\t7YearFXM\t2000\t0.030");
            //fs.WriteLine("2\t10yrFXM\t2050\t0.035");
            //fs.WriteLine("3\t15yrFXM\t2075\t0.040");
            //fs.WriteLine("4\t25yrFXM\t2100\t0.045");
            //fs.WriteLine("5\t30yrFXM\t2125\t0.050");
            //fs.WriteLine("6\t5KLoan\t125\t0.15");
            //fs.WriteLine("7\t10kLoan\t250\t.25");
            //fs.WriteLine("8\t20kLoan\t300\t.27");
            //fs.WriteLine("9\t30kLoan\t400\t.30");
            //fs.WriteLine("10\t50kLoan\t500\t.40");
            //fs.WriteLine("11\tFullInsurance\t200");
            //fs.WriteLine("12\tFireInsurance\t100");

            //fs.Close();
            #endregion

            List<FinancialServices> Cart = new List<FinancialServices>();
            List<FinancialServices> Menu = new List<FinancialServices>();
            StreamReader rd = new StreamReader("FSProducts.txt");

            //  string str2 = rd.ReadToEnd();
            //  Console.WriteLine(str2);

            string MenuList = "";
            while (!rd.EndOfStream)
            {
                string str = rd.ReadLine();

                MenuList = MenuList + str + "\n";
                var ShopFS = str.Split(',');

                FinancialServices addProduct = new FinancialServices();
                addProduct.Listnum = int.Parse(ShopFS[0]);
                addProduct.Product = ShopFS[1];

                addProduct.Cost = double.Parse(ShopFS[2]);
                addProduct.IntRate = double.Parse(ShopFS[3]);
                Menu.Add(addProduct);
            }


            int UserInput = 0;
            while (true)
            {
                Console.WriteLine("What would you like to do(Please select an option)");
                Console.WriteLine("1. Add one our great products");
                Console.WriteLine("2. CheckOut");
                Console.WriteLine("3. Get further information from via phone");

                UserInput = int.Parse(Console.ReadLine());



                if (UserInput == 1)
                {
                    Console.WriteLine("Please select an amazing product from the listed menu by number");
                    Console.WriteLine(" ");
                    Console.WriteLine("Product\t" + "   " + "MonthlyCost\tInterestRate");
                    Console.WriteLine(MenuList);
                    int productChoice = int.Parse(Console.ReadLine());
                    // int choiceqty = int.Parse(Console.ReadLine());




                    // FinancialServices addtocart = new FinancialServices();

                    Cart.Add(Menu[productChoice]);
                    // Console.WriteLine(Cart);

                }
                else if (UserInput == 2)
                {
                    double Stotal = 0;
                    double Gtotal = 0;
                   // double getpmt = 0;
                    double Salestax = 0;
                    double taxrate = 0.06;
                    Console.WriteLine(" ");
                    Console.WriteLine("Items in your cart");
                    Console.WriteLine(new string('*',10));
                    for (int i = 0; i < Cart.Count; i++)
                    {

                        Stotal = Stotal + Cart[i].Cost;
                        Salestax = taxrate * Stotal;
                        Gtotal = (Stotal * taxrate) + Stotal;

                        Console.WriteLine("Product Selected"+" " +Cart[i].Product + ","+"Monthly Cost"+ " "+"$"+Cart[i].Cost);
                    }
                    Console.WriteLine(new string('*', 10));
                    Console.WriteLine("Your subtotal is" + " " +"$"+ Stotal);

                    Console.WriteLine("Your Tax is" +" " +"$"+ Salestax );
                    Console.WriteLine("Your Grand total with tax is" +" "+"$"+Gtotal);
                    Console.WriteLine(" ");
                    Console.WriteLine("How you like to pay today? Credit, Cash, or Check?");

                    string PmtChoice = Console.ReadLine().ToLower();

                    if (PmtChoice == "Credit" || PmtChoice == "credit")

                    {

                        Credit PaymentOptionCard = new Credit();

                        PaymentOptionCard.getTotals(Gtotal);
                    }
                    else if ((PmtChoice == "cash") || (PmtChoice == "Cash"))

                    {

                        Cash PaymentOptionCash = new Cash();
                        PaymentOptionCash.getTotals(Gtotal);

                    }
                    else if (PmtChoice == "Check" || PmtChoice == "check")

                    {

                        Check PaymentOptionCheck = new Check();
                        PaymentOptionCheck.getTotals(Gtotal);

                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid payment method");
                    }

                }

                else
                {
                    Console.WriteLine("Please provide your phone number one of reps will contact you within 24 hours");
                }












            }
        }
    }
}