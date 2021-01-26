using System;
namespace Linear_DataStructures
{
    public class TwoStacks
    {
        Array
        int top1;
        int top2;
        int[] items;
        public TwoStacks(int capacity)
        {
            if(capacity<=0)
             throw new InvalidOperationException("Capacity sould be equal or greater than 1");
             items = new int[capacity];
             top1=-1;
             top2=capacity;
        }
        public void push1(int item)
        {
            if(IsFull1())
            {
                 throw new InvalidOperationException("Stack 1 full");   
            }
            items[++top1]=item;
        }
        public int pop1()
        {
            if(IsEmpty1())
            {
                throw new InvalidOperationException("Stack 1 empty");   
            }
            return items[top1--];
        }
        public bool IsEmpty1()
        {
            return top1==-1;
        }
        public bool IsFull1()
        {
            return top1+1==top2;
        }        
        public void push2(int item)
        {
            if(IsFull2())
            {
                 throw new InvalidOperationException("Stack 2 full");   
            }
            items[--top2]=item;
        }
         public int pop2()
        {
            if(IsEmpty2())
            {
                throw new InvalidOperationException("Stack 2 empty");   
            }
            return items[top2++];
        }
         public bool IsEmpty2()
        {
            return top2==-items.Length;
        }
          public bool IsFull2()
        {
            return top1==top2-1;
        }
    }
}