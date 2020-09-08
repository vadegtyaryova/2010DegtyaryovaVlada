using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            double U, R, I, P;
            do
            {
                Console.WriteLine("Напряжение U = ");
            } while (!double.TryParse(Console.ReadLine(), out U));
            do
            {
                Console.WriteLine("Сопротивление R = ");
            } while (!double.TryParse(Console.ReadLine(), out R));
            I = U / R;
            Console.WriteLine($"Сила тока I = U / R = {I}");
            P = U * U / R;
            Console.WriteLine($"Мощность P = U * U / R = {P}");
            Console.ReadKey();
        }
    }
}
