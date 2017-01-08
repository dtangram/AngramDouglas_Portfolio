using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angram_Douglas_MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Douglas T. Angram
             10/31/2016
             MadLibs Style Story Creator
             */

            //Prompt the user to enter their name.
            Console.WriteLine("Please enter your name.");

            //Display what the user typed.
            string story1 = Console.ReadLine();

            //Prompt the user to enter the name of the city and state they grew up in.
            Console.WriteLine("Please enter the city and state where you grew up.");

            //Display what the user typed.
            string story2 = Console.ReadLine();

            //Prompt the user to enter the name of the school they attended.
            Console.WriteLine("Please enter the school you attended.");

            //Display what the user typed.
            string story3 = Console.ReadLine();

            //Prompt the user to enter their favorite subject in school.
            Console.WriteLine("Please enter your favorite subject in school.");

            //Display what the user typed.
            string story4 = Console.ReadLine();

            //Prompt the user to enter the population of the city they grew up in.
            Console.WriteLine("Please enter the population of the city you grew up in.");

            //Display what the user typed.
            string story5 = Console.ReadLine();

            //Convert the string to a numerical datatype.
            double story5Pop = double.Parse(story5);

            //Prompt the user to enter their age.
            Console.WriteLine("Please enter your age when you began liking your favorite subject in school.");

            //Display what the user typed.
            string story6 = Console.ReadLine();

            //Convert the string to a numerical datatype.
            double story6Age = double.Parse(story6);

            //Prompt the user to enter their.
            Console.WriteLine("Please enter the grade you were in when you began liking your favorite subject in school.");

            //Display what the user typed.
            string story7 = Console.ReadLine();

            //Convert the string to a numerical datatype.
            double story7Grade = double.Parse(story7);

            double total = (story5Pop + story6Age + story7Grade) * 10;

            //Prompt the user to enter the population of the city they grew up in.
            Console.WriteLine("Hello, my name is " + story1 + " and I grew up in, " + story2 + ", which had a population of " + story5Pop + ". The high school I attended was called, " + story3 + ", and my favorite subject was " + story4 + ". I was " + story6Age + " at the time and the grade I was in was " + story7Grade + ". I dreamed of making $" + total + " a year doing what I love.");
        }
    }
}
