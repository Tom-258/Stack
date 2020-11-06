using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stacks
    {
        private List<object> _stackObjects = new List<object>();

        public void InputValue()
        {
            while (true)
            {
                Console.WriteLine("Add an item to the stack: Leave null or whitespace to stop adding to the stack.");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                Push(input);
            }
        }
        private void Push(object value)
        {
            _stackObjects.Add(value);
        }

        public object Pop()
        {
            var stackHeight = _stackObjects.Count;
            if (stackHeight == 0)
                throw new ArgumentOutOfRangeException("Stack is Empty");
            var popped = _stackObjects[stackHeight - 1];
            _stackObjects.RemoveAt(stackHeight-1);
            return popped;
        }
    }
}