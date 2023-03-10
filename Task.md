# Obective
Build a sentence using the following:
@) Create an array of exit terms. e.g `{"quit", "exit"}`
@) declare variable statement`(type=string)` **initialize as an empty string**;
@) declare variable canExit`(type=bool)` **initialize to false**
@) declare and intialize variable phrase to an empty string
@) Loop through the following steps:
    -Prompt a user to enter a phrase from the command line and store in the *phrase* variable.
    -if variable *phrase* can be found in the aforementioned array quit the loop
    -else append *phrase* to the variable *statement*
    -print *statement* out to the console
@) end **PROGRAM**


## Sample Output:
`
>**Each line you enter will be added to a 
>sentence until you enter EXIT or QUIT**
**Enter a string**
Programming with
**You've entered: Programming with**
**Enter a string**
C# is fun
**You've entered: Programming with C# is fun**
**Enter a string**
(more or less)
**You've entered: Programming with C# is fun (more or less)**
**Enter a string**
EXIT
**Total sentence:**
Programming with C# is fun (more or less)
`




## With the original **Bugged.cs** File
Issues:
- The program only quits when one of the term is entered but not when the other is entered.
- \(Extra\), The previous input is squeezed together with the new input like they are one word.
