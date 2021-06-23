using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShop
{
    class CustomList
    {
        private int[] items;
        private const int Initialcapacity = 2;

        public CustomList()
        {
            this.items = new int[Initialcapacity];
            this.Count = 0;
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                ValideteIndex(index);
                return items[index]; 
            }
            set 
            {
                ValideteIndex(index);
                items[index] = value; 
            }
        }
        public void Add(int i)
        {
            Resize();
            items[Count] = i;
            Count++;
        }

        private void Shrink()
        {
            if (Count * 4 >= items.Length)
            {
                return;
            }

            int[] temp = new int[this.items.Length / 2];
            Array.Copy(items, temp, Count);
            items = temp;
        }

        private void Resize()
        {
            if (items.Length < Count)
            {
                return;
            }

            int[] temp = new int[this.items.Length * 2];
            Array.Copy(items, temp, items.Length);
            items = temp;
        }

        private void Shift(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }

            items[items.Length-1] = default;
        }

        public int RemoveAt(int index)
        {
            ValideteIndex(index);
            int element = items[index];

            Shift(index);
            Count--;
            Shrink();

            return element;
        }

        private void ValideteIndex(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
