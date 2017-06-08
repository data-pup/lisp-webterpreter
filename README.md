# LISP Web Interpreter Project

This project is a C# implementation of a LISP interpreter, built using .NET Core 2.0.

A public Gist for collaborative work on this repository can be found [here.](https://gist.github.com/dbkvn/8636891f16ccff81149e277ea6cb2363)

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

