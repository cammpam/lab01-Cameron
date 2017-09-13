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
            Console.WriteLine("Which ONE of these places as Cameron NOT lived: ");
            Places();
            Console.Read();
        }
        static void TryAgain()
        {
            for (int i = 0; i < 2; i++);
        }
        static void Places()
        {
            string[] placeArray = new string[] { "TX", "WA", "MS", "OK", "OR", "KY" };
            foreach(string place in placeArray)
            {         
            Console.WriteLine(place);
            }
            string answerOne = Console.ReadLine();
            if (answerOne == "OK")
            {
                Console.WriteLine("Correct! Move to next question");
            }
            if (answerOne != "OK")
            {
                Console.WriteLine("Sorry, Try again.");
                TryAgain();                
            }

        }
    }
}
