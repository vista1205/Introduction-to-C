using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
            Console.WriteLine("Необходимо ввести максимальную и минимальную температуру, для расчёта средней температуры");
            Console.Write("Введите максимальную температуру: ");
            float MaxTemp = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите минимальную темепературу: ");
            float MinTemp = Convert.ToSingle(Console.ReadLine());
            float AverageTemp = (MaxTemp + MinTemp)/2;
            Console.WriteLine($"Средняя температура равна: {AverageTemp}");
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

            #region 4.
            Console.WriteLine();
            Console.WriteLine(new string('#', 45));
            Console.WriteLine("{0,25}", "ООО Форсунка");
            Console.WriteLine("{0,35}", "Адрес 634059б Томская область,");
            Console.WriteLine("{0,36}", "город Томск, ул. Ивановского, 14");
            Console.WriteLine("{0,25}", "ИНН 7019014125");
            Console.WriteLine("{0,29}", $"{DateTime.Now}");
            Console.WriteLine("{0,30}", "Кассир: Иванов Николай");
            Console.WriteLine(new string('#', 45));
            Console.WriteLine("Наименование\tКоличество\tРУБ/ШТ\tСумма");
            Console.WriteLine("Молоко\t\t1\t\t45\t45");
            Console.WriteLine("Сметана\t\t1\t\t75\t75");
            Console.WriteLine("Свекла\t\t2\t\t5\t10");
            Console.WriteLine(new string('#', 45));
            Console.WriteLine("\t\tИТОГО:\t\t\t130\n");
            Console.WriteLine(new string('#', 45));
            Console.WriteLine("Наличными\t\t200\nСдача\t\t\t70");
            Console.WriteLine(new string('#', 45));
            Console.WriteLine("\t\tЧек 0924\n\tФискальный режим 82143979");
            #endregion

            //AverageTemp берётся из первого задания
            #region 5. Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима»
            Console.Write("\nВведите номер месяца: ");
            int UserMonth = Convert.ToInt32(Console.ReadLine());
            switch (UserMonth)
            {
                case 12:
                case 1:
                case 2:
                    {
                        if (AverageTemp > 0)
                            Console.WriteLine("Дождливая зима");
                        else
                            Console.WriteLine("Зима");
                        break;
                    }
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Лето");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Осень");
                    break;
                default:
                    Console.WriteLine("Некорректный ввод!");
                    break;
            }
            #endregion
        }
    }
}
