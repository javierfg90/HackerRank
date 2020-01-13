using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class _2D_Array_DS
    {
        //https://www.hackerrank.com/challenges/2d-array/problem
        //Time Complexity:O(1)
        static int specificSum(int[][] a,int n,int m)
        {
            return a[n][m] + a[n][m + 1] + a[n][m + 2] + a[n + 1][m + 1] + a[n + 2][m] + a[n + 2][m + 1] + a[n + 2][m + 2];
        }
        static int hourglassSum(int[][] arr)
        {
            int[][] sums = new int[4][];
            for (int i = 0; i < 4; i++)
            {
                sums[i] = new int[4];
            }
            for (int i = 0; i < 4; i++)
            {
                for(int j=0;j<4;j++)
                {
                    sums[i][j] = specificSum(arr, i, j);
                }
            }
            int[] MaxValues = new int[4];
            for (int k = 0; k < 4; k++)
            {
                MaxValues[k] = arr[k].Max();
            }
            return MaxValues.Max();
        }
        
    }
}
