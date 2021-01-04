using System;

namespace ConsoleApp4
{
    class Program
    {
        string person { set; get; }
        static void Main(string[] args)
        {
            int x = 1;
            Program A = new Program();
            A.person = "Alisa";//set bp
            Console.WriteLine("Hello World!");
        }
    }
}
