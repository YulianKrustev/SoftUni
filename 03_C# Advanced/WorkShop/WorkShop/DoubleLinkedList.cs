using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShop
{
    public class DoubleLinkedList
    {
        public class Node
        {
            public Node(int value)
            {
                this.Value = value;
            }
            public int Value { get; }

            public Node PreviousNode { get; set; }

            public Node NextNode { get; set; }
        }

        private Node head;
        private Node tail;
        public int Count { get; set; }

        public void AddFirst(int element)
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

        public void AddLast(int element)
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

        public int RemoveFirst()
        {
            CheckIsempty();

            int firstElement = head.Value;
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

        public int RemoveLast()
        {
            CheckIsempty();

            int lastElement = tail.Value;
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

        public int[] ToArray()
        {
            int[] array = new int[Count];
            Node currentNode = head;
            int counter = 0;

            while (currentNode != null)
            {
                array[counter++] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }

            return array;
        }
        public void Print(Action<int> action)
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
