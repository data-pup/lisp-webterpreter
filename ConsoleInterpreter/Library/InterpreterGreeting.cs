using System;
using System.Reflection;

namespace ConsoleInterpreter.InterpreterGreeting
{
    public class Greeting
    {
        private static readonly string greetingString = "Welcome to the C# LISP Interpreter!\n";
        public static void PrintIntroductoryBanner()
        {
            PrintDebuggingBanner();
            Console.WriteLine(greetingString);
        }

        private static void PrintDebuggingBanner()
        {
            Console.WriteLine("Interpreter Assembly Debug Information:");
            Assembly interpreterAssembly = Assembly.GetExecutingAssembly();
            Diagnostics.DiagnosticsPrinting.PrintAssemblyInformation(interpreterAssembly);
            Diagnostics.DiagnosticsPrinting.PrintLoadedModules(interpreterAssembly);
        }

    }
}