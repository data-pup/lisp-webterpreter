using System;
using System.Collections.Generic;

using InterpreterCore.Classes;

namespace InterpreterCore.AbstractSyntaxTree
{
    public class AbstractSyntaxTreePrinter
    {
        private static readonly string childListLineMarker = "├──";
        private static readonly string childListLastLineMarker = "└──";
        public static void PrintSyntaxTree(LISPAbstractSyntaxTreeNode syntaxTree, int indentLevel = 0)
        {
            string indentation = new string(' ', indentLevel);
            string currentNodeToken = String.Concat(syntaxTree.Token);
            string currentNodeLineMarker;
            if(syntaxTree.Parent == null)
                currentNodeLineMarker = "";
            else
            {
                if(syntaxTree == syntaxTree.Parent.Children[syntaxTree.Parent.Children.Length - 1])
                    currentNodeLineMarker = childListLastLineMarker;
                else
                    currentNodeLineMarker = childListLineMarker;
            }
            string currentNodeTokenLine = String.Join(' ',
                new List<string> {indentation, currentNodeLineMarker, currentNodeToken});
            Console.WriteLine(currentNodeTokenLine);
            if(syntaxTree.Children == null)
                return;
            else
                foreach(var currentChild in syntaxTree.Children)
                    PrintSyntaxTree(currentChild, indentLevel+4);
        }
    }
}