using System;

namespace Linear_DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {
                //---------------------LINKED LIST----------------------------//
                //     LinkedList ll = new LinkedList();
                    //     ll.RemoveFirst();
                    //     ll.RemoveLast();
                    //     Console.WriteLine("Size "+ ll.Size().ToString());
                    //     ll.AddLast(10);
                    //     ll.AddLast(20);
                    //     ll.AddLast(30);
                    //     ll.AddLast(40);
                    //     ll.AddLast(50);          
                    //     ll.AddLast(60);
                    //     ll.AddLast(70);
                    //     ll.AddLast(90);
                    //     ll.PrintMiddle();
                    //     ll.Reverse();
                    //     int []a=ll.ToArray();
                    //     Console.WriteLine("K=3 value"+ ll.GetKthNodeFromEnd(3).ToString());
                    //     Console.WriteLine("K=2 value"+ ll.GetKthNodeFromEnd(2).ToString());
                    //     Console.WriteLine("K=4 value"+ ll.GetKthNodeFromEnd(7).ToString());


                    //     LinkedList.CreateLoopList();

                    //     Console.WriteLine("Size "+ ll.Size().ToString());
                    //     //ll.AddFirst(40);
                    //     Console.WriteLine("Index "+ ll.Indexof(30).ToString());
                    //     Console.WriteLine("Index "+ ll.Indexof(10).ToString());
                    //     Console.WriteLine("Index "+ ll.Indexof(15).ToString());
                    //    // ll.AddFirst(2);
                    //    Console.WriteLine("Index "+ ll.Indexof(2).ToString());
                    //    Console.WriteLine("Index "+ ll.Indexof(20).ToString());
                    //    Console.WriteLine("Index "+ ll.Indexof(30).ToString());
                    //    // ll.RemoveFirst();
                    //     ll.RemoveLast();
                    //    Console.WriteLine("Size "+ ll.Size().ToString());
                    //    Console.WriteLine("Contains 10 "+ ll.Contains(10).ToString());

                AddNumbers.DriverCode();
                //------------------STACK-------------------------//
                //Stack.DriverCode();
                //StringCombination.DriverCode();
                 
                 
                  //-----QUEUE-----//
                    //Queue.QueueQuestions.DriverCode(); 
                    //ArrayQueue.DriverCode()  ; 
                    //StackQueue.DriverCode();
                    //PriorityQueue.DriverCode();
                    //ReverseQueue.DriverCode();
                    //LinkedListQueue.DriverCode();

                 //-----ARRAY-----//
                    //SegregateArray.DriverCode();
                    //MaxStockProfit.DriverCode();

                 //------HASHFUNCTIONS-------//
                    //FirstRepeatCharacter.DriverCode();
                

                //-----------------------HASH TABLE------------------------------------//
               // HashTable.DriverCode();
                HashTableExercises.DriverCode();

               }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }

    }
}
