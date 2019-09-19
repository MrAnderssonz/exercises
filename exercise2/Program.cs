using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in ett decimaltal: ");
            string input = Console.ReadLine();
            double userInput = Convert.ToDouble(input);
            int noDecimals = (int)userInput;
            Console.WriteLine("Ditt tal {0 } utan decimaler är: {1}", userInput, noDecimals);

        }
    }
}
