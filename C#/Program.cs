using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello ,{name}! Welcome to firstApp");

            Console.WriteLine("Please enter your age:");
            string input = Console.ReadLine();

            int age = int.Parse(input);// kconverting age into int because readline by default returns a string

            if (age >= 18)
            {
                Console.WriteLine("Youa are adult");
            }
            else
            {
                Console.WriteLine("You are a child");
            }
            Console.WriteLine("Press Enter to exit..");
            Console.ReadKey();

        }
    }
}
