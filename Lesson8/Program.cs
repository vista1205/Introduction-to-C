using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.Write("Введите Ваше имя: ");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Console.Write("Введите Ваш возраст: ");
                Properties.Settings.Default.UserAge = Convert.ToInt32(Console.ReadLine());
                Console.Write("Чeм вы занимаетесь: ");
                Properties.Settings.Default.userAbout = Console.ReadLine();
                Properties.Settings.Default.Save();

            }
            string privet = Properties.Settings.Default.Greeting;
            string userName = Properties.Settings.Default.UserName;
            int userAge = Properties.Settings.Default.UserAge;
            string UserAbout = Properties.Settings.Default.userAbout;
            Console.WriteLine($"{privet}\n{userName}\n{userAge}\n{UserAbout}");
            Console.ReadKey();
        }
    }
}
