using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Append_and_Delete
    {
        static string appendAndDelete(string s, string t, int k)
        {
            if((s.Length+t.Length)<k)
            {
                return "Yes";
            }
            int equalPart = 0;
            for(int i=0;i<Math.Min(s.Length,t.Length);i++)
            {
                if (s == t)
                    equalPart++;
                else
                    break;
            }
            
            if ((k-s.Length-t.Length+2*equalPart)%2==0)
            {
                return "Yes";
            }
            return "False";
        }
    }
}
