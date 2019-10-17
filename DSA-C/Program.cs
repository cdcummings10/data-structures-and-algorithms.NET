using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int[] InsertShiftArray(int[] arr, int num)
        {
            int initialLength = 0;
            int middleIndex = 0;

            if (arr.Length > 0)
            {
                initialLength = arr.Length;
            }

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
