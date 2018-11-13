using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class GirlScout : SalesPerson, ISellable //Link child class to abstract class
    {
        int boxesOfCookiesSold = 0;
        public int BoxesOfCookiesSold 
        {
            get
            {
                return boxesOfCookiesSold;
            }
            set
            {
                boxesOfCookiesSold = value;
            }
        }
        public GirlScout(string firstName, string lastName) : base(firstName, lastName)
        {
        }
        public void SalesSpeech()
        {
            Console.WriteLine("My name is {0} and I sell boxes of Girl Scout cookies", FullName());
        }
        public void MakeSale(int boxesSold)
        {
            boxesOfCookiesSold += boxesSold;
        }
    }
}
