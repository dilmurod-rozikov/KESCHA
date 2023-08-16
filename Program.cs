//KESCHA Project
using KESCHA.classes;


try
{
    Console.WriteLine("Please, Enter pet's name:");
    string name = Console.ReadLine();
    Pet pet = new Pet(name);
    Console.WriteLine("Pet class created " + pet.CreatedDate);
    pet.MakeSound();
    pet.Greet(name);

    Animal animal = new Animal(name);
    System.Console.WriteLine("Animal class created. " + animal.CreatedDate);
    animal.GetAge();
    animal.AgeDifference();
    Console.WriteLine(animal.GuessAge());


} 
catch(FormatException fex)
{
    Console.WriteLine("Format exception is found..");
}
catch(Exception ex)
{
    Console.WriteLine("Unknown exception is cought..");
}
Console.WriteLine("No error.....");
string password = "";

int count = 0;
do{
    Console.WriteLine("Enter password in order to chat with me.");
    password = Console.ReadLine();
    count++;
    if(count == 5)
    {
        Console.WriteLine("Sorry, you ran out of attemps..");
        Console.WriteLine("Any way you may continue..");
        break;
    }
}while(password != "DimaBilan");



