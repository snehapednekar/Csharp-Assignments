using System;

namespace Assignment1
{
    internal class Calc
    {
        public static void Main(string[] args)
        {
            int result = 0;
            Console.WriteLine("Enter 1st Number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("1 for Addition: ");
            Console.WriteLine("2 for Subtraction: ");
            Console.WriteLine("3 for Multiplication: ");
            Console.WriteLine("4 for Division: ");
            Console.WriteLine("Enter key to perform operation: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    result = number1 + number2;
                    break;
                case 2:
                    result = number1 - number2;
                    break;
                case 3:
                    result = number1 * number2;
                    break;
                case 4:
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }
            Console.WriteLine("Result: " + result);
        }

    }
}
