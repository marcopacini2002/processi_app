using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;


namespace processi_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercitazione sulla gestione");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe",@"file\Helloworld.txt");

            Process.Start("Chrome.exe", @"https://www.youtube.com/watch?v=-EN7-zPT4cE");
            var app = new Process();
            app.StartInfo.FileName = @"Notepad.exe";
            app.StartInfo.Arguments= @"\\dc01srv\_Condivisa\INF\4 B\Pacini\Tepsit\processi_app\processi_app\Helloworld.txt";
            app.Start();
            app.PriorityClass = ProcessPriorityClass.RealTime;
            app.WaitForExit();

            var process = Process.GetProcesses();
            foreach(var p in process)
            {
                if (p.ProcessName == "Notepad") p.Kill();
            }
            Console.WriteLine("Programma terminato");
            Console.ReadLine();
        }
    }
}
