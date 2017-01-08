using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angram_Douglas_CountFish
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Douglas T. Angram
             10/6/2016
             Count the Fish*/

            //Declare and Define the array
            string[] colors = new string[10] {"red", "blue", "green", "yellow", "blue", "green", "blue", "blue", "red", "green"};

            //Prompt the user to enter a number for the type of fish they want.
            Console.WriteLine("Please type 1 to select a Red fish, 2 for a Blue fish,\r\n3 for a Green fish and 4 for a Yellow fish then press enter.");

            //Allow the user to enter the number.
            string inputNumber = Console.ReadLine();

            //Convert the string into an interger.
            int newInputNumber;

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(inputNumber))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("\r\nDo not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputNumber = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a number.
            while (!int.TryParse(inputNumber, out newInputNumber) || newInputNumber > 4)
            {
                //Tell the user to type enter a number on the list.
                Console.WriteLine("\r\nYou have typed something other than a number or a number that's not on the list.\r\nPlease type a number on the list then press enter.");

                //Allow the user to type their response.
                inputNumber = Console.ReadLine();
            }

            //Create a for loop to loop through the colors
            for (int i = 0; i < colors.Length; i++)
            {
                //Create an if statement to test if the user typed the number one.
                if (newInputNumber == 1)
                {
                    //Create an if statement to test the color the user selected based on the number they chose.
                    if (colors[i] == "red")
                    {
                        //Display the results.
                        Console.WriteLine("\r\nIn the fish tank there are {0} fish of the color " + colors[0] + ".", i);
                    }
                }

                //Create an else if statement to test if the user typed the number two.
                else if (newInputNumber == 2)
                {
                    //Create an if statement to test the color the user selected based on the number they chose.
                    if (colors[i] == "blue")
                    {
                        //Display the results.
                        Console.WriteLine("\r\nIn the fish tank there are {0} fish of the color " + colors[1] + ".", i);
                    }
                }

                //Create an else if statement to test if the user typed the number three.
                else if (newInputNumber == 3)
                {
                    //Create an if statement to test the color the user selected based on the number they chose.
                    if (colors[i] == "green")
                    {
                        //Display the results.
                        Console.WriteLine("\r\nIn the fish tank there are {0} fish of the color " + colors[2] + ".", i);
                    }
                }

                //Create an else if statement to test if the user typed the number four.
                else if (newInputNumber == 4)
                {
                    //Create an if statement to test the color the user selected based on the number they chose.
                    if (colors[i] == "yellow")
                    {
                        //Display the results.
                        Console.WriteLine("\r\nIn the fish tank there are {0} fish of the color " + colors[3] + ".", i);
                    }
                }
            }
        }
    }
}
