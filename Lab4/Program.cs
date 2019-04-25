using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuing = true;
            double input;

            do
            {
                Console.Write("Enter an integer: ");
                input = double.Parse(Console.ReadLine());

                Console.WriteLine("Number   Squared    Cubed");

                while (input >= 1)
                {
                    Console.WriteLine("{0}         {1}         {2}", input, Math.Pow(input, 2), Math.Pow(input, 3));
                    input--;
                }

                Console.WriteLine("Enter another? (Y/N)");

                if (Console.ReadLine().ToLower() == "n")
                {
                    continuing = false;
                }

            }
            while (continuing);
        }
    }
}
