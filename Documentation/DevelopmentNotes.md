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

### TODO List:
*  Begin drafting documents for a docs/ directory, explaining the architecture of the parsing class.
*  Add an abstract syntax tree class. Write a constructor that will create a tree using this list.
