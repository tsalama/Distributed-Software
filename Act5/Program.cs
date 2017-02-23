using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Act5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter String: ");
                // read a string for analysis
                string str = Console.ReadLine();

                // create threads
                ThreadClass tc = new ThreadClass();
                Thread t1 = new Thread(() => tc.digitCount(str));
                Thread t2 = new Thread(() => tc.upperCount(str));
                Thread t3 = new Thread(() => tc.isPalindrome(str));
                // start each thread
                t1.Start();
                t2.Start();
                t3.Start();
                // wait until all the threads are done
                t1.Join(); 
                t2.Join(); 
                t3.Join(); 
                // Display the string analysis results
                Console.WriteLine($"\n# Digits: {tc.getDigitCount()} \n# Uppers: {tc.getUpperCount()} \nisPalindrome: {tc.isPalin()}");

                Console.ReadKey();
            }
        }
    }
}
