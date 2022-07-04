using System;

namespace _08._07._22
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Первое число");

            string a = Console.ReadLine();

            Console.WriteLine("второе число");

            string b = Console.ReadLine();

            int a1, b1;

            a1 = Convert.ToInt32(a);

            b1 = Convert.ToInt32(b);

            Console.WriteLine(a1 + b1); ;
        }
    }
}
