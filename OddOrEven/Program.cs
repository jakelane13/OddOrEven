using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            isOdd(5);
        }

        public static bool isOdd(int num)
        {
            Console.WriteLine("Enter number");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
                return false;
            }
            else
            {
                Console.WriteLine("Odd");
                return true;
            }
        }
    }
}
