# LISP Web Interpreter Project

This project is currently a work in progress, building a LISP interpreter.

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
simple list from a given input expression.


### TODO List:
*  Begin drafting documents for a docs/ directory, explaining the architecture of the parsing class.
*  Implement the test cases for the syntax token parsing class. Currently this is only verified via debug functions in the console interpreter module.
*  Add an abstract syntax tree class. Write a constructor that will create a tree using this list.
