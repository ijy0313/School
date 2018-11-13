using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write an app which contains the following functions which make use of ref and out parameters:
a)	private static void Swap(ref int, ref int) which exchanges the contents of two variables
b)	private static void Initialize(out int, out int) which initializes two numbers and then 
you need to find their average in Main() and print the result.*/

namespace exercise03
{
    class Exercise03
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 3;
            b = 7;

            Console.WriteLine("Before swap - Number one = {0}, Number two = {1}", a, b);
            Swap(ref a, ref b);
            Console.WriteLine("After swap - Number one = {0}, Number two = {1}", a, b);

            Console.WriteLine("\nInput two integers, seperated by commas, to calculate their average (e.g. 11, 22): ");
            Initialize(out int c, out int d);
            int average = (c + d) / 2;
            Console.WriteLine("The average of the two numbers is: {0}", average);

        }
        private static void Swap(ref int num1, ref int num2)
        {
            int x = num1;
            num1 = num2;
            num2 = x;
        }
        private static void Initialize(out int num1, out int num2)
        {
            string str = Console.ReadLine(); 
            string[] integers = str.Split(',');
            num1 = Convert.ToInt32(integers[0]);
            num2 = Convert.ToInt32(integers[1]);
            
        }
    }
}
