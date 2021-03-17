using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Program
    {
        public static int a = 120;
        public static int b = 140;
        static void Main(string[] args)
        {
            for(int i = a; i <= b; i++)
            {
                int num = 0;
                for(int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        num++;
                }
                Console.WriteLine($"У числа {i} {num} делителей");
            }
            Console.ReadKey();
        }
    }
}
