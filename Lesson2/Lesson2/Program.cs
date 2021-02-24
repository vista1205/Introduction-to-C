using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {/*
            #region 1. Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
            Console.WriteLine("Необходимо ввести максимальную и минимальную температуру, для расчёта средней температуры");
            Console.Write("Введите максимальную температуру: ");
            float MaxTemp = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите минимальную темепературу: ");
            float MinTemp = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Средняя температура равна: {(MaxTemp + MinTemp)/2}");
            #endregion

            #region 2. Запросить у пользователя порядковый номер текущего месяца и вывести его название.
            string[] month = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            Console.Write("Введите номер месяца: ");
            int UserAnswer = Convert.ToInt32(Console.ReadLine());
            if (UserAnswer >= 1 && UserAnswer <= 12)
                Console.WriteLine(month[UserAnswer - 1]);
            else
                Console.WriteLine("Вы ввели некорректное число!");
            #endregion

            #region 3. Определить, является ли введённое пользователем число чётным
            Console.WriteLine("Программа для определения чётности чисел");
            Console.Write("Введите целое число: ");
            UserAnswer = Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(UserAnswer) % 2 == 0)
                Console.WriteLine($"Введённое число {UserAnswer} является чётным");
            else
                Console.WriteLine($"Введённое число {UserAnswer} не является чётным");
            #endregion
            */
            #region
            Console.WriteLine("{0,25}", "ООО Форсунка");
            Console.WriteLine("{0,35}", "Адрес 634059б Томская область,");
            Console.WriteLine("{0,36}", "город Томск, ул. Ивановского, 14");
            Console.WriteLine("{0,25}", "ИНН 7019014125");
            Console.WriteLine("{0,29}", $"{DateTime.Now}");
            Console.WriteLine("{0,30}", "Кассир: Иванов Николай");
            Console.WriteLine(new string('#', 37));
            #endregion
        }
    }
}
