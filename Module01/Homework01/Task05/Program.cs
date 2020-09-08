using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            do
            {
                Console.WriteLine("Введите длину первого катета: ");
            } while (!double.TryParse(Console.ReadLine(), out a));
            do
            {
                Console.WriteLine("Введите длину второго катета: ");
            } while (!double.TryParse(Console.ReadLine(), out b));
            c = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"Длина гипотенузы равна {c}");
            Console.ReadKey();
        }
    }
}
