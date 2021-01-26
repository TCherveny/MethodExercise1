using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------Exercise 1----------------------------------------
            //Name: Michael
            //Favorite Color: Blue
            //Favorite Animal: Walrus
            //Favorite Band: The Beatles

            Console.WriteLine("Hello, What is your first name?");
            var userFirstName = Console.ReadLine();

            Console.WriteLine($"{userFirstName} I would like to write a short story about you. Would you mind answering a few quick question?");
            var userReply = Console.ReadLine();

            Console.WriteLine($"What is your last name {userFirstName}? ");
            var userLastName = Console.ReadLine();

            Console.WriteLine($"{userFirstName} Do you prefer his or her?");
            var proNoun1 = Console.ReadLine();

            Console.WriteLine($"{userFirstName} Do you prefer fella or stella?");
            var proNoun2 = Console.ReadLine();

            Console.WriteLine($"What is your favorite color {userFirstName}?");
            var color = Console.ReadLine();

            Console.WriteLine($"What kind of pet do you have {userFirstName}?");
            var pet = Console.ReadLine();

            Console.WriteLine($"What is your pets name {userFirstName}?");
            var petName = Console.ReadLine();

            Console.WriteLine($"What is your favorite song {userFirstName}?");
            var song = Console.ReadLine();

            Console.WriteLine($"Finally {userFirstName}, what is your favorite car?");
            var car = Console.ReadLine();

            Console.WriteLine($"There is a {proNoun2} named {userFirstName}");
            Console.WriteLine($"{proNoun1} last name is {userLastName} and some say that is quite odd");
            Console.WriteLine($"{userFirstName} has a {pet} named {petName} It is said {userFirstName} and {petName} are like two peas in a pod");
            Console.WriteLine($"{petName} likes to ride shotgun while {userFirstName} drives his drop top {car} ");
            Console.WriteLine($"And all the while they jammin {song}");
            Console.WriteLine($"When {userFirstName} was asked permission to write this non rhyming no sensical giberish they simply said {userReply}");
            Console.WriteLine("even though they knew it was being written by a bafoon!!!");
            Console.WriteLine("How was that "+ userFirstName +" good or bad?");
            Console.ReadLine("good");














        }
    }
}
