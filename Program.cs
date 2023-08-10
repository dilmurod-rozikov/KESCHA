//KESCHA Project
System.Console.WriteLine("Please, Enter your name:");
string name = Console.ReadLine();
System.Console.WriteLine($"Hello, {name}!");
System.Console.WriteLine("Please, Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{age} is nice age!");

string message = age >= 0 
        ? "age is positive!!!"
        : "age is negative!!!";
System.Console.WriteLine(message);

int keschaAge = 12;
System.Console.WriteLine("Age diffenece is " + (age - keschaAge));

message = age >= keschaAge 
        ? "You are older than or equal to KESCHA"
        : "You are younger than KESCHA";
System.Console.WriteLine(message)

if(age - keschaAge >= 0 || age <= 0){
    System.Console.WriteLine("Your age is less than KESCHA's age but positive.");
}
// System.Console.WriteLine("You are older than KASCHA " + (age > keschaAge));
// System.Console.WriteLine("You are younger than KASCHA " + (age < keschaAge));
// System.Console.WriteLine("You are older than equal to KASCHA " + (age >= keschaAge));
// System.Console.WriteLine("You are younger than equal to KASCHA " + (age <= keschaAge));
// System.Console.WriteLine("You are as old as KASCHA " + (age == keschaAge));
// System.Console.WriteLine("You are not as same age as KASCHA " + (age != keschaAge));

