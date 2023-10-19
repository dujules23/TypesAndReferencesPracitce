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


Example 3:

This example is showcases how objects use references to talk to each other.

I've made two methods; HearMessage and SpeakTo.

![Screenshot 2023-10-19 at 6 09 24 PM](https://github.com/dujules23/TypesAndReferencesPracitce/assets/71855759/99e1adc6-abf5-4b68-a322-0eb5afbef681)

A new else if is created that calls the SpeakTo method.

![Screenshot 2023-10-19 at 6 09 34 PM](https://github.com/dujules23/TypesAndReferencesPracitce/assets/71855759/de933161-754d-4211-a949-c7deb3111521)

The result is below, which shows that by using the "this" keyword, the object can get a reference to itself.

![Screenshot 2023-10-19 at 6 09 49 PM](https://github.com/dujules23/TypesAndReferencesPracitce/assets/71855759/fc7f8fb5-989a-4ab5-99e0-97522ec1f5ba)


