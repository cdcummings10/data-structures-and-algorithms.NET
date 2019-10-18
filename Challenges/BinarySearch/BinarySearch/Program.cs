using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        /// <summary>
        /// Takes in a sorted array of integers and a number. Uses binary sort to find the
        /// number and returns the index. Returns -1 if number cannot be found.
        /// </summary>
        /// <param name="arr">Takes in a sorted array of integers.</param>
        /// <param name="num">Takes in a number as an integer</param>
        /// <returns>Returns the index of a value as an integer.</returns>
        public static int BinarySearchMethod(int[] arr, int num)
        {
            int left = 0;
            try
            {
            int right = arr.Length - 1;
            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (arr[middle] < num)
                {
                    left = middle + 1;
                }
                else if (arr[middle] > num)
                {
                    right = middle - 1;
                }
                else
                {
                    return middle;
                }
            }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
            return -1;
        }
    }
}
