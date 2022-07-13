using System;

namespace Even_Count
{
    class Even_Count
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Считаем четные числа");

            int Limit, Evencont=0, Notevencount=0,count=0;

            int.TryParse(Console.ReadLine(), out Limit);

            while (count<Limit)
            {
                count++;
                if (count % 2 == 0)
                {
                    Evencont++;
                }
                else
                {
                    Notevencount++;
                }
                Console.WriteLine(count);
            }
            Console.WriteLine("Количество чётных чисел= " + Evencont);

            Console.WriteLine("Количество Нечётных чисел= " + Notevencount);

        }
    }
}
