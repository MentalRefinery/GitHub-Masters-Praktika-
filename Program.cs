using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace GitHub_Masters__Praktika_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            HiAdventurer("Hello Adventurer, What is your Name?");
            PlayOrNot("Would you like to play?");

            //Adventure checkpoint.
            Console.WriteLine("Adventure begins");

            //Wont have to change format if I change the name of classes.
            Question($"Would you like to play { nameof(Mage)}, { nameof(Warrior)}, { nameof(Rogue)} or { nameof(Warlock)}?");
            ChooseHero();          
            
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
        private static void Question(string txt)
        {
            //Need to fiddle with delegates soon.
            Console.WriteLine(txt);
        }
        private static void ChooseHero()
        {
            string answer = Console.ReadLine();

            //Formating answer to lower
            answer.ToLower();
            //Changing class name to Title Case.
            answer = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(answer);
            
            if (answer == typeof(Mage).Name)
            {                
                Console.WriteLine("You have chosen a " + answer);                
                Mage chosenHero = new Mage();
            }
            else if (answer == typeof(Warrior).Name)
            {               
                Console.WriteLine("You have chosen a " + answer);               
                Warrior chosenHero = new Warrior();
            }
            else if (answer == typeof(Rogue).Name)
            {                
                Console.WriteLine("You have chosen a " + answer);                
                Rogue chosenHero = new Rogue();
            }
            else if (answer == typeof(Warlock).Name)
            {                
                Console.WriteLine("You have chosen a " + answer);                
                Warlock chosenHero = new Warlock();
            }
            else
            {
                Question($"Please try again... \nWould you like to play {nameof(Mage)}, {nameof(Warrior)}, {nameof(Rogue)} or {nameof(Warlock)}?");
            }                       
        }

        //Exit method, security reasons, so I am used to call Exit method if I want to terminate my program.
        private static void ProgramExit()
        {
            Environment.Exit(0);
        }
    }
}