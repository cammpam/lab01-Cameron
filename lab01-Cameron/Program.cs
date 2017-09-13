using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_Cameron
{
    class Program
    {

        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine("Enter Name to Start: ");
            string userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Enter Name or Exit Game!");
            }
            else
            {
                Console.WriteLine($"Welcome {userInput}");
            }

            total += Places();
            total += Cars();
            total += Interest();
            Console.WriteLine($"total score: {total}");
            Console.ReadLine();
        }
        static int Places()
        {
            int correct = 0;
            Console.WriteLine("Which ONE of these places have I NOT lived: ");

            string[] placeArray = new string[] { " A - Texas", " B - Washington", " C - Mississippi", " D - Oklahoma", " E - Oregon", " F - Kentucky" };
            foreach(string place in placeArray)
            {         
            Console.WriteLine(place);
            }
            string answerOne = Console.ReadLine().ToUpper();

            try
            {
                    if (answerOne == "d")
                {
                    Console.WriteLine("Correct!");
                    correct = 1;
                }
                if(answerOne == "a" || answerOne == "b" || answerOne == "c")
                {                    
                    Console.WriteLine("Actually, I've never lived in Oklahoma.");                   
                }
                else
                {
                    throw new Exception();                 
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("INVALID INPUT!" + e.Message);
            }
            finally
            {
                Console.Write("**exit**");
            }
            return correct;

        }
        static int Cars()
        {
            Console.WriteLine("What is the 3rd vehicle I Owned?");
            string[] carArray = new string[] { " A - Monte Carlo", " B - Malibu", " C - Grand Prix", " D - Passat", " E - Fiesta" };
            foreach(string car in carArray)
            {
                Console.WriteLine(car);
            }
            string answerTwo = Console.ReadLine();
            if (answerTwo == "c" || answerTwo == "C")
            {
                Console.WriteLine("Correct!");
                return 1;
            }
            else
            {
                Console.WriteLine("Nope! My 3rd vehicle was a Grand Prix");
                return 0;

            }
        }
        static int Interest()
        {
            int attempts = 3;
            int correct = 0;
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("What am I interested in: SELECT 3");
                Console.WriteLine($"Attempt: {attempts}/3");
                string[] interestArray = new string[] { " A - Music", " B - Finances", " C - Business", " D - Politics"};
                foreach(string hobby in interestArray)
                {
                    Console.WriteLine(hobby);
                }
                string input = Console.ReadLine().ToUpper();
 
                if (input == "ABC" || input == "ACB" || input == "BAC" || input == "BCA" || input == "CAB" || input == "CBA")
                {
                    Console.WriteLine("You are Correct! Thanks for Playing.");
                    correct = 1;
                    break;
                }
                else
                {
                        attempts--;
                }
            }
            return correct;
        }
    }
}
