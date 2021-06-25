using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShop
{
    class CustomStack
    {
        private const int capacity = 4;
        private int[] items;
        private int count;

        public CustomStack()
        {
            items = new int[capacity];
            count = 0;
        }

        public int Count => count;

        private void StackIsEmpty()
        {
            if (Count == 0)
            {
                throw new Exception("Stack is empty!");
            }
        }

        private void ReSize()
        {
            if (Count >= items.Length)
            {
                int[] temp = new int[items.Length * 2];
                Array.Copy(items, temp, Count);
                items = temp;
            }

        }

        public void Push(int item)
        {
            ReSize();
            items[count] = item;
            count++;
        }

        public int Peek()
        {
            StackIsEmpty();
            return items[count - 1];
        }

        public int Pop()
        {
            StackIsEmpty();
            int element = items[Count - 1];
            items[count - 1] = default;
            count--;
            return element;
        }

        public void ForEach(Action<int> action)
        {
            StackIsEmpty();
            for (int i = count - 1; i >= 0; i--)
            {
                action(items[i]);
            }
        }
    }
}
