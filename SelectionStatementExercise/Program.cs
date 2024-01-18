namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 50);

            Console.WriteLine("Guess my favorite number:");
            var userInput = int.Parse(Console.ReadLine());

            if(userInput < favNumber)
            {
                Console.WriteLine($"Sorry {userInput}, too low.");
            }
            else if(userInput > favNumber)
            {
                Console.WriteLine($"Sorry {userInput}, too high.");
            }
            else
            {
                Console.WriteLine("Awesome, you guessed it!");
            }
            
            Console.WriteLine("What is mi favorite shcool subject");
            
            string userInput2 = Console.ReadLine();
            
            switch (userInput2)
            {
                case "math":
                    Console.WriteLine("I love math");
                    break;
               
                case "science":
                    Console.WriteLine("It's complicated");
                    break;
                
                case "bible":
                    Console.WriteLine("I like history");
                    break;
                
                default:
                    Console.WriteLine($"That interesting");
                    break;

            }
        }

    }
}
