using System;
using System.Collections.Generic;

using InterpreterCore.Classes;

namespace InterpreterCore.AbstractSyntaxTree
{
    public class AbstractSyntaxTreePrinter
    {
        private static readonly string childListLineMarker = "├──";
        private static readonly string childListLastLineMarker = "└──";
        public static void PrintSyntaxTree(LISPAbstractSyntaxTreeNode ASTNode, int indentLevel = 0)
        {
            // get indentation
            string indentation = new string(' ', indentLevel);
            string currentNodeToken = String.Concat(ASTNode.Token);
            string currentNodeLineMarker;
            // get line .marker
            if(ASTNode.Parent == null)
                currentNodeLineMarker = "";
            else
            {
                if(ASTNode == ASTNode.Parent.Children[ASTNode.Parent.Children.Length - 1])
                    currentNodeLineMarker = childListLastLineMarker;
                else
                    currentNodeLineMarker = childListLineMarker;
            }
            // form token line
            string currentNodeTokenLine = String.Join(' ',
                new List<string> {indentation, currentNodeLineMarker, currentNodeToken});
            // print children
            Console.WriteLine(currentNodeTokenLine);
            if(ASTNode.Children == null)
                return;
            else
                foreach(var currentChild in ASTNode.Children)
                    PrintSyntaxTree(currentChild, indentLevel+4);
        }

        private static string GetIndendationString(LISPAbstractSyntaxTreeNode ASTNode)
        {
            throw new NotImplementedException();
        }
    }
}