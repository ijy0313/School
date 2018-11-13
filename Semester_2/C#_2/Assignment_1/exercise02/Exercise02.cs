using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write an app which contains the following function which makes use of variable number of arguments by use of params keyword:
private static int Addition(params int[] numbers) which returns the sum of three different numbers, four different numbers 
and five different numbers.So you need to call this method in the Main() according to above requirements.*/

namespace exercise02
{
    class Exercise02
    {
        static void Main(string[] args)
        {
            int a, b, c,d,e;

            //Part 1
            Console.WriteLine("Enter any three integers seperated by commas (e.g. 23, 55, 55): ");

            string str = Console.ReadLine(); //instruct user to input three
            string[] integers = str.Split(','); //seperate by using commas

            a = Convert.ToInt32(integers[0]);
            b = Convert.ToInt32(integers[1]); 
            c = Convert.ToInt32(integers[2]); //convert string input to int

            Console.WriteLine("The sum of three numbers is: {0}", Addition(a,b,c));

            //Part 2
            Console.WriteLine("\nEnter any four integers seperated by commas (e.g. 23, 55, 55, 11): ");

            str = Console.ReadLine();
            integers = str.Split(',');

            a = Convert.ToInt32(integers[0]);
            b = Convert.ToInt32(integers[1]);
            c = Convert.ToInt32(integers[2]);
            d = Convert.ToInt32(integers[3]);

            Console.WriteLine("The sum of four numbers is: {0}", Addition(a, b, c, d));

            //Part 3
            Console.WriteLine("\nEnter any five integers seperated by commas (e.g. 23, 55, 55, 11, 90): ");

            str = Console.ReadLine();
            integers = str.Split(',');

            a = Convert.ToInt32(integers[0]);
            b = Convert.ToInt32(integers[1]);
            c = Convert.ToInt32(integers[2]);
            d = Convert.ToInt32(integers[3]);
            e = Convert.ToInt32(integers[4]);

            Console.WriteLine("The sum of five numbers is: {0}", Addition(a, b, c, d, e));

        }
        private static int Addition(params int[] numbers)
        {
            int add = 0;
            foreach (int number in numbers)
            {
                add += number;
            }
            return add;
        }
    }
}
