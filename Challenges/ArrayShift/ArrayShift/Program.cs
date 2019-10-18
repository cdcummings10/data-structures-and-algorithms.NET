using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayShift
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        /// <summary>
        /// Takes in an array and a number and returns a new array with the number added into
        /// the middle of the new array.
        /// </summary>
        /// <param name="arr">Takes in an array of integers.</param>
        /// <param name="num">Takes in a number as an integer.</param>
        /// <returns>Returns the updated integer array.</returns>
        public static int[] InsertShiftArray(int[] arr, int num)
        {
            int initialLength = arr.Length;
            int middleIndex = 0;

            if (initialLength % 2 == 0)
            {
                middleIndex = (initialLength / 2);
            }
            else
            {
                middleIndex = (initialLength / 2) + 1;
            }

            int[] answer = new int[initialLength + 1];
            bool inserted = false;
            for (int i = 0; i < answer.Length; i++)
            {
                if (middleIndex == i)
                {
                    answer[i] = num;
                    inserted = true;
                }
                else if (inserted)
                {
                    answer[i] = arr[i - 1];
                }
                else
                {
                    answer[i] = arr[i];
                }
            }
            return answer;
        }
    }
}
