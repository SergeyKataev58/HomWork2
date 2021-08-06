using System;

namespace Les3Kataev  //Задача сумма положительных четных числе введенных с клавиатуры
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num = 0;
            Console.WriteLine("Введите числа");
            do
            {
                num = int.Parse(Console.ReadLine());
                if (num > 0 && num % 2 == 0)
                    sum += num;

            } while (num != 0);

            Console.WriteLine("Сумма положительных четных чисел= " + sum);
        }
    }
}