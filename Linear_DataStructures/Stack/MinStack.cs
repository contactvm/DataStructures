using System;
namespace Linear_DataStructures
{
    public class MinStack
    {
        private Stack stack = new Stack(5);
        private Stack minStack = new Stack(5);

        public void push(int item)
        {
            stack.push(item);

            if (minStack.IsEmpty())
                minStack.push(item);
            else if (item < minStack.peek())
                minStack.push(item);
        }

        public int? pop()
        {
            if (stack.IsEmpty())
                 throw new InvalidOperationException("Stack 1 empty");   

            var top = stack.pop();

            if (minStack.peek() == top)
                minStack.pop();

            return top;
        }

        public int? min()
        {
            return minStack.peek();
        }
    }
}