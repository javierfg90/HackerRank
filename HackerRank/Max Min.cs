using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Max_Min
    {
        static void Swap<T>(T[] a, int i, int j)
        {
            T temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
        static int MinorPos(int[] a, int start)
        {
            int p = start;
            for(int i=start+1;i<a.Length;i++)
            {
                if(a[i]<a[p])
                {
                    p = i;
                }
            }
            return p;
        }
        static void Sort(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                Swap(a, i, MinorPos(a, i));
            }
        }
        static int maxMin(int k,int[] arr)
        {
            Sort(arr);
            int[] unfairness = new int[arr.Length -k+ 1];
            for (int i = 0; i < unfairness.Length; i++)
            {
                unfairness[i] = arr[i + k-1] - arr[i];
            }
            return unfairness.Min();
        }
    }
}
