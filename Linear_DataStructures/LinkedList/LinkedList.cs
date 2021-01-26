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
                    throw new InvalidOperationException("no elements");
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

            #region first approach
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
            #endregion
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
            #region:this will take time when you everytime and time complexity -o(n) , u need to handle when you add/delete items
            // int count=0;
            // var current =first;
            //  while(current.next!=null)
            // {
            //     count++;
            //     current=current.next;
            // }
            // return count+1;
            #endregion
        }

        public void Reverse()
        {
            if (IsEmpty())
            {
                return;
            }

            var previous = first;
            var current = first.next;
            while (current != null)
            {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }
            //when current.next =null current.next=previous;
            last = first;
            last.next = null;
            first = previous;

            #region using extra variable with two loops O(n2) and also needs to return variable
            // var previous=last;
            // LinkedList tmp= new LinkedList();
            // while(previous!=first)
            // {
            //     tmp.AddLast(previous.value);
            //     previous=GetPreviousNode(previous);
            // }
            // if(previous==first)
            // {
            //     tmp.AddLast(previous.value);

            // }
            // return tmp;
            #endregion
        }

        public int[] ToArray()
        {
            int[] a = new int[size];
            var current = first;
            int i = 0;
            while (current != null)
            {
                a[i++] = current.value;
                current = current.next;
            }
            return a;
        }


        public int GetKthNodeFromEnd(int k)
        {
            try
            {
                var a = first;
                var b = first;
                for (int i = 0; i < k - 1; i++)
                {
                    b = b.next;
                    if (b == null)
                        throw new ArgumentOutOfRangeException("k is out of range");

                }
                while (b != last)
                {
                    b = b.next;
                    a = a.next;
                }
                return a.value;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return -1;
        }

        public int GetKnthNodeValue_WrongApproach(int k)
        {

            int hop = k == 1 ? 1 : k - 1;
            var slowpointer = first;
            var fastpointer = GetFastPointerNode(hop, first);

            while (fastpointer != null)
            {
                while (slowpointer != null)
                {
                    if (fastpointer == null)
                    {
                        break;
                    }
                    else
                    {
                        fastpointer = GetFastPointerNode(hop, fastpointer);
                        if (fastpointer != null)
                            slowpointer = slowpointer.next;

                    }
                }
            }
            return slowpointer.value;
        }

        private Node GetFastPointerNode(int hop, Node node)
        {
            int i = 0;

            while (i < hop && node != null)
            {
                node = node.next;
                i++;
            }
            return node;
        }

        public void PrintMiddle()
        {
            var a = first;
            var b = first;//Hop(2,first); 
            while (b != last && b.next != last)
            {
                b = b.next.next;
                a = a.next;
            }
            Console.WriteLine(a.value);
            if (b.next == last)
            {
                Console.WriteLine(a.next.value);
            }
        }

        public bool HasLoop()
        {
            //Floyd's cycle detection algorithm
            var a = first.next;
            var b = first.next.next;
            while (b != null || b.next != null)
            {
                a = a.next;
                b = b.next.next;
                if (a == b)
                {
                    Console.WriteLine("Matching node " + b.value);
                    return true;
                }
            }
            return false;
        }

        public static void CreateLoopList()
        {
            //break the loop
            var ll1 = new LinkedList();
            ll1.AddLast(10);
            var node = ll1.last;
            ll1.AddLast(20);
            ll1.AddLast(30);
            ll1.AddLast(40);
            ll1.AddLast(50);
            ll1.last.next = node;
            ;

            Console.WriteLine(ll1.HasLoop().ToString());

        }


    }
}