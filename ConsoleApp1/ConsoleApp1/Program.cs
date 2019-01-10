using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your FIO: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);

            Console.Write("Enter 2 nums: ");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", firstNum + secondNum);
        }
    }
}
