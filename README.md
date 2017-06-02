# LISP Web Interpreter Project

This project is a C# implementation of a LISP interpreter, built using .NET Core 2.0.

## InterpreterCore/

This is the core logic module for the interpreter application. This project
contains code used to generate Abstract Syntax Trees from input strings
containing LISP expressions. This is the code that the API refers to when
generating responses.

## InterpreterCore.Tests/

This is an MSTest project, to assert that the interpreter-core module is
behaving correctly. This directory largely mirrors the structure of the
InterpreterCore module. The test cases for code in a given class is found
in the corresponding directory in the InterpreterCore.Tests/ directory, with
a '.test.cs' extension. Files with a pure '.cs' extension in the test module
are helper classes, rather than classes implementing test cases.

## ConsoleInterpreter/

This is a .NET Core Console application that references the InterpreterCore
package. This is an application that depends on the core module itself, rather
than interacting with it through an API.

## lisp-interpreter-interface/

This is a single-page web application built with Create React App. This is
a client-side application that presents an interpreter environment, and sends
requests to the API when inputs are given.

### May 29 Notes:

Test bench has been configured, proof of connection & instantiation of core module within console application is working. More work to do tomorrow with regards to splitting syntactically relevant tokens in raw tokens to generate a flat syntax list, before checking for matching parentheses, operand counts, and (eventually) symbols.

### Jun 01 Notes:

Development over the past 2 days has finished the first past at creating a
simple list from a given input expression. An input expression is now split
into a list of tokens according to syntax definition rather than whitespace.

Next steps are a little bit varied, but I am going to need to:

*  perform some test bench maintenance. The testing that I was using for the
syntax token splitting was suitable for development, but I should refactor
this into a development function that I can use to efficiently run the
expression evaluation on a list of functions, while printing the output in
a nice readable format.
*  generate a static syntax tree using the parentheses nesting in the expression,
and then build a checking system to ensure that the expression is value. In
order to do that, I will need to implement two classes: Atom and List. There
are the two types of variables in Lisp, so this will be a prerequisite to
using these to create a syntax tree.
*  Good practice dictates that some of the helper methods used by the
ParseExpressionIntoList method should be more encapsulated once I have built a
robust test bench for the input parser class. These should be placed into
a separate namespace. This will mean adding some import statements wherever
these classes are referenced (ideally only the input parser class.)


### TODO List:
*  Begin drafting documents for a docs/ directory, explaining the architecture of the parsing class.
*  Implement the test cases for the syntax token parsing class. Currently this is only verified via debug functions in the console interpreter module.
*  Add an abstract syntax tree class. Write a constructor that will create a tree using this list.
