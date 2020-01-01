using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Pairs
    {
        private static int MinorPos(int[] a, int start)
        {
            int p = start;
            for (int i = start + 1; i < a.Length; i++)
                if (a[i] < a[p])
                    p = i;
            return p;

        }
        public static void Swap<T>(T[] a, int i, int j)
        {
            T temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
        public static void Order(int[] a)
        {
            for (int k = 0; k < a.Length; k++)
                Swap(a, k, MinorPos(a, k));
        }
        static int pairs(int k, int[] arr)
        {
            Order(arr);
            int i = 0;
            int j = 1;
            int count = 0;
            while (i < arr.Length && j < arr.Length)
            {
                if ((i != j) && (arr[j] - arr[i] == k))
                {
                    count += 1;
                    j++;
                }
                else if ((arr[j] - arr[i]) < k)
                    j++;
                else
                    i++;
            }
            return count;
        }
    }
}
