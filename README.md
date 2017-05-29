# LISP Web Interpreter Project

## InterpreterCore/

This is the core logic module for the interpreter application. This project
contains code used to generate Abstract Syntax Trees from input strings
containing LISP expressions. This is the code that the API refers to when
generating responses.

## InterpreterCore.Tests/

This is an MSTest project, to assert that the interpreter-core module is
behaving correctly.

## lisp-api/

This is the client-facing API endpoint that can handle requests containing
a LISP expression. This is a very light-weight .NET Core WebAPI, that
will generate a response using interpreter-core.

## lisp-interpreter-interface/

This is a single-page web application built with Create React App. This is
a client-side application that presents an interpreter environment, and sends
requests to the API when inputs are given.

# Todo

*  Connect the test-interpreter-core project to the interpreter-core module. This should be done in the .csproj file.
*  Add a reference to interpreter-core in the lisp-api project. Check that the functions can be called from the Controller methods.
*  Revert the interface npm dependencies to use plain Bootstrap. Lack of JQuery dependency is interesting, but it will be easier to target Bootstrap 3.
*  Work on the interpreter-core project, work on code to create a flat syntax token list from an input expression.


