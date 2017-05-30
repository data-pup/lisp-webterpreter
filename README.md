# LISP Web Interpreter Project

## InterpreterCore/

This is the core logic module for the interpreter application. This project
contains code used to generate Abstract Syntax Trees from input strings
containing LISP expressions. This is the code that the API refers to when
generating responses.

## InterpreterCore.Tests/

This is an MSTest project, to assert that the interpreter-core module is
behaving correctly.

## ConsoleInterpreter/

This is a .NET Core Console application that references the InterpreterCore
package. This is an application that depends on the core module itself, rather
than interacting with it through an API.

## lisp-interpreter-interface/

This is a single-page web application built with Create React App. This is
a client-side application that presents an interpreter environment, and sends
requests to the API when inputs are given.

# Misc. Todo Items

*  Revert the interface npm dependencies to use plain Bootstrap. Lack of JQuery dependency is interesting, but it will be easier to target Bootstrap 3.
*  Build a hello world API. This should be able to echo an expression back to the client.
*  Rename the API directory to match the camel case naming convention used in the other sub-directories.

### May 29 Notes:

Test bench has been configured, proof of connection & instantiation of core module within console application is working. More work to do tomorrow with regards to splitting syntactically relevant tokens in raw tokens to generate a flat syntax list, before checking for matching parentheses, operand counts, and (eventually) symbols.