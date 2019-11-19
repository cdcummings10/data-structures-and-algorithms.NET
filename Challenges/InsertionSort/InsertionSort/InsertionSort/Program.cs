using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(',', InsertionSorter(new int[] { 20, 18, 12, 8, 5, -2})));
            Console.WriteLine(String.Join(',', InsertionSorter(new int[] { 5, 12, 7, 5, 5, 7 })));
            Console.WriteLine(String.Join(',', InsertionSorter(new int[] { 2, 3, 5, 7, 13, 11 })));
        }
        /// <summary>
        /// Sorts an array of integers from smallest to largest using the "insertion sort" algorithm.
        /// </summary>
        /// <param name="arr">Takes in an array of integers.</param>
        /// <returns>Returns the same array of integers as the parameter, but now sorted.</returns>
        public static int[] InsertionSorter(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];
                while(j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                    arr[j + 1] = temp;
                }
            }
            return arr;
        }
    }
}
