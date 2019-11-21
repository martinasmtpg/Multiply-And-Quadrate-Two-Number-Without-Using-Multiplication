using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_NonVoid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Multiply using Non Void Method");
            Console.WriteLine("===============================");
            Console.Write("Insert First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The multiply of the two number is " + multiply(a, b));
            Console.Read();
        }
        public static int multiply(int a, int b)
        {
            int result = 0;
            for (int i = 0; i < b; i++)
            {
                result += a;
            }
            return result;
        }
    }
}
