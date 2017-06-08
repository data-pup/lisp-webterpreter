# LISP Web Interpreter Project

This project is a C# implementation of a LISP interpreter, built using .NET Core 2.0.

A public Gist for collaborative work on this repository can be found [here.](https://gist.github.com/dbkvn/8636891f16ccff81149e277ea6cb2363)

## InterpreterCore/

This is the core logic module for the interpreter application. This project
contains code that implements a LISP parser. This module contains classes
for generating Abstract Syntax Trees from input strings containing LISP
expressions.

## InterpreterCore.Tests/

This is an MSTest project, to assert that the interpreter-core module is
behaving correctly. This directory largely mirrors the structure of the
InterpreterCore module.

The test cases for code in a given class is found in the corresponding
directory in the InterpreterCore.Tests/ directory, with a '.Test.cs' extension.
Files with a pure '.cs' extension in the test module are helper classes,
rather than classes implementing test cases. Files with a '.TestCases.cs'
extension define variables that are used in the '.Test.cs' file of the
same name.

## ConsoleInterpreter/

This is a .NET Core Console application that references the InterpreterCore
package. This project implements a simple interpreter environment, that
will evaluate LISP expressions using the InterpreterCore module.
