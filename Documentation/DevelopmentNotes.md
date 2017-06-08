### May 29 Notes:

Test bench has been configured, proof of connection & instantiation of core
module within console application is working. More work to do tomorrow with
regards to splitting syntactically relevant tokens in raw tokens to generate
a flat syntax list, before checking for matching parentheses, operand counts,
and (eventually) symbols.

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

### Jun 02 Notes:

This code went through some serious structural changes, so it's worth mentioning
why.' A rough skeleton of the interpreter runtime environment is now in place.
The console interpreter creates a new interpreter instance, which uses the
interpreter library to generate output results, given an input.

There is a blank directory structure to be worked on later that would handle
interpreter commands like '.help' or '.exit'.

Notes on the Atom and List classes: [General projections, subject to change]
lispatom should be a generic class, for an int or float, that is created with a string.
lisplist should be a linked list of atoms
lispexpression should be a tuple storing an operator and a lisplist.
lispast should be a linked list of lispexpressions.

### Jun 03 Notes:

Atom is now a generic class that can be instantiated with a specific type!
There is some testing in place for this now as well, and it seems to be
working well :)

Next, I am going to refactor the input parsing module, and encapsulate things
better. This should all be placed in an individual namespace, such as
InterpreterCore.InputParsing. Once this is done, we will add more functionality
in the public API so that the function will return a nested list, rather than
a flat list of syntax tokens. (This will remove parentheses tokens.)

Other long term changes I am thinking about:
Interpreter envirionment help, info, exit commands should be built, these can
print simple strings, or end the program (This should add an exit() function to
the interpreter core module.).

The operator characters file in the syntax directory will likely become
obsolete when operator class objects are added. These objects would have
some sort of Token = '+' member, which could be referenced directly in lieu
of an extra file that would also have to be modified when changing things.

### June 03 Conclusion Notes:

Raw input parsing is complete. Abstract syntax trees can be constructed manually
using the Add method. Test bench has been updated, and the console module has
an easy development switch that's currently active.

Tomorrow, finish the string[] constructor for the tree class, and implement
validation functions for the node class. Then, finish up the arithmetic
methods, and begin final prep for adding variables.

### June 04 Notes:

Now that I can create arbritrary syntax trees, I should add some supporting
functions, including a validator and a printing function. The validator
should check that each token is either: (1) an empty node w/ no children,
(2) a value w/ no arguments, (3) an op w/ arguments. The printing function
should print the tokens out in the same manner as the 'tree' CLI tool.

### June 04 Conclusion Notes:

Proof of concept is working! The interpreter environment in its current
configuration will now print out the abstract syntax tree that was read
using the input from the client. That's really cool!

The next thing to do is to add some functionality to resolve each node.
This means that a node tha that stores a value should return the value,
and a node with an operator and arguments should pop the elements off
the stack, and resolve using the operation function.

Variable symbols can be resolved before this stage, which would mean
traversing the tree and replacing tokens with a stored value.

### June 05 Notes:

Revised and refactored code from the weekend. The tree constructor accepting
a string array and the supporting method were separated into private static
helper methods. This improved the readability of the code, so that looping
constructs did not become too complex. Hooray!

I cleaned up the tree class, the commented out code that had been left in the
file was obsolete at this point, as it was logic that was redundant to the
node constructor implemented and discussed above. Hooray for encapsulation!

The abstract syntax tree class will cater to a higher-level of level of
abstraction, and should be much more simplistic. The node class implements
the recursive logic and so forth, the tree class itself should handle checking
if the expression is valid, resolving symbol names, and so forth.

### June 06 Notes:

The node class should expose a method, Resolve() that will return the result
of the expression in a LISPAtom object. Once this is accomplished, the tree
class will expose a Resolve() method as well. This will invoke the root node's
Resolve() method and return the result.

The node resolve method should handle each individual node roughly like this:
  if the node is empty:
    resolve either 0 or null (This is a design decision to consider.)
  if the node has no children:
    use the token value to create a new atom (symbols resolved here?)
    return the new atom
  if the node has children:
    the token value must be a valid operator character.
    resolve the operator charactor, get a Func<IEnumerable<Atom>,Atom> function.
    create a lisp list object,
    for each child node:
      add child.Resolve() to the list
    pass the list to the operator function, and return the result.

Todo: complete an overview document, initialize a gist for collaborative work.
add links to classes that will be worked on, and (2) potential tasks:
1. Add a symbol resolver, which will allow for variable names to
be replaced at runtime with a value. This will require implementing
an assignment operator.
2.  Implement operators in a manner that will allow for both integers and
floating point numbers to be resolved. Should this be done using public static
generic methods?

Other prep goals:
  - Add some interface classes that the lisp classes will implement.
    This will help code readability, as the classes are designed around
    an easily-referenced spec.
  - InterpreterCore module could benefit from more clean-up and revision.
    While working on the console interpreter I learned some new things about
    how the namespace system works. Using statements can be removed if I
    name things correctly. This is also convenient because it means that
    the console interpreter will only need one using statement, if I am
    understanding all of this right.
  - Implement the list atom's operator methods. These will be needed to
    implement operator functions that accept an IEnumerable parameter.

### June 06 Conclusion Notes

Tonight was largely about cleaning up. Different inital drafts of classes
had been laying around in placeholder files, early testing functions, etc.
were removed. Now that the syntax tree class is functional, these placeholders
were outdated. These should be built against the new changes that have been
made.

I _have_ added one placeholder however, that being the LISPList class. This
will help with the resolve function described above. Going through the
atom class, I also noted that the object needs a type argument when being
created. This might play a role in the list class.

### June 07 Notes

I added content to documentation and readme files, made some minor formatting
revisions where needed. I noticed an architectural change that should be
carried out, but it will require changing the top layer in the core module.

The primary public method for the interpreter should not return a string
array. This is reflective of the earlier versions of this project, and
can be cleaned up. The function should accept a string parameter and
return an abstract syntax tree object representing the input expression.

However, I identified an problem with the interpreter environment when
testing it out. Aborting upon an exception is good, but the interpreter
itself should handle the exception and present a clean prompt.

