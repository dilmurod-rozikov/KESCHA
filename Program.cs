//KESCHA Project
using KESCHA.classes;


Console.WriteLine("Please, Enter your name:");
string name = Console.ReadLine();

Person kescha = new Person(name);
kescha.Greet(name);

Pet pet = new Pet(name);
pet.MakeSound();

string password = "";

int count = 0;
do{
    Console.WriteLine("Enter password in order to chat with me.");
    password = Console.ReadLine();
    count++;
    if(count == 5)
    {
        System.Console.WriteLine("Sorry, you ran out of attemps..");
        System.Console.WriteLine("Any way you may continue..");
        break;
    }
}while(password != "DimaBilan");


kescha.GetAge();

kescha.AgeDifference();

Console.WriteLine(kescha.GuessAge());

