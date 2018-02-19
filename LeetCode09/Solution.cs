using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode09
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            var input = x;
            if (x < 0)
                return false;
            int anti = 0;
            while (x != 0)
            {
                var t = x % 10;
                x = (x - t) / 10;

                anti = anti * 10 + t;

            }

            return anti == input || input  == anti/10;
        }
    }
}
