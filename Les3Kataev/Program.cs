using System;

namespace Les3Kataev
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num = 0;

            do
            {
                num = int.Parse(Console.ReadLine());
                if (num > 0 && num % 2 == 0)
                    sum += num;

            } while (num != 0);

            Console.WriteLine("Sum: " + sum);
        }
    }
}