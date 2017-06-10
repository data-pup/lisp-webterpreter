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


        /// <summary>
        /// Print a welcome message to the client.
        /// </summary>
        public static void PrintIntroductoryBanner()
        {
            Console.WriteLine(greetingString);
            PrintRuling();
        }

        /// <summary>
        /// Print a welcome message to the client, including debugging information.
        /// </summary>
        public static void PrintDebuggingBanner()
        {
            Console.WriteLine("Interpreter Assembly Debug Information:");
            Assembly interpreterAssembly = Assembly.GetExecutingAssembly();
            Diagnostics.DiagnosticsPrinting.PrintAssemblyInformation(interpreterAssembly);
            Diagnostics.DiagnosticsPrinting.PrintLoadedModules(interpreterAssembly);
            Console.WriteLine(greetingString);
            PrintRuling();
        }

        private static void PrintRuling()
        {
            Console.WriteLine(rulingString);
        }
    }
}