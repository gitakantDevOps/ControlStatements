using System;

namespace ControlStatements
{
    internal class ForExample
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number for displaying table of it:");
            int n = Convert.ToInt32(Console.ReadLine());
            int p = 1;
            int result;
            Console.WriteLine("Please find Table of {0} as below:",n);
            for (p=1; p<=10; p++)
            {
                result = n * p;
                Console.WriteLine(result);
            }
            
        }
    }
}