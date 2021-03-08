using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson4
{
    class Program
    {
        #region Функция для первого задания
        static void GetFullName(string firstName, string lastName, string patronymic)
        {
            Console.WriteLine($"{firstName} {lastName} {patronymic}");
        }
        #endregion

        #region Функция для второго задания
        static int SumLine(string line)
        {
            bool flag = true;
            int sum = 0;
            char[] correct = line.ToCharArray();
            for(int i = 0; i < correct.Length; i++)
            {
                if (char.IsLetter(correct[i]))
                    flag = false;
            } 
            if (flag == false)
                return 0;
            else
            {
                string[] arr = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += Convert.ToInt32(arr[i]);
                }
                return sum;
            }

        }
        #endregion

        #region Функция для третьего задания
        public enum Year
        {
            Winter = 1,
            Spring,
            Summer,
            Autumn
        }
        public enum Month
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }
        static void TimeYear(int monther)
        {           
            switch (monther)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine($"{(Month)monther} - это {RenameTimeYear((Year)1)}");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine($"{(Month)monther} - это {RenameTimeYear((Year)2)}");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine($"{(Month)monther} - это {RenameTimeYear((Year)3)}");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine($"{(Month)monther} - это {RenameTimeYear((Year)4)}");
                    break;
                default:
                    Console.WriteLine("Вы ввели некорректное значение!");
                    break;
            }
        }
        static string RenameTimeYear(Year ye)
        {
            switch (ye)
            {
                case Year.Winter:
                    return "Зима";
                case (Year)2:
                    return "Весна";
                case (Year)3:
                    return "Лето";
                case (Year)4:
                    return "Осень";
                default:
                    return null;
            }
        }
        #endregion

        #region Функция для четвёртого задания
        static int Fib(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }
        #endregion
        static void Main(string[] args)
        {
             #region Задание №1
             Console.Write("Введите количество вводимых ФИО: ");
             int n = Convert.ToInt32(Console.ReadLine());
             int chek = 0;
             do
             {
                 Console.Write("Введите Фамилию: ");
                 string FirstName = Console.ReadLine();
                 Console.Write("Введите Имя: ");
                 string LastName = Console.ReadLine();
                 Console.Write("Введите Отчество: ");
                 string Patronymic = Console.ReadLine();
                 GetFullName(FirstName, LastName, Patronymic);
                 chek++;
             } while (chek < n);
            #endregion

            #region Задание №2
            Console.WriteLine("Для выхода из программы введите 11");
            bool ex1 = true;
            do
            {
                Console.WriteLine("Введите строку через пробел для расчёта суммы цифр, которые могут в ней находиться");
                string s = Console.ReadLine();
                if (s == "11")
                    ex1 = false;
                else
                {
                    int sum;
                    sum = SumLine(s);
                    if (sum == 0)
                        Console.WriteLine("Сумма элементов равна 0 или введены некорректные символы!");
                    else
                        Console.WriteLine($"Сумма всех элементов равна: {sum}");
                }
            } while (ex1);
            #endregion

            #region Задание №3
            Console.WriteLine("Для выхода из программы введите любой не числовой символ");
            bool ex2 = true;
            do
            {
                Console.Write("Введите номер месяца: ");
                string ch = Console.ReadLine();
                if (char.IsNumber(Convert.ToChar(ch)))
                {
                    int b = Convert.ToInt32(ch);
                    TimeYear(b);
                }
                else
                    ex2 = false;
            } while (ex2);
            #endregion

            #region 4* Дополнительное задание
            Console.WriteLine("Для выхода из программы введите любой не числовой символ");
            bool ex3 = true;
            do
            {
                Console.Write("Введите число для рассчёта Фиббоначи: ");
                string ch =Console.ReadLine();
                if (char.IsNumber(Convert.ToChar(ch)))
                {
                    int f = Convert.ToInt32(ch);
                    Console.WriteLine($"Число Фиббоначи равно: {Fib(f)}");
                }
                else
                    ex3 = false;
            } while (ex3);            
            Console.ReadKey();
            #endregion
        }
    }
}
