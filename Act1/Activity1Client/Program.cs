using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome To Web Service Demo\n");
            Console.WriteLine("Select the method you need to invoke\n");
            Console.WriteLine("1. Sum of digits\n2. Vowel count\n3. Exit\n");
            Console.WriteLine("Enter your option: ");

            string option = Console.ReadLine();
            Activity1ServiceReference.Service1Client proxy = new Activity1ServiceReference.Service1Client();

            if (option.Equals("1"))
            {
                Console.WriteLine("Enter an integer: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sum of digits = " + proxy.sumOfDigits(num));
            }
            else if (option.Equals("2"))
            {
                Console.WriteLine("Enter a string: ");
                string str = Console.ReadLine();
                Console.WriteLine("Number of Vowels = " + proxy.numVowels(str));
            }
            else if (option.Equals("3"))
                Environment.Exit(0);
            else
                Console.WriteLine("Invalid Input.");
        }
    }
}
