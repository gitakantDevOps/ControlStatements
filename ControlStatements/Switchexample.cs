using System;
namespace ControlStatements
{
    internal class Switchexample
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number to check grade:");
            double marks = Convert.ToDouble(Console.ReadLine());
            switch(marks)
            {
                    case > 100:Console.WriteLine("The number is wrong,it should be less than 100");
                    break;
                    case >=75: Console.WriteLine("FirstClassWithDistinction");
                    break;
                    case >=60: Console.WriteLine("FirstClass");
                    break;
                    case >=35: Console.WriteLine("Pass");
                    break;
                    case >=0: Console.WriteLine("Fail");
                    break;
                    default: Console.WriteLine("The number is wrong, please verify");
                    break;
            }
        }
    }
}
