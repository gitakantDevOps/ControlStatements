using System;

namespace ControlStatements
{
    internal class Ifelseif
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter an integer input number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num > 15)
            {
                Console.WriteLine("{0} is grater than 15", num);
            }
            else if(num<15)
            {
                Console.WriteLine("{0} is less than 15", num);
            }
            else
            {
                Console.WriteLine("{0} is equal to 15", num);
            }
        }
    }
}
