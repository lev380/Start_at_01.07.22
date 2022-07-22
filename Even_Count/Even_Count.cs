using System;

namespace Even_Count
{
    class Even_Count
    {
        static void Main(string[] args)
        {
            uint Evencont=0, Notevencount=0;
            int Limit, count, EvenSum = 0, NotEvenSum = 0;

            Console.WriteLine("Начало диапозона");           
            int.TryParse(Console.ReadLine(), out count);
          
            Console.WriteLine("Конец диапозона");
            int.TryParse(Console.ReadLine(), out Limit);

            while (count<=Limit)
            {
               
                if (count % 2 == 0)

                {
                    Evencont++;
                    EvenSum += count;
                }
                else
                {
                    Notevencount++;
                    NotEvenSum = NotEvenSum + count;
                }
               // Console.WriteLine(count);

                count++;
            }
            Console.WriteLine("Количество чётных чисел= " + Evencont);
            Console.WriteLine("Количество Нечётных чисел= " + Notevencount);

            Console.WriteLine("Сумма чётных чисел= " + EvenSum);
            Console.WriteLine("Сумма нечётных чисел= " + NotEvenSum);
        }
    }
}
