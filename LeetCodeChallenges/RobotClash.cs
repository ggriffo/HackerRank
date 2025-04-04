using System;
using System.Collections.Generic;

namespace LeetCodeChallenges
{
    public class RobotClash
    {
        private object[] elements;
        private int size = 0;

        public RobotClash(int capacity)
        {
            elements = new object[capacity];
        }

        public void push(object o)
        {
            EnsureCapacity();
            elements[size++] = o;
        }

        public object Pop()
        {
            if (size == 0)
            {
                throw new NullReferenceException();
            }

            return elements[--size];
        }

        private void EnsureCapacity()
        {
            if (elements.Length == size)
            {
                object[] old = elements;
                elements = new object[2 * size + 1];
                old.CopyTo(elements, 0;
            }
        }
    }
}