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

            int inputNumber = int.Parse(inputString);

            string strBin = Convert.ToString(inputNumber, 2);

            Console.WriteLine($"To Binary : {strBin}");

            Console.ReadKey();
        }
    }
}
