using System;

namespace MethodsGroup2
{
    class Program
    {
        // Lets send a greeting message to the terminal
        // No return value (output), no arguments (inputs)
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to this group 2 app.");
        }

        //Request the user's name and return the result as a string
        public static string RequestUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name;        // Give back the users name
        }
        
        // Greet a user (name is provided via argument)
        public static void GreetUser(string user)
        {
            Console.WriteLine("Hello " + user);
        }

        // A method that throws a die between min and max
        public static int ThrowDie(int minimum, int maximum)
        {
            Random generator = new Random();
            int number = generator.Next(minimum, maximum+1);
            return number;
        }

        static void Main(string[] args)
        {
            WelcomeMessage();

            string username = RequestUserName();

            GreetUser(username);

            int die = ThrowDie(1, 6);
            Console.WriteLine(die);
        }
    }
}
