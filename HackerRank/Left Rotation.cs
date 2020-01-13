using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Left_Rotation
    {
        static int[] rotateLeft(int[] a)
        {
            int[] rotation = new int[a.Length];
            rotation[a.Length - 1] = a[0];
            for (int i = 0; i < a.Length - 1; i++)
            {
                rotation[i] = a[i + 1];
            }
            return rotation;
        }
        static int[] leftRotation(int[] a, int d)
        {
            int r = 2;
            int[] c = rotateLeft(a);
            while (r <= d)
            {
                int[] b = rotateLeft(c);
                c = b;
                r++;
            }
            return c;
        }
        static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int[] array = leftRotation(a, d);
            foreach (var item in array)
            {
                Console.Write(item.ToString() + " ");
            }


        }

    }
}