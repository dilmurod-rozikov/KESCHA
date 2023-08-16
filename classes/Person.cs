namespace KESCHA.classes
{
    public abstract class Person
    {
        public string name;
        private string message;
        private int age;
        private int keschaAge = 12;

        public Person(string name)
        {
            this.name = name;
        }
        public virtual void Greet(string name)
        {
            if(name == "")
                name = "unknown Person..";

            Console.WriteLine($"Hello, {name}!");
        }
        public void GetAge()
        {
            Console.WriteLine("Please, Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{age} is nice age!");
            
            string message = age >= 0 
                ? "age is positive!!!"
                : "age is negative!!!";
            Console.WriteLine(message);
        }
        public void AgeDifference()
        {
            Console.WriteLine("Age diffenece is " + (age - keschaAge));
        }
        public void WhoIsOlder()
        {
            message = age >= keschaAge 
                ? "You are older than or equal to KESCHA"
                : "You are younger than KESCHA";
            Console.WriteLine(message);
        }
        public string GuessAge()
        {
            try
            {
                Console.WriteLine("Lets play a game buddy. \nGuess Kescha's age: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                while(guess != keschaAge)
                {
                    if(count > 5){
                        Console.WriteLine("Don't be sad, his age is " + keschaAge);
                        break;
                    }
                    count++;
                    Console.WriteLine("Come on, It is simple math!!! \nGuess again: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("Error is handled..");
            }

            return "Well done bro!!!";
        }
        public abstract void AbstractExample();
    }

}