// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Create some new Rectangle objects with dimensions
Rectangle rect1 = new Rectangle(10, 20);
Rectangle rect2 = new Rectangle(5);

Console.WriteLine(rect1.GetArea());
Console.WriteLine(rect2.GetArea());


// TODO: Change the values of width and height
rect1.width = 15;
rect1.height = 25;
Console.WriteLine(rect1.GetArea());
