using System;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject");
            
            var response = Console.ReadLine();

            switch (response)
            {
                case "Math":
                    Console.WriteLine("Math is hard");
                    break;
                case "English":
                    Console.WriteLine("English is cool");
                    break ;
                case "History":
                    Console.WriteLine("History is a great subject");
                    break;
                case "Science":
                    Console.WriteLine("Science is fun!");
                    break;
                case "P.E.":
                    Console.WriteLine("That is my favorite subject!");
                    break;
                default:
                    Console.WriteLine("I didnt have that class");
                    break;


            }
        }
    }
}
