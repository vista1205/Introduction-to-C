using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Написать программу, выводящую элементы двухмерного массива по диагонали.
            Random rnd = new Random();
            Console.WriteLine("Введите размерность массива MxN");
            Console.Write("Введите число M: ");
            int StrokaM = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число N: ");
            int StolbecN = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[StrokaM, StolbecN];
            for(int i = 0; i < arr.GetLength(dimension:0); i++)
            {
                for(int j = 0; j < arr.GetLength(dimension:1); j++)
                {
                    arr[i, j] = rnd.Next(0, 2);
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{arr[i, j]} ");
                        Console.ResetColor();
                    }
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
            for(int i = 0; i < arr.GetLength(dimension: 0); i++)
            {
                for (int j = 0; j < arr.GetLength(dimension: 1); j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{arr[i, j]} ");
                        Console.ResetColor();
                    }                        
                }
            }
            Console.ReadKey();
            #endregion

            #region 2. Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/e-mail.
            Console.WriteLine("Необходимо ввести Имя и телефон/e-mail");
            string[,] Contacts = new string[5, 2];
            for (int i=0; i < Contacts.GetLength(dimension: 0); i++)
            {
                for(int j = 0; j < Contacts.GetLength(dimension: 1); j++)
                {
                    if (j == 0)
                    {
                        Console.Write("Введите имя контакта: ");
                        Contacts[i, j] = Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("Введите телефон/e-mail контакта: ");
                        Contacts[i, j] = Console.ReadLine();
                    }
                }
            }
            Console.WriteLine("\nИмя\tТелефон/e-mail");
            for(int i = 0; i < Contacts.GetLength(dimension: 0); i++)
            {
                for (int j = 0; j < Contacts.GetLength(dimension: 1); j++)
                {
                    if (j == 0)
                        Console.Write($"{Contacts[i, j]}\t");
                    else
                        Console.WriteLine($"{Contacts[i, j]}");
                }
            }
            Console.ReadKey();
            #endregion
        }
    }
}
