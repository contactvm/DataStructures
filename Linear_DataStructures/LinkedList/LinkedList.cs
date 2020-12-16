using System;
namespace Linear_DataStructures
{
    public class LinkedList
    {
        private class Node
        {
            internal int value;
            internal Node next;

            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node first;

        private Node last;

        private int size;

        public void AddLast(int item)
        {
            var node = new Node(item);
            if (IsEmpty())
            {
                first = last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }

            size++;
        }

        public void AddFirst(int item)
        {
            var node = new Node(item);
            if (IsEmpty())
            {
                first = last = node;
            }
            else
            {
                node.next = first;
                first = node;
            }
            size++;
        }
        private bool IsEmpty()
        {
            return first == null;
        }

        public int Indexof(int value)
        {
            var current = first;
            int index = 0;
            while (current != null)
            {
                if (current.value == value) return index;
                index++;
                current = current.next;
            }
            return -1;
            //other method
            // do{
            //     if (node.value==value)
            //     {
            //         return index;
            //     }
            //     else
            //     {
            //         index++;
            //         node=node.next;
            //     }
            // } while (node !=null);
            //return -1;
        }

        public bool Contains(int value)
        {
            return Indexof(value) != -1;
        }

        public void RemoveFirst()
        {
            try
            {
                if (IsEmpty())
                    throw new InvalidOperationException("no elements 123");
                if (first == last)
                {
                    first = last = null;
                }
                else
                {
                    var second = first.next;
                    first.next = null;
                    first = second;
                }
                size--;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //10-->20-->30-->40
        public void RemoveLast()
        {

            try
            {
                if (IsEmpty())
                    throw new InvalidOperationException("no elements);
                if (first == last)
                {
                    first = last = null;
                }
                else
                {
                    var previous = GetPreviousNode(last);
                    last = previous;
                    last.next = null;
                }
                size--;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // first approach
            // var current=first;
            // while(current.next!=null)
            // {
            //     var nextnode=current.next;
            //     if(nextnode.next==null)
            //     {
            //         var secondlast=current;
            //         secondlast.next=null;
            //         last=secondlast;
            //         return;
            //     }
            //     current=current.next;

            // }
        }
        private Node GetPreviousNode(Node node)
        {
            var current = first;
            while (current.next != null)
            {
                if (current.next == node)
                {
                    return current;
                }
                current = current.next;
            }
            return null;
        }

        public int Size()
        {
            return size;
            // int count=0;
            // var current =first;
            //  while(current.next!=null)
            // {
            //     count++;
            //     current=current.next;
            // }
            // return count+1;
        }
    }
}