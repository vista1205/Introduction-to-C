using System;
using System.Diagnostics;
using System.Threading;

namespace Lesson6
{
    class Program
    {
        public static int a;
        public static string b="";
        public static bool flag1 = true;
        static void Main(string[] args)
        {            
            try
            {
                bool flag = true;
                while(flag)
                {
                    foreach (Process process in Process.GetProcesses())
                        Console.WriteLine($"ID: {process.Id}\tName: {process.ProcessName}");
                    string answer = Console.ReadLine();
                    int number = 0;
                    char[] newchar = answer.ToCharArray();
                    for(int i = 0; i < newchar.Length; i++)
                    {
                        if (!char.IsDigit(newchar[i]))
                        {
                            number = 1;
                            break;
                        }
                    }
                    if (number == 1)
                    {
                        if (answer.Contains("quit"))
                        {
                            flag = false;
                            break;
                        }
                        else
                        {
                            flag1 = false;
                            b = answer;
                            foreach(Process proc in Process.GetProcesses())
                            {
                                if (proc.ProcessName == b)
                                    a = proc.Id;
                            }
                            Process.GetProcessById(a).Kill();
                            Thread.Sleep(2000);
                            
                        }
                    }
                    else
                    {
                        a = Convert.ToInt32(answer);
                        Process.GetProcessById(a).Kill();
                        Thread.Sleep(2000);
                    }
                    
                }                
                
            }
            catch(Exception e)
            {
                if (flag1)
                    Console.WriteLine($"\n{Process.GetProcessById(a)}:\t{e.Message}\n");
                else
                    Console.WriteLine($"\n{Process.GetProcessesByName(b)}:\t{e.Message}\n");
            }
            finally
            {
                foreach (Process process in Process.GetProcesses())
                    Console.WriteLine($"ID: {process.Id}\tName: {process.ProcessName}");
            }
        }
    }
}
