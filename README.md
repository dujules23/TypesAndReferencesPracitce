# TypesAndReferencesPracitce
Learning about Types and References in C# and .Net.

These are a few simple exercises to learn more about types and references in C#.

Example 1:

Two elephant classes are initialized, where we want to call each class to write data about each elephant to the log.
We can get the data by pressing 1 or 2.
Pressing 3 will "swap" the the classes, giving the called elephant class the incorrect data.

This can't be done by simply pointing to the other class, so we need a "holder" variable to keep track of the object. 
Otherwise the object will be lost with no references being used.

![Screenshot 2023-09-29 at 1 29 00 PM](https://github.com/dujules23/TypesAndReferencesPracitce/assets/71855759/42be8924-bf76-4db2-9055-f94395465446)



Example 2: 

If we add an additional else if that points lloyd to lucinda (in this example we'll make this case 4), this will "break" the program. The swap functionality will no long work as well.

![Screenshot 2023-10-19 at 5 04 04 PM](https://github.com/dujules23/TypesAndReferencesPracitce/assets/71855759/7fff989d-86ec-48bd-9c28-6a1c9b9863c6)
