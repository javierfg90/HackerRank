using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Arrays_DS
    {
        //https://www.hackerrank.com/challenges/arrays-ds/problem
        //Time Complexity:O(N)
        static int[] reverseArray(int[] a)
        {
            int[] reverse = new int[a.Length];
            for(int i=0;i<a.Length;i++)
            {
                reverse[i] = a[a.Length - i-1];
            }
            return reverse;
        }
    }
}
