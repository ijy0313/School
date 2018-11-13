using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class SalesPersonDemo
    {
        static void Main(string[] args)
        {
                RealEstatePerson employee1 = new RealEstatePerson("Peter", "Yoon");
                employee1.SalesSpeech();
                employee1.MakeSale(200000);
                Console.WriteLine("Price of house sold = ${0:N0}", employee1.TotalValueSold);
                Console.WriteLine("Commission earned @ {0}% = ${1:N2}\n", RealEstatePerson.CommissionRate, employee1.TotalCommissionEarned);
                //End real estate person speech

                GirlScout scout1 = new GirlScout("Ashley", "Park");
                scout1.SalesSpeech();
                scout1.MakeSale(20);
                Console.WriteLine("Total number of boxes of cookies sold = {0:N0}", scout1.BoxesOfCookiesSold);
                //End girl scout speech
            }
        }
    }
