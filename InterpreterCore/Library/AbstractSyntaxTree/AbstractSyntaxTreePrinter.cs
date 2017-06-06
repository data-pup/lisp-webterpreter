using System;
using System.Collections.Generic;

// using InterpreterCore.Classes.Lisp;

namespace InterpreterCore.Classes.AbstractSyntaxTree
{
    public class AbstractSyntaxTreePrinter
    {
        private static readonly string lineMarker = "├──";
        private static readonly int indentationIncrement = 4;
        public static void PrintSyntaxTree(LISPAbstractSyntaxTreeNode ASTNode)
        {
            if(ASTNode == null)
            {
                throw new NullReferenceException();
            }
            else if(ASTNode.IsEmpty())
                return;
            PrintCurrentNodeTokenWithIndentation(ASTNode);
            if(ASTNode.Children != null)
            {   // Print any nodes descending from the current node.
                foreach(var currentChild in ASTNode.Children)
                    PrintSyntaxTree(currentChild);
            }
        }

        /// <summary>
        /// The method will print the current node token to the console,
        /// with indentation generated using GetIndendationString.
        /// </summary>
        private static void PrintCurrentNodeTokenWithIndentation(LISPAbstractSyntaxTreeNode ASTNode)
        {
            string currentNodeToken = ASTNode.Token;
            string indentationString = GetIndendationString(ASTNode);
            string currentNodeTokenLine = String.Join(' ',
                new List<string> {indentationString, lineMarker, currentNodeToken});
            Console.WriteLine(currentNodeTokenLine);
        }

        /// <summary>
        /// This method will return the whitespace that should preface a token
        /// when printing abstract syntax trees in a human readable format.
        /// </summary>
        private static string GetIndendationString(LISPAbstractSyntaxTreeNode ASTNode)
        {
            // Check if the node is the root, or a direct descendent of the root.
            bool doesNotNeedIndendation = ASTNode.IsRoot();
            doesNotNeedIndendation = (doesNotNeedIndendation) ? doesNotNeedIndendation : ASTNode.Parent.IsRoot();
            if(doesNotNeedIndendation)
            {   // If so, there is no need to indent. Return an empty string.
                return "";
            }
            // Find the parent's indentation and form an indentation string.
            string parentIndentationString = GetIndendationString(ASTNode.Parent);
            string indentationWhitespace = new string(' ', indentationIncrement);
            string indentationString = String.Concat(parentIndentationString,
                " |", indentationWhitespace);
            return indentationString;
        }
    }
}