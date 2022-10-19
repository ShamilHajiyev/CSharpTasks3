using System;

namespace ArrayMax
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task: Ededlerden ibaret array verilib, bu ededlerin en boyuyunu tapmali.

            Console.WriteLine("How many number do you want to compare?");
            int numCount = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[numCount];
            int max = numbers[0];
            ArrayInput(ref numbers, numCount);
            for (int i = 0; i < numCount; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("\nLargest number: " + max);
        }
        public static void ArrayInput(ref int[] arr, int itemCount)
        {
            Console.WriteLine("\nEnter the numbers:");
            for (int i = 0; i < itemCount; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
