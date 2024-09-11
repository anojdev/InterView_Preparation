using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class TwoStrings
    {
        public String TwoStringsMethod(String s1,String s2)
        {

            HashSet<Char> s1Set = new HashSet<Char>();
            HashSet<Char> s2Set = new HashSet<Char>();

            foreach(char c in s1)
            {
                s1Set.Add(c);
            }
            foreach (char c in s2)
            {
                s2Set.Add(c);
            }

            s1Set.IntersectWith(s2Set);
            if(s1Set.Count > 0)
            {
                return "YES";

            }
            else
            {
                return "NO";
            }

            
        }
    }
}
