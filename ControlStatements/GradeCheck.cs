using System;
namespace ControlStatements
{
    internal class GradeCheck
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number to check the Grade obtained for student:");
            double num = Convert.ToDouble(Console.ReadLine());
            if(num >= 0 && num <35)
            {
                Console.WriteLine("Fail");
            }
            else if(num >= 35 && num < 60)
            {
                Console.WriteLine("Pass");
            }
            else if (num>=60 && num<75)
            {
                Console.WriteLine("First Class");
            }
            else if (num >= 75 && num < 100)
            {
                Console.WriteLine("First class with Distinction");
            }
            else
            {
                Console.WriteLine("Wrong number entered, please verify");
            }
        }
    }
}
