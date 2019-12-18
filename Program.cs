using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Masters__Praktika_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            HiAdventurer("Hello Adventurer, What is your Name?");
            PlayOrNot("Would you like to play?");

            //Patikrinimui ar tesiam nuotyki.
            Console.WriteLine("Adventure begins");
            Console.ReadLine();
        }
        private static void HiAdventurer(string greeting)
        {
            Console.WriteLine(greeting);
            string adventurerName = Console.ReadLine();
            Console.WriteLine($"Hello {adventurerName}.");

        }
        private static void PlayOrNot(string question)
        {
            Console.WriteLine($"{question} Y / N?");
            var answer = Convert.ToChar(Console.ReadLine());
            switch (answer)
            {
                case 'Y':
                    break;
                case 'y':
                    break;
                case 'n':
                    ProgramExit();
                    break;
                case 'N':
                    ProgramExit();
                    break;
                default:
                    PlayOrNot("You type something wrong, Would you like to continue?");
                    break;
            }
        }
        private static void ProgramExit()
        {
            Environment.Exit(0);
        }
    }
}