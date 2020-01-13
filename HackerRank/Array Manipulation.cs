using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Array_Manipulation
    {
        //https://www.hackerrank.com/challenges/crush/problem
        //Time Complexity: O(N)
        static long getMax(int[] arr)
        {
            long max = 0;
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                max = Math.Max(sum, max);
            }
            return max;
        }
        static long arrayManipulation(int n, int[][] queries)
        {
            int[] temp = new int[n + 2];
            for (int i = 0; i < queries.Length; i++)
            {
                int a = queries[i][0];
                int b = queries[i][1];
                int k = queries[i][2];
                temp[a] += k;
                temp[b + 1] -= k;
            }
            return getMax(temp);
        }
    }
}
