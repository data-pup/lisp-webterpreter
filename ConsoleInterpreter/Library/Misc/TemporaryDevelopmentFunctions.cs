using System;
using System.Collections.Generic;
using InterpreterCore;

using InterpreterCore.AbstractSyntaxTree;

namespace ConsoleInterpreter
{
    public class TemporaryDevelopmentFunctions
    {
        public static void TempBootstrap()
        {
            // -----------------------------------------------------------------
            // Place temporary work here...
            // -----------------------------------------------------------------
            var parentNode = new LISPAbstractSyntaxTreeNode();
            parentNode.Add("+");
            parentNode.Add("1");
            parentNode.Add("2");
            if(parentNode.Token == "+")
                Console.WriteLine("Root token passes simple test.");
            if(parentNode.Children[0].Token == "2")
                Console.WriteLine("First operand passes simple test.");
            if(parentNode.Children[1].Token == "1")
                Console.WriteLine("Second operand passes simple test.");
        }
    }
}