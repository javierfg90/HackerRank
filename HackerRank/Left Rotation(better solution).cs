using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Left_Rotation_better_solution_
    {
        //https://www.hackerrank.com/challenges/array-left-rotation/problem
        //Time Complexity:O(N)
        static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            d = d % n;
            for(int i= d;i<a.Length;i++)
            {
                Console.Write($"{a[i]} ");
            }
            for(int i=0;i< d;i++)
            {
                Console.Write($"{a[i]} ");
            }
        }
    }
}
