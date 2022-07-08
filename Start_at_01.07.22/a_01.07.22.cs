using System;

namespace Start_at_01._07._22
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
 
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


/*string name=Console.ReadLine();

           Console.WriteLine("Hello " + name + " !!!!");
           */

/*  Console.WriteLine("Input first value");

  int value = int.Parse(Console.ReadLine());

  Console.WriteLine("Input first value");

  int value2 = int.Parse(Console.ReadLine());

  Console.WriteLine("Сумма чисел равна =  " + value+value2);
*/

/* string f = "5,4"; 

 double a = Convert.ToDouble(f);

 Console.ReadLine();
*/