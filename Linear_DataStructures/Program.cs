using System;

namespace Linear_DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList ll = new LinkedList();
            ll.RemoveFirst();
            ll.RemoveLast();
            Console.WriteLine("Size "+ ll.Size().ToString());
            ll.AddLast(10);
            ll.AddLast(20);
            ll.AddLast(30);
            Console.WriteLine("Size "+ ll.Size().ToString());
            //ll.AddFirst(40);
            Console.WriteLine("Index "+ ll.Indexof(30).ToString());
            Console.WriteLine("Index "+ ll.Indexof(10).ToString());
            Console.WriteLine("Index "+ ll.Indexof(15).ToString());
           // ll.AddFirst(2);
           Console.WriteLine("Index "+ ll.Indexof(2).ToString());
           Console.WriteLine("Index "+ ll.Indexof(20).ToString());
           Console.WriteLine("Index "+ ll.Indexof(30).ToString());
           // ll.RemoveFirst();
            ll.RemoveLast();
            Console.WriteLine("Size "+ ll.Size().ToString());
           Console.WriteLine("Contains 10 "+ ll.Contains(10).ToString());
           
        }
    }
}
