using System;

namespace Les4   //Нахождение массы тела и определение нормы с предложением набрать или похудеть
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваш рост в метрах:");
            var rost1 = Console.ReadLine();

            double a = Convert.ToDouble(rost1);

            Console.Write("Введите ваш вес:");
            var ves2 = Console.ReadLine();

            double b = Convert.ToDouble(ves2);

            double imt = b / (a * a);
            double x = b - (24.99 * a * a);
            double y = (18.50 * a * a) - b;
           // Console.WriteLine(x);
           // Console.WriteLine(y);
            Console.WriteLine(" Индекс массы вашего тела:" + "{0:F2}", imt);
            if (imt > 18.50)
                if (imt < 24.99)
                    Console.WriteLine("Индекс вашего тела в норме");
                else
                    Console.WriteLine("Индекс вашего тела превышен, Вам нужно похудеть на (кг):" + "{0:F2}", x);
            else
                Console.WriteLine("Индекс вашего тела недостаточен, Вам нужно набрать (кг):"+ "{0:F2}", y);

        }
    }
}
