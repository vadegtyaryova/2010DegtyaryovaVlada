using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            string[] words = new string[n];
            Console.WriteLine($"Введите {n} слов(а): ");
            for(int i = 0; i < n; i++)
            {
                words[i] = Console.ReadLine();
            }
            Console.Write(words[0]);
            for( int i = 1; i < n; i++)
            {
                Console.Write($"!{words[i]}");
            }
        }
    }
}
