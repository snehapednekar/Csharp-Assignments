﻿using System;

namespace Assignment1
{
    internal class AvrgNumber
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter any five numbers: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr);
           // reverse array
            Array.Reverse(arr);
            Console.WriteLine("Greater number: " + arr[0]);
        }

    }
}
