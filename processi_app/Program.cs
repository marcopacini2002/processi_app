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
        }
    }
}
