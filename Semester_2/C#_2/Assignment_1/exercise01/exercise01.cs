using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write an app which contains the following two overloaded functions:
 * a) private static int Maximum(int, int) which returns the largest of the two numbers
 * b) private static int Maximum (int, int, int) which returns the largest of the three numbers */

namespace exercise01
{
    class Exercise01
    {
        static void Main(string[] args)
        {
            int x, y, z; //declare values for output

            //Part 1
            Console.WriteLine("Enter two integers, seperated by commas (e.g. 23, 55): ");

            string str = Console.ReadLine(); //instruct user to input two integers
            string[] integers = str.Split(','); //seperate by using commas

            x = Convert.ToInt32(integers[0]); 
            y = Convert.ToInt32(integers[1]); //convert string input to int

            Console.WriteLine("The largest of the numbers is: {0}", Maximum(x, y)); //get larger value of the two inputs by calling on the Maximum method

            //Part 2
            Console.WriteLine("\nEnter three integers, seperated by commas (e.g. 23, 55, 44): ");

            str = Console.ReadLine();
            integers = str.Split(',');

            x = Convert.ToInt32(integers[0]);
            y = Convert.ToInt32(integers[1]);
            z = Convert.ToInt32(integers[2]);

            Console.WriteLine("The largest of the numbers is: {0}", Maximum(x, y, z));

        }

        private static int Maximum(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else return b;

        }
        private static int Maximum(int a, int b, int c)
        {
            return a > b ? a : (b < c ? c : b);
        }
    }
}
