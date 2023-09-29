# TypesAndReferencesPracitce
Learning about Types and References in C# and .Net.

These are a few simple exercises to learn more about types and references in C#.

Example 1:

Two elephant classes are initialized, where we want to call each class to write data about each elephant to the log.
We can get the data by pressing 1 or 2.
Pressing 3 will "swap" the the classes, giving the called elephant class the incorrect data.

This can't be done by simply pointing to the other class, so we need a "holder" variable to keep track of the object. 
Otherwise the object will be lost with no references being used.
