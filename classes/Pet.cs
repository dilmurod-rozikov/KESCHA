using System;


namespace KESCHA.classes
{
    public class Pet :  Animal
    {
        public Pet(string name) : base(name) { }
        public void MakeSound(){
            string type = AnimalType();
            System.Console.WriteLine($"{type} makes sound like: ");
            if( type == "dog" || type == "Dog")
            {
                Console.WriteLine("wow wov voooow");
            }else if(type == "cat" || type == "Cat")
            {
                Console.WriteLine("Meow meowwwwww.");
            }else{
                Console.WriteLine("No sound..");
            }
        }

        public override void Greet(string name)
        {
            System.Console.WriteLine($"hello {name} insdie pet class");
        }
    }
}