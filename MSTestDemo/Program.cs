using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Number();

            Console.WriteLine("Enter two integers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = number.CalculateSum(a,b);

            Console.WriteLine("Sum of the numbers is: " + sum);
            Console.ReadLine();
        }
    }

    public class Number
    {
        public int CalculateSum(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
