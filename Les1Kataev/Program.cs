using System;

namespace Les1Kataev   // Задача минимальное из трёх чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число а:");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите число b:");

            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите число c:");

            int c = int.Parse(Console.ReadLine());

            if (a < b)
                if (a < c)

                Console.WriteLine("Наименьшее число  a=" + a);

               else
                
               Console.WriteLine("Наименьшее число c=" + c);
                
            else if (b < c)
                
                Console.WriteLine("Наименьшее число b=" + b);
                else
                Console.WriteLine("Наименьшее число c=" + c);
        }
    }
}
