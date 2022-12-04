using System;
using System.Data;

namespace ControlStatements
{
    internal class IfelseStmt
    {
        public static void Main(string[] args)
        {
            int num = 9;
            if (num % 2 == 0)
            {
                Console.WriteLine("{0} is an even number", num);
            }
            else
            {
                Console.WriteLine("{0} is an odd number", num);
            }

        }
    }
}
