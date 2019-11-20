using System;

namespace SortMerge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(',', MergeSort(new int[] { 8, 4, 23, 42, 16, 15 })));
            Console.WriteLine(String.Join(',', MergeSort(new int[] { 5, 12, 7, 5, 5, 7 })));
            Console.WriteLine(String.Join(',', MergeSort(new int[] { 20, 18, 12, 8, 5, -2 })));
        }
        /// <summary>
        /// Takes in an array of integers and sorts it using the merge sort algorithm from lowest to highest value.
        /// </summary>
        /// <param name="arr">Takes in an array of integers.</param>
        /// <returns>Returns the parameter array.</returns>
        public static int[] MergeSort(int[] arr)
        {
            int arrLength = arr.Length;

            if (arrLength > 1)
            {
                int mid = arr.Length / 2;
                int[] left;
                int[] right;

                if (arr.Length % 2 == 0)
                {
                    left = new int[mid];
                    right = new int[mid];
                }
                else
                {
                    left = new int[mid];
                    right = new int[mid + 1];
                }

                bool half = false;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == mid)
                    {
                        half = true;
                        right[i - mid] = arr[i];
                    }
                    else if (half == false)
                    {
                        left[i] = arr[i];
                    }
                    else
                    {
                        right[(i - mid)] = arr[i];
                    }

                }

                MergeSort(left);
                MergeSort(right);
                Merge(left, right, arr);
            }
            return arr;
        }
        /// <summary>
        /// Private method used in the merge sort method.  Merges the left and right arrays together back into the input array.
        /// </summary>
        /// <param name="left">Left half of the array.</param>
        /// <param name="right">Right half of the array.</param>
        /// <param name="arr">The orignal array parameter from the main function.</param>
        private static void Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }
            if (i == left.Length)
            {
                while (j < right.Length)
                {
                    arr[k] = right[j];
                    j++;
                    k++;
                }
            }
            else
            {
                while (i < left.Length)
                {
                    arr[k] = left[i];
                    i++;
                    k++;
                }
            }
        }
    }
}
