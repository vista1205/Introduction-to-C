using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
            Console.WriteLine("Необходимо ввести максимальную и минимальную температуру, для расчёта средней температуры");
            Console.Write("Введите максимальную температуру: ");
            float MaxTemp = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите минимальную темепературу: ");
            float MinTemp = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Средняя температура равна: {(MaxTemp + MinTemp)/2}");
            #endregion
        }
    }
}
