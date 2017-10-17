using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Project
{
     class FinancialServices
    {

        private int listnum;
        private string product;
        private double cost;
        private double intRate;


        public int Listnum
        {
            set { listnum = value; }
            get { return listnum; }
        }

        public string Product
        {
            set { product = value; }
            get { return product; }
        }
        public double Cost
        {
            set { cost = value; }
            get { return cost; }
        }
        public double IntRate
        {
            set { intRate = value; }
            get { return intRate; }
        }

        public FinancialServices()
        {
            Listnum = 0;
            Product = "";
            Cost = 0;
            IntRate = 0;
        }

        public FinancialServices(int fListNum, string fproduct, double theCost, double rate)
        {
            Listnum = fListNum;
            Product = fproduct;
            Cost = theCost;
            IntRate = rate;
        }























    }
}
