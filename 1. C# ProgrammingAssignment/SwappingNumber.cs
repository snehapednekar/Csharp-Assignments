using System;

namespace Assignment1
{
    internal class SwappingNumber
    {
        public static void swapNumber(int number1, int number2)
        {
            int temp;
            Console.WriteLine("Before Swaping: " + number1 + " " + number2);
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("After Swaping: " + number1 + " " + number2);
        }
        public static void Main(string[] args)
        {
            //swapNumber(8,30);
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            swapNumber(number1, number2);
        }

    }
}
