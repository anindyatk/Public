using System;

namespace BasicAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool validInput = false;
            Console.Write("Please input n (Range 1-100): ");
            string inputtedValue = Console.ReadLine();

            if (int.TryParse(inputtedValue, out n))
            {
                validInput = true;
            }

            if (validInput && n > 0 && n <= 100)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("#".PadLeft(n - i));
                    Console.WriteLine("".PadRight(i, '#'));
                }
                Console.WriteLine("Done!");
            }
            else
            {
                Console.WriteLine("Wrong input!\nInputted value should be integer\nRange 1-100\nPlease press anykey to exit...");
                Console.ReadKey();                  
            }

        }
    }
}
