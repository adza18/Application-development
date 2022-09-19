// See https://aka.ms/new-console-template for more information
using Week1;

Console.WriteLine("Enter your name");
string s = Console.ReadLine();
Console.WriteLine("Welcome!" + s);
Console.WriteLine("Calling method of another class");

Week1.Animal a = new Animal();
a.getAnimal();
Console.WriteLine("Value returned by method of Animal class " + a.getAnimal());



