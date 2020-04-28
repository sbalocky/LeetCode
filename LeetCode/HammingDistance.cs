using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class HammingDistance
    {
        public int HammingDistanceSoltution(int x, int y)
        {
            var dif = x ^ y;
            int i = 0;
            while(dif > 0)
            {       
                i += dif & 1;
                dif = dif >> 1;
            }
            return i;
        }
    }
}
