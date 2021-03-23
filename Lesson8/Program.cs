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
                Properties.Settings.Default.UserName = Console.ReadLine();
            }
            Console.Write("Для загрузки программы без изменений нажмите 1, если хотите поменять параметры, нажмите 2: ");
            int userAnswer = Convert.ToInt32(Console.ReadLine());            
            switch (userAnswer)
            {
                case 1:
                    string privet = Properties.Settings.Default.Greeting;
                    string userName = Properties.Settings.Default.UserName;
                    int userAge = Properties.Settings.Default.UserAge;
                    string UserAbout = Properties.Settings.Default.userAbout;
                    Console.WriteLine($"{privet} Меня зовут {userName}, мне {userAge} лет, я {UserAbout}");
                    break;
                case 2:
                    Console.Write("Введите Ваше имя: ");
                    Properties.Settings.Default.UserName = Console.ReadLine();
                    Console.Write("Введите Ваш возраст: ");
                    Properties.Settings.Default.UserAge = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Чeм вы занимаетесь: ");
                    Properties.Settings.Default.userAbout = Console.ReadLine();
                    Properties.Settings.Default.Save();
                    break;

            }            
            Console.ReadKey();
        }
    }
}
