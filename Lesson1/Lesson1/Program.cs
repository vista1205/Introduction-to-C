using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Написать программу, выводящую в консоль текст: «Привет, %имя пользователя%, сегодня %дата%». Имя пользователя сохранить из консоли в промежуточную переменную. Поставить точку останова и посмотреть значение этой переменной в режиме отладки. Запустить исполняемый файл через системный терминал.
            Console.Write("Введите ваше имя: ");
            string UserName = Console.ReadLine();
            Console.WriteLine($"Здравствуй, {UserName}! Сегодня {DateTime.Now}");
            Console.ReadKey();
            #endregion
        }
    }
}
