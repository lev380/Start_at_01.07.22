using System;

namespace Calc_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calc_If_Else");

            Console.WriteLine("Введите первое число");

            double firstvalue, secondvalue, result;

            double.TryParse(Console.ReadLine(), out firstvalue);

            if (firstvalue == 0)
            {
                Console.WriteLine("Вы ввели неверное значение!");
            }

            Console.WriteLine("Действие");

            string action = Console.ReadLine();

            Console.WriteLine("Введите второе число");

            double.TryParse(Console.ReadLine(), out secondvalue);

            if (secondvalue == 0)
            {
                Console.WriteLine("Вы ввели неверное значение!");
            }

            if (firstvalue==0)
            {
                Console.WriteLine("Вы ввели неверное значение!");
            }

            if (action=="+")
            {
                result = firstvalue + secondvalue;
                Console.WriteLine("Сумма чисел равна= " + result);
            }
            else
            {
                Console.WriteLine("Вы ввели неизвестное действие");
            }
            if (action == "-")
            {
                result = firstvalue - secondvalue;
                Console.WriteLine("Разность чисел равна= " + result);
            }
            else
            {
                Console.WriteLine("Вы ввели неизвестное действие");
            }
            if (action == "*")
            {
                result = firstvalue * secondvalue;
                Console.WriteLine("Результат умножения чисел равен= " + result);
            }
            else
            {
                Console.WriteLine("Вы ввели неизвестное действие");
            }
            if (action == "/")
            {
                result = firstvalue / secondvalue;
                Console.WriteLine("Результат деления чисел равен= " + result);
            }
            else
            {
                Console.WriteLine("Вы ввели неизвестное действие");
            }


        }
    }
}
