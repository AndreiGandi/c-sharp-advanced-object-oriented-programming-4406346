// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using object and collection initializers

// TODO: Use the initializer syntax to create new objects
Dog dog = new Dog() { Name = "Razvan", Age = 3, IsTrained = true };
Cat cat = new Cat() { Name = "Tara", Age = 2, IsDeclawed = true };

Pet pet = new Dog();
Console.WriteLine($"{pet.GetType()}");

// TODO: Initializers can be used on anonymous types
var pet2 = new
{
    Name = "Jon",
    Age = 4,
    IsTrained = true,
};
Console.WriteLine($"Pet: {pet2.Name}, {pet2.Age}");

// TODO: Collections can also be initialized this way
int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
Console.WriteLine(string.Join("-", numbers));

// TODO: Initialize a collection with a set of objects
PetOwner petOwner = new PetOwner()
{
    Name = "Andrei",
    Pets = new List<Pet>
    {
        new Dog() { Name = "James", Age = 2, IsTrained=true },
        new Cat() { Name = "Lisa", Age = 3, IsDeclawed=true }
    }
};
Console.WriteLine($"{petOwner.Name}");
foreach (var p in petOwner.Pets)
{
    Console.WriteLine($"\t{p.Name}, {p.Age}");
}

