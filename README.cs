# NumberTwenty
checks for sum of 20 or a variable equal to 20
using System;

namespace NumberTwenty
{
    class Program
    {
        static void Main(string[] args)
        {
            //21.Write a C# program to check the sum of the two given integers 
            //and return true if one of the integer is 20 or if their sum is 20
            bool condition = false;
            Console.WriteLine("first number: ");
            var a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("second number: ");
            var b = Int32.Parse(Console.ReadLine());
            if (a + b == 20 || a == 20 || b == 20)
                condition = true;
            Console.WriteLine(condition);
            
        }
    }
}
