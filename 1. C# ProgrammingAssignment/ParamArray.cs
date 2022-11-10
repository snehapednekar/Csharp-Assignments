using System;

namespace Assignment1
{
    internal class ParamArray
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the number: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
           // int[] arr = { 20,1,7,34,22,70,8,6,5,4 };
            int sum = sumOfArray(arr);
            Console.WriteLine("Sum of array: " + sum);
        }

        public static int sumOfArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
