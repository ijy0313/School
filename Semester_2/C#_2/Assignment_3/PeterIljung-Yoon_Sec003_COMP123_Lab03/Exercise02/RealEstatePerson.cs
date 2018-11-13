using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class RealEstatePerson : SalesPerson, ISellable
    {
        public static readonly double CommissionRate;
        static RealEstatePerson()
        {
            CommissionRate = 2.0;
        }

        int totalValueSold = 0;
        double totalCommissionEarned = 0.0;
        //Initiate values

        public int TotalValueSold
        {
            get
            {
                return totalValueSold;
            }
            set
            {
                totalValueSold = value;
            }
        }
        public double TotalCommissionEarned
        {
            get
            {
                return totalCommissionEarned;
            }
            set
            {
                totalCommissionEarned = value;
            }
        }
        public RealEstatePerson(string firstName, string lastName)
        : base(firstName, lastName)
        {
        }//Link child class to abstract class
        public void SalesSpeech()
        {
            Console.WriteLine("My name is {0} and I sell houses", FullName());
        }
        public void MakeSale(int houseValue)
        {
            totalValueSold += houseValue;
            totalCommissionEarned += houseValue * CommissionRate / 100.0;
        }//End method
    }
}
