using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public static class Sort
    {
        public static void Bubble(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int k = 0; k < arr.Length - (1+i); k++)
                { 
                    if (arr[k] > arr[k + 1])
                    {
                        int temp = arr[k];
                        arr[k] = arr[k + 1];
                        arr[k + 1] = temp;
                    }
                }
            }
        }

        public static int[] Selection(int[] arr)
        {
            throw new NotImplementedException();
        }

        public static void Insertion(int[] arr)
        {
            throw new NotImplementedException();
        }

        public static int[] MergeSort(int[] arr)
        {
            if(arr.Length <= 1)
            {
                return arr;
            }
            decimal midPoint = arr.Length / 2;
            var mid = Convert.ToInt32(Math.Ceiling(midPoint));

            var bot = arr.Take(mid).ToArray();
            var top = arr.Skip(mid).ToArray();

            var botOut = MergeSort(bot);
            var topOut = MergeSort(top);

            var combined = Combine(botOut, topOut);

            return combined;
        }

        private static int[] Combine( int[] bottom, int[] top)
        {
            int i = 0;
            int j = 0;
            var k = 0;
            var arr = new int[bottom.Length + top.Length];
            while(i < bottom.Length && j < top.Length)
            {
                if(bottom[i]<top[j])
                {
                    arr[k] = bottom[i];
                    i++;
                }
                else
                {
                    arr[k] = top[j];
                    j++;
                }
                k++;
            }
            while(i < bottom.Length)
            {
                arr[k] = bottom[i];
                i++;
                k++;
            }
            while (j < top.Length)
            {
                arr[k] = top[j];
                j++;
                k++;
            }
            return arr;

        }
    }
}
