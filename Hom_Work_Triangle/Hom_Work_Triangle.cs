using System;

namespace Hom_Work_Triangle
{
    class Hom_Work_Triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Рисуем Треугольники");

            uint size1, size2, size3;

            Console.Write("Задайте размер треугольника = ");
            uint size = uint.Parse(Console.ReadLine());
            size1 = size;
            
            for (int i=0; i<=size ; i++)
            {                
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            for (uint i = size; i >= 0; i--)
            {
                for (int j=0; j > i; j++)
                {
                    for (int b  = 0; b < j; b++)
                    {
                        Console.Write("#");
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
