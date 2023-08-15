
namespace KESCHA.classes
{
    public class Animal : Person
    {
        public Animal(string name) : base(name)
        {}
        
        public string AnimalType(){
            Console.WriteLine("Do you want a dog or a cat? ");
            string type = Console.ReadLine();
            return type;
        }
    }
}