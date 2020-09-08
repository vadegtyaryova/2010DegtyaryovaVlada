using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            string[] words = new string[n];
            Console.WriteLine($"Введите {n} слов(а): ");
            for (int i = 0; i < n; i++)
            {
                words[i] = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"-{words[i]}-");
            }
        }
    }
}
