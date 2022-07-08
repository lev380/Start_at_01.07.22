using System;

namespace _08._07._22_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи число");

            string str = Console.ReadLine();

            int a; 
                
            bool result= int.TryParse(str, out a);

            
            if (result)
            {
                Console.WriteLine("Операция успешна, значение =" + a);
            }
            else
            {
                Console.WriteLine("Не удалось конвертировать!");
            }
        }
    }
}

/*  Console.WriteLine("Введи число");

            string str = Console.ReadLine();

            try
            {
                int a = int.Parse(str);

                Console.WriteLine("Успешно");
            }
            catch(Exception)
            {

                Console.WriteLine("Ошибка конвертации");
            
            }
            */