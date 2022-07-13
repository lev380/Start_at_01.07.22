using System;

namespace Calc_Sw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calc_Sw");

            Console.WriteLine("Введите первое число");

            double firstvalue, secondvalue, result;

            double.TryParse(Console.ReadLine(),out firstvalue);

            Console.WriteLine("Действие");

            string action = Console.ReadLine();
         
            Console.WriteLine("Введите второе число");

            double.TryParse(Console.ReadLine(), out secondvalue);

            switch (action)
            {
                case "+":
                    result = firstvalue + secondvalue;
                    Console.WriteLine("Сумма чисел равна= "+result);
                    break;
                case "-":
                    result = firstvalue - secondvalue;
                    Console.WriteLine("Разность чисел равна= " + result);
                    break;
                case "*":
                    result = firstvalue * secondvalue;
                    Console.WriteLine("Результат умножения чисел равен= " + result);
                    break;
                case "/":
                    result = firstvalue / secondvalue;
                    Console.WriteLine("Результат деления чисел равен= " + result);
                    break;

                default:
                    Console.WriteLine("Вы ввели неизвестное действие");
                        break;
                    
            }

        }
    }
}
