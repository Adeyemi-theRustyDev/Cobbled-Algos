# First-Approach && Mistakes 
These are my short solutions to problems that I found in various C# textbooks.
Mostly from:
@) (C# 10 for dummies) [https://dummies.com/C#10fordummies]
@) (Head First C#) [https://apress.com/headfirstc#]

## TextBook Implementations
These are the original implementations by the authors of these books.
All rights tot hte code in these repository is soleley the property of the various authors and the publishers of the said book.
**N.B** => The textbook implementations might differ slightly than what is in the original textbook due to comiler restrictions e.g. *In using null literals*

## First-Implementations
These are my hurriedly-written solutions to these problems
riddles with slight-bugs. The purpose of this repository is to spot these bugs and fix the algorithm
so it is working as it should `(or even better than the author's implememntation)`.


## Answers
These folder contains the solution to each of the answers. The *Authored.cs* and *Bugged.cs* are the originla implementations and the hurriedly-- bug-ridden implementations of the algorithm Respsctively. The Fixed.cs contains the fixed solutions to these bugs and should only be referenced after you've tried every other solution possible.


## How this project is Organized
This project is split into differnt branches on a github repository.
Where each task is contained in its own branch.
Each proect have this four files in common.

@) Authored.cs => This file contains the original code as written by the author in the original book
@) Bugged.cs => This file conatins my not-so-clever workaround for the already working code in Program.cs
@) Program.cs => This conatins the main method and can be used to test the other classes.
@) Fixed.cs => This file contains a fix to the original bug in bugges.cs 
**N.B** => You should not open this file unless you've absolutely tried every method possible to find the bugs. And also, the fixes are here to target specific bugs that prevents the program from
given the same output as the algorithm in Pogram.cs (*some slight changes might be inclusive.*) 