using System;

namespace CG3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to guess a number between 1 and 10. 
            Console.WriteLine("Win or Lose, only one number WINS! Good Luck!");
            Console.WriteLine("Please enter a number from 1 to 10 to see if you win or lose!");
            string userValue = Console.ReadLine();

            //If they input 8, output to the console You Win. If a number other than 8 is entered output You Lose.
            string message = (userValue == "8") ? "You WIN!" : "You Lose";


            Console.WriteLine("You entered: {0}, therefore you {1}", userValue, message);

            //I am not sure how to write an invalid message if the user inputs a number other than 1 through 10.
            Console.ReadLine();




        }
    }
}
