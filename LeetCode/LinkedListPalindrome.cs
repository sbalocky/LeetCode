using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
     public class ListNode
     {
          public int val;
          public ListNode next;
          public ListNode(int x) { val = x; }
     }
    public class LinkedListPalindrome
    {
        public ListNode GetTestData()
        {
            var head = new ListNode(1);

            var node1 = new ListNode(3);
            head.next = node1;
            
            var node2 = new ListNode(2);
            node1.next = node2;

            var node3 = new ListNode(3);
            node2.next = node3;

            var node4 = new ListNode(1);
            node3.next = node4;

            return head;

        }
        public bool IsPalindrome(ListNode head)
        {
            var stack = new Stack<int>();
            var h = head;
            while(h != null)
            {
                stack.Push(h.val);
                h = h.next;
            }
            while(head != null)
            {
                var val = stack.Pop();
                if(head.val != val)
                {
                    return false;
                }
                head = head.next;
            }
            return true;
        }
    }
}
