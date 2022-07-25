using System;

namespace Hom_Work_Triangle
{
    class Hom_Work_Triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Рисуем Треугольники");


            Console.Write("Задайте размер треугольника = ");
            int size = int.Parse(Console.ReadLine());
            
            // ТРеугольник № 1
            
            for (int s = 0; s <= size; s++)
            {
                for (int v = 0; v < s; v++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Треугольник № 2

            //          0     5    0    5  -1 
            for (int s = 0,w=size; s <= w; w--)
            {
                                
                for (int q = 0; q < w; q++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(  );
                
            }


            //Треугольник №3

            //         0     0    5    +1
            for (int s = 0; s < size; s++)
            {
                for (int v = size-1; v > s; v--)
                {
                    Console.Write(" ");
                }
                for (int v = 0; v <= s; v++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }

            

        }
    }
}   

