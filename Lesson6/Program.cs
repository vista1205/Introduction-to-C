using System;
using System.Diagnostics;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Process process in Process.GetProcesses())
                Console.WriteLine($"ID: {process.Id}\tName: {process.ProcessName}");
            int a = Convert.ToInt32(Console.ReadLine());
            Process.GetProcessById(a).Kill();
            Console.ReadKey();
        }
    }
}
