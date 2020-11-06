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
            Run();
        }

        private static void Run()
        {
            var stack = new Stacks();
            while (true)
            {
                Console.WriteLine("Push, Pop or Exit?");
                var selector = Console.ReadLine();

                switch (selector)
                {
                    case "Push":
                        stack.InputValue();
                        break;
                    case "Pop":
                        Console.WriteLine(stack.Pop());
                        break;
                    case "Exit":
                        throw new Exception("Program Terminated");
                    default:
                        Console.WriteLine("Invalid Entry");
                        continue;
                }
            }
        }
        
    }
}
