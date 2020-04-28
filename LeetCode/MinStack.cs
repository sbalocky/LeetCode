using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Element
    {
        public Element Next { get; set; }
        public int Min { get; }
        public int Num { get; }
        public Element(int num, int min)
        {
            Min = min;
            Num = num;
        }
    }

    public class MinStack
    {
        Element _top;

        /** initialize your data structure here. */
        public MinStack()
        {

        }

        public void Push(int x)
        {
            if (_top == null) {
                _top = new Element(x, x);
                return;
            }
            var newElement = new Element(x, Math.Min(_top.Min, x));
            newElement.Next = _top;
            _top = newElement;
        }

        public void Pop()
        {
            if(_top !=null)
            {
                _top = _top.Next;
            }
        }

        public int Top()
        {
            if (_top != null)
            {
                return _top.Num;
            }
            return -1;
        }

        public int GetMin()
        {
            if (_top != null)
            {
                return _top.Min;
            }
            return -1;
        }
    }
}
