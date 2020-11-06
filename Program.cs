using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulates the "Run" method so that the Main method is not filled with code
            Run();
        }

        private static void Run()
        {
            //Creates a new instance of the Stacks class
            var stack = new Stacks();
            while (true)
            {
                Console.WriteLine("Push, Pop or Exit?");
                //Takes an input from the user to decide what method to run from the stacks class
                var selector = Console.ReadLine();
                //A switch block allows for simple execution of Stacks internal methods and makes the code unbreakable
                switch (selector)
                {
                    case "Push":
                        stack.InputValue(); //Separated the inputting of a value to be pushed into a separate method so that the push method cannot be directly accessed. This also means that the switch block is not cluttered with code.
                        break;
                    case "Pop":
                        Console.WriteLine(stack.Pop());
                        break;
                    case "Exit":
                        throw new Exception("Program Terminated");
                    default: //This default block makes the code unbreakable
                        Console.WriteLine("Invalid Entry");
                        continue;
                }
            }
        }
        
    }
}
