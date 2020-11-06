using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stacks
    {
        private List<object> _stackObjects = new List<object>(); //Using a list of type object means that any value can be contained within it without throwing an exception

        public void InputValue()
        {
            while (true)
            {
                Console.WriteLine("Add an item to the stack: Leave null or whitespace to stop adding to the stack.");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) break;
                Push(input);
            }
        }
        private void Push(object value)
        {
            _stackObjects.Add(value); //Adds any value to the stack
        }

        public object Pop()
        {
            var stackHeight = _stackObjects.Count;
            if (stackHeight == 0)
                throw new ArgumentOutOfRangeException("Stack is Empty");
            var popped = _stackObjects[stackHeight - 1];
            _stackObjects.RemoveAt(stackHeight-1); //RemoveAt is important because Remove would delete the first instance of an item in the stack. Something that we do not want 
            return popped;
        }
    }
}