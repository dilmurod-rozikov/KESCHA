//KESCHA Project
System.Console.WriteLine("Please, Enter your name:");
string name = Console.ReadLine();
System.Console.WriteLine($"Hello, {name}!");
System.Console.WriteLine("Please, Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{age} is nice age!");

int keschaAge = 12;
System.Console.WriteLine("Age diffenece is " + (age - keschaAge));

System.Console.WriteLine("You are older than KASCHA " + (age > keschaAge));
System.Console.WriteLine("You are younger than KASCHA " + (age < keschaAge));
System.Console.WriteLine("You are older than equal to KASCHA " + (age >= keschaAge));
System.Console.WriteLine("You are younger than equal to KASCHA " + (age <= keschaAge));
System.Console.WriteLine("You are as old as KASCHA " + (age == keschaAge));
System.Console.WriteLine("You are not as same age as KASCHA " + (age != keschaAge));

