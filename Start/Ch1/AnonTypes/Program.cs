 // Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Creating and using Anonymous types

// TODO: Anonymous types can be declared using "new" and { }, similar to JS
var myobj = new
{
    Name = "John Doe", 
    Age = 25, 
    Address = new 
    {
        Street = "123 Main St", 
        City = "Anytown", 
        State = "NY"
    } // Nested anonymous type
};
// anonymous type override ToString() method by default to display property names and values
Console.WriteLine(myobj.ToString()); 

// Anonymous types are read-only and cannot be modified
// myobj.Name = "Jane Doe"; # will cause an error

// TODO: To change a value, use non-destructive mutation and "with" clause
var myobj2 = myobj with { Name = "Jane Doe" };
Console.WriteLine(myobj2.ToString());

// TODO: You can check to see if an anonymous object contains a property
Console.WriteLine(myobj.GetType().GetProperty("Name") != null); // True
Console.WriteLine(myobj.GetType().GetProperty("Phone") != null); // False
