using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    class PackageTest
    {
        static void Main(string[] args)
        {
            //Creating object for Two Day Package
            TwoDayPackage purchaser1 = new TwoDayPackage(101, "Peter Yoon", "123 Fourclover Lane", 10.00);
            Console.WriteLine(purchaser1.ToString());
            {
                double weight = 500.0;
                double ratePerGram = 0.1;
                double adminCharge = 10;
                double twoDayCost = purchaser1.CalculatePackageCost(weight, ratePerGram, adminCharge);
                Console.WriteLine("Weight in grams: {0}g \nRate per gram: {1:c} \nTwo day delivery cost: {2:c}\n",
                    weight, ratePerGram, twoDayCost);
            }
            OverNightPackage purchaser2 = new OverNightPackage(102, "Peter Parker", "456 Trono Ave.", 0.0);
            Console.WriteLine(purchaser2.ToString());
            {
                double weight = 200.0;
                double ratePerGram = 0.1;
                double adminCharge = 0;
                double overNightCost = purchaser2.CalculatePackageCost(weight, ratePerGram, adminCharge);
                Console.WriteLine("Weight in grams: {0}g \nRate per gram: {1:c} \nOvernight delivery cost: {2:c}", weight, ratePerGram+0.1, overNightCost);
            }
        }
    }
}
