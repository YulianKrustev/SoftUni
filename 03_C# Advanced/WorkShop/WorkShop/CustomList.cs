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

            items[items.Length - 1] = default;
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

        private void ShiftToRight(int index)
        {
            for (int i = Count - 1; i >= index; i--)
            {
                items[i] = items[i - 1];
            }
        }

        public void Insert(int index, int element)
        {
            ValideteIndex(index);
            Count++;
            Resize();
            ShiftToRight(index);
            items[index] = element;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i] == element)
                {
                    return true;
                } 
            }

            return false;
        }

        public void Swap(int index1, int index2)
        {
            ValideteIndex(index1);
            ValideteIndex(index2);

            int temp = items[index1];

            items[index1] = items[index2];
            items[index2] = temp;
        }
    }
}
