using System;
using System.Diagnostics;
using System.IO;

namespace Lesson5
{
    class Program
    {
        #region Функция для первого задания
        static void WriteText (string text)
        {
            string filename = "task1.txt";
            File.WriteAllText(filename, text);
        }
        #endregion

        #region Функция для второго задания
        static void StartProgramTime(string time)
        {
            string filename = "startup.txt";
            File.WriteAllText(filename, time);
        }
        #endregion

        #region Функция для третьего задания
        static void WriteByte (string byteLine)
        {
            string filename = "task3.bin";
            string[] arr = byteLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            byte[] CorrectArr = new byte[arr.Length];
            for(int i = 0; i < CorrectArr.Length; i++)
            {
                CorrectArr[i] = Convert.ToByte(arr[i]);
            }
            File.WriteAllBytes(filename, CorrectArr);
        }
        #endregion
        static void Main(string[] args)
        {
            #region 1. Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
            Console.WriteLine("Введите текст для записи в файл");
            string s1 = Console.ReadLine();
            WriteText(s1);
            #endregion

            #region 2. Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
            DateTime date = DateTime.Now;
            string time = Convert.ToString(date);
            StartProgramTime(time);
            #endregion

            #region 3. Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
            Console.WriteLine("Введите с клавиатуры произвольный набор чисел (0...255) через пробел");
            string s2 = Console.ReadLine();
            WriteByte(s2);
            #endregion

            Console.ReadKey();
        }
    }
}
