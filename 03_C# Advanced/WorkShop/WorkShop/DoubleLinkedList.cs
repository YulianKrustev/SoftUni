using System;

namespace WorkShop
{
    public class DoubleLinkedList<T> 
        where T : IComparable<T>
    {
        private class Node
        {
            public Node(T value)
            {
                this.Value = value;
            }
            public T Value { get; }

            public Node PreviousNode { get; set; }

            public Node NextNode { get; set; }
        }

        private Node head;
        private Node tail;
        public int Count { get; private set; }

        public void AddFirst(T element)
        {
            Node newHead = new Node(element);

            if (Count == 0)
            {
                head = tail = newHead;
            }
            else
            {
                newHead.NextNode = head;
                head.PreviousNode = newHead;
                head = newHead;
            }

            Count++;
        }

        public void AddLast(T element)
        {
            Node newTail = new Node(element);

            if (Count == 0)
            {
                head = tail = newTail;
            }
            else
            {
                newTail.PreviousNode = tail;
                tail.NextNode = newTail;
                tail = newTail;
            }

            Count++;
        }

        public T RemoveFirst()
        {
            CheckIsempty();

            T firstElement = head.Value;
            head = head.NextNode;

            if (head == null)
            {
                tail = null;
            }
            else
            {
                head.PreviousNode = null;
            }

            Count--;
            return firstElement;
        }

        public T RemoveLast()
        {
            CheckIsempty();

            T lastElement = tail.Value;
            tail = tail.PreviousNode;

            if (tail == null)
            {
                head = null;
            }
            else
            {
                tail.NextNode = null;
            }

            Count--;
            return lastElement;
        }

        public bool Contains(T element)
        {
            Node currentNode = this.head;

            while (currentNode != null)
            {
                if (currentNode.Value.CompareTo(element) == 0)
                {
                    return true;
                }

                currentNode = currentNode.NextNode;
            }

            return false;
        }

        public T[] ToArray()
        {
            T[] array = new T[Count];
            Node currentNode = head;
            int counter = 0;

            while (currentNode != null)
            {
                array[counter++] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }

            return array;
        }
        public void Print(Action<T> action)
        {
            Node current = head;

            while (current != null)
            {
                action(current.Value);
                current = current.NextNode;
            }
        }

        private void CheckIsempty()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("List is empty");
            }
        }
    }
}
