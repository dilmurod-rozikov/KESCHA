
namespace KESCHA.classes
{
    public class Animal : Person
    {
        public Animal(string name) : base(name)
        {
            CreatedDate = DateTimeOffset.Now;
        }

        public override void AbstractExample()
        {
            System.Console.WriteLine("Abstract method example..");
        }

        public string AnimalType(){
            Console.WriteLine("Do you want a dog or a cat? ");
            string type = Console.ReadLine();
            return type;
        }

        public override void Greet(string name)
        {
            
            if(name == "")
                name = "unknown Person..";

            Console.WriteLine($"Hello, {name}!");
        }
    }
}