using System;
using System.Reflection;

namespace ConsoleInterpreter.InterpreterGreeting
{
    public class Greeting
    {
        public static readonly string initStartMessage = "Initializing LISP Interpreter Core Module...";
        public static readonly string initCompleteMessage = "Interpreter Core Module Initialized!";
        private static readonly string greetingString = "Welcome to the C# LISP Interpreter!\n";
        private static readonly string rulingString = "-----------------------------------------------";
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

        public static void PrintRuling()
        {
            Console.WriteLine(rulingString);
        }
    }
}