using System;
using KESCHA.Enums;

namespace KESCHA.classes
{
    public class Pet :  Animal
    {
        public Pet(string name) : base(name) { 
            CreatedDate = DateTime.Now;
        }
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
        public PetTypes Type { get; set; }

        public override void Greet(string name)
        {
            Console.WriteLine($"hello {name} inside pet class");
        }
    }
}