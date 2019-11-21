using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrate_NonVoid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Quadrate using Non Void Method");
            Console.WriteLine("==================================");
            Console.Write("Insert First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result of this quadrate is " + quadrate(a, b));
            Console.Read();
        }
        public static int quadrate(int a, int b)
        {
            int result = 0;
            int temp = 0;
            temp = a;
            if (b == 0)
            {
                result = 1;
            }
            else if (b == 1)
            {
                result = a;
            }
            else
            {
                for (int i = 1; i < b; i++)
                {
                    result = 0;
                    for (int j = 0; j < a; j++)
                    {
                        result += temp;
                    }
                    temp = result;
                }
            }
            return result;
        }
    }
}
