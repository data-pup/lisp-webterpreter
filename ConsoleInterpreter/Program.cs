using System;
using System.Collections.Generic;
using InterpreterCore;

namespace ConsoleInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing LISP Interpreter Core Module...");
            LISPInterpreterCore core = new LISPInterpreterCore();
            GreetCoreModule(core);
        }
        static void GreetCoreModule(LISPInterpreterCore coreModule)
        {
            Console.WriteLine("Requesting a greeting...");
            List<String> response = coreModule.Greet();
            Console.WriteLine("Received the following greeting:");
            foreach(var currentValue in response)
            {
                Console.WriteLine(currentValue);
            }
        }
    }
}
