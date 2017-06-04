using System;
using System.Collections.Generic;

using InterpreterCore.Classes;

namespace InterpreterCore.AbstractSyntaxTree
{
    public class AbstractSyntaxTreePrinter
    {
        private readonly string childListNodeLine = "├──";
        private readonly string childListLastNodeLine = "└──";
        public static void PrintSyntaxTree(LISPAbstractSyntaxTreeNode syntaxTree, int indentLevel = 0)
        {
            string indentation = new string(' ', indentLevel);
            string currentNodeToken = String.Concat(syntaxTree.Token);
            string currentNodeTokenLine = String.Join(' ',
                new List<string> {indentation, currentNodeToken});
            Console.WriteLine(currentNodeTokenLine);
            if(syntaxTree.Children == null)
                return;
            else
                foreach(var currentChild in syntaxTree.Children)
                    PrintSyntaxTree(currentChild);
        }
    }
}