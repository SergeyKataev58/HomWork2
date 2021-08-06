using System;

namespace Les2Kataev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            while (num > 0)
            {
                i++;
                num /= 10;
            }
                Console.WriteLine("Количество цифр =" + i);
                return;
            
        }
    }
}
