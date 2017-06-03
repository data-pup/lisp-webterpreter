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
