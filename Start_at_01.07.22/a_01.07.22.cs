using System;
// This namespace to use some commands
/*
 * зеленый текст игнорируется программой
*/
// Testing program, trashbox))
 

namespace Start_at_01._07._22
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string name=Console.ReadLine();

            Console.WriteLine("Hello " + name + " !!!!");
            */

            /*  Console.WriteLine("Input first value");

              int value = int.Parse(Console.ReadLine());

              Console.WriteLine("Input first value");

              int value2 = int.Parse(Console.ReadLine());

              Console.WriteLine("Сумма чисел равна =  " + value+value2);
            */

            Console.WriteLine("Ввведите число");

            int value; 
            int.TryParse(Console.ReadLine(),out value );

            int test = value % 2;
            if (value == 0)
            {
                Console.WriteLine("Введите целое число");
                
            }   
            if (test == 1)
             Console.WriteLine("Число не чётное");
            
            else
             Console.WriteLine("Число  чётное");
            

        }
    }
}
