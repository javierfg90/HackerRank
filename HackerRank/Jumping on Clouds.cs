using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    //https://www.hackerrank.com/challenges/jumping-on-the-clouds-revisited/problem?h_r=internal-search
    class Jumping_on_Clouds
    {
        static int LCM(int a, int b)
        {
            int multiple = 0;
            for (int i = 1; i <= b; i++)
            {
                if ((a * i) % b == 0)
                {
                    multiple = i;
                    break;
                }
            }
            return multiple;
        }
        static int jumpingOnClouds(int[] c, int k)
        {
            int[] visitedClouds = new int[LCM(k, c.Length)];
            int i = 1;
            visitedClouds[0] = c[0];
            while ((i * k) % c.Length != 0)
            {
                visitedClouds[i] = c[(i * k) % c.Length];
                i = i + 1;
            }
            int energyLevel = visitedClouds.Length;
            for (int j = 0; j < visitedClouds.Length; j++)
            {
                if (visitedClouds[j] == 1)
                {
                    energyLevel += 2;
                }
            }
            return 100 - energyLevel;
        }
    }
}
