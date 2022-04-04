using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            int.TryParse(inputString, out int number);

            string strBinary = Convert.ToString(number, 2);

            Console.WriteLine($"To Binary : {strBinary}");

            Console.ReadKey();
        }
    }
}
