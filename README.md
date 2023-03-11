# First-Approach && Mistakes 
These are short solutions to-- and implementations of-- various Algorithms in the C# Language that I found in various C# textbooks and other sources online.
The source of each task and the steps to complete a task  are conatined in the *(Task.cs)*[~/Task.md]

## TextBook Implementations
These are the original implementations by the authors of these books, online blog post or other source.
All rights to the code in this repository is solely the property of the various authors and the publishers of the said book.
**N.B** => The textbook implementations might differ slightly than what is in the original textbook due to comiler restrictions e.g. *In using null literals*

## First-Implementations
These are my hurriedly-written solutions to these problems
riddled with slight-bugs. The purpose of this repository is to spot these bugs and fix them so the algorithm is working as it should `(or even better than the author's implementation)`.


## Answers
These folder contains the solution to each of the answers. The *Authored.cs* and *Bugged.cs* are the original implementations and the hurriedly-- *bug-ridden*-- implementations of the algorithms respectively. The Fixed.cs file contains the fixed solutions to these bugs and should only be referenced after you've tried every other solution possible.


## How this project is Organized
This project is split into differnt branches on a github repository.
Where each task is contained in its own branch.
Each project has these four files in common:

* Authored.cs => This file contains the original code as written by the author in the original book
* Bugged.cs => This file conatins my not-so-clever workaround for the already working code in Program.cs
* Fixed.cs => This file contains a fix to the original bug in bugges.cs 
**N.B** => You should not open this file unless you've absolutely tried every method possible to find the bugs. And also, the fixes are here to target specific bugs that prevents the program from
given the same output as the algorithm in Pogram.cs (*some slight changes might be inclusive.*) 
* Program.cs => This conatins the main method and can be used to test the other classes. It contains the main method where all the other classews can be called from and 