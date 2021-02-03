using System;
namespace Linear_DataStructures
{
    public class Stack
    {
        int?[] a;
        int count = 0;
        public Stack(int length)
        {
            a = new int?[length];
        }

        public void push(int item)
        {
            if (count <= a.Length)
            {
                a[count++] = item;
            }
            else
            {
                Console.WriteLine("stack is full");
            }
        }

        public int? pop()
        {
            if (count > 0)
            {
                var popvalue = a[count-1];
                a[--count] = null;
                return popvalue;
            }
            return null;
        }

        public int? peek()
        {
            if (count > 0)
            {
                var popvalue = a[count-1];

                return popvalue;
            }
            return null;
        }

        public bool IsEmpty()
        {
            return count != -1;
        }

      public static void DriverCode()
        {
            try
            {
                Stack s = new Stack(3);
                s.push(2);
                s.push(3);
                s.push(4);
                Console.WriteLine (s.pop().ToString());
                 Console.WriteLine (s.peek().ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
