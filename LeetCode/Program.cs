using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //  var solution = new Solution();
            //  solution.isPalindrome(12521);
            //var minStack = new MinStack();

            //minStack.Push(-2);
            //minStack.Push(0);
            //minStack.Push(-3);
            //minStack.GetMin(); //--> Returns - 3.
            //minStack.Pop();
            //minStack.Pop(); //--> Returns 0.
            //minStack.GetMin(); //--> Returns - 2.

            //  new PascalTriangle().Generate(7);
            //var res = new HammingDistance().HammingDistanceSoltution(1, 4);
            var pal = new LinkedListPalindrome();
            var isPal = pal.IsPalindrome(pal.GetTestData());
        }
    }

    class Solution
    {
        public bool isPalindrome(int x)
        {
            if(x<0)
            {
                return false;
            }

            var tmp = x;
            var num = 0;
            var res = 0;
            var iteration = 1;
            while(x != 0)
            {
                num = x % 10;
                x = x / 10;

                res = iteration * res + num;
                iteration=10;
            }
            return tmp == res;
        }
    };
}
