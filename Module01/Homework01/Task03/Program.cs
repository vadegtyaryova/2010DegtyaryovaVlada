using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------ASCIIDecoder---------
            int num;
            do
            {
                do
                {
                    Console.WriteLine("Please, enter the number: ");
                } while (!int.TryParse(Console.ReadLine(), out num));
            } while (num < 32 && num > 127);
            Console.WriteLine((char)num);
            Console.ReadKey();
        }
    }
}
