using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create String variables.
            string SwapNameString = "SwapName";
            string BackwardsString = "Backwards";
            string AgeConvertString = "AgeConvert";
            string TempConvertString = "TempConvert";

            //Display the menu and prompt the user to enter the menu item they want to use.
            Console.WriteLine("Typing the number of the of the menu item you want and pressing enter.\r\n1. SwapName  2. Backwards  3.AgeConvert  4. TempConvert\r\n");

            //Assign int variable to 4.
            const int menuItems = 4;

            //Assign int variable to 0.
            int selectItem = 0;

            //Assign the boolean variable to false.
            bool items = false;

            //Create a while loop to loop through the menu items.
            while (selectItem != menuItems)
            {
                //Convert the boolean to an int and assign it to selectItem.
                items = int.TryParse(Console.ReadLine(), out selectItem);

                //Create an if statement to check if an item is true or false.
                if (items)
                {
                    //Create a switch to check if an item is true or false.
                    switch (selectItem)
                    {
                        //Create case to store the code for the menu item.
                        case 1:

                            //Prompt the user to type their first name.
                            Console.WriteLine("\r\nEnter your first name.");

                            //Allow the user to enter their first name.
                            string inputFirstName = Console.ReadLine();

                            //Validate the user input.
                            string firstInput = validateString(inputFirstName);

                            //Prompt the user to type their first name.
                            Console.WriteLine("\r\nEnter your last name.");

                            //Allow the user to enter their last name.
                            string inputLastName = Console.ReadLine();

                            //Validate the user input.
                            string lastInput = validateString(inputLastName);

                            //Invoke the method and pass in the arguments.
                            SwapName(firstInput, lastInput);

                            //Break out of the case when complete.
                            break;

                        case 2:
                            //Create case to store the code for the menu item.
                            Console.WriteLine("\r\nEnter a sentence using only 6 words.");

                            //Prompt the user to type a sentence.
                            string inputSentence = Console.ReadLine();

                            //Validate the user input.
                            string sentenceInput = validateString(inputSentence);

                            //Invoke the method and pass in the arguments.
                                Backwards(sentenceInput);

                            //Break out of the case when complete.
                            break;
                    }
                }
            }
        }        

        //Create a validate method to hold SwapName validations.
        public static string validateString(string validateInput)
        {
            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(validateInput))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("\r\nDo not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                validateInput = Console.ReadLine();
            }

            //Return the variable validateInput.
            return validateInput;
        }

        //Create a validate method to hold the validations for numbers.
        public static double validate(string validateInput)
        {
            //Declare a variable to hold the converted value.
            double validInput;

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(validateInput))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("\r\nDo not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                validateInput = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a number.
            while (!double.TryParse(validateInput, out validInput))
            {
                //Tell the user to type enter a number.
                Console.WriteLine("\r\nYou have typed something other than a number.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                validateInput = Console.ReadLine();
            }

            //Return the variable validInput.
            return validInput;
        }
        
        //Create a validate method to hold SwapName validations.
        public static string SwapName(string nameFirst, string nameLast)
        {
            //Display the original string.
            Console.WriteLine("\r\nYour name is " + nameFirst + " " + nameLast + ".");

            //Swap the valuse of the variables nameFirst and nameLast.
            //Increment nameFirst with nameLast.
            nameFirst += nameLast;

            //Use dot notation to invoke the Remove method to namefirst then pass in an argument of nameFirst with the IndexOf method which contains the argument nameLast.
            nameLast = nameFirst.Remove(nameFirst.IndexOf(nameLast));

            //Use dot notation to invoke the Substring method to namefirst then pass in an argument of nameLast with the Length method.
            nameFirst = nameFirst.Substring(nameLast.Length);

            //Display nameFirst swapped.
            Console.WriteLine("\r\nYour first name has been swapped with " + nameFirst + ".");

            //Display  nameLast swapped.
            Console.WriteLine("\r\nYour last name has been swapped with " + nameLast + ".\r\n");

            //Return the variable nameFirst.
            return nameFirst;
        }

        //Create a validate method to hold SwapName validations.
        public static string Backwards(string sentence)
        {
            //Assign the variable to a string literal.
            sentence = "";

            //Assign the variable to a string literal.
            string revSentence = "";

            //Allow the user to type their response.
            sentence = Console.ReadLine();

            //Create a for loop to reverse user input.
            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                //Increment both string literals.
                revSentence += sentence[i];
            }

            //Display the reversed sentence.
            Console.Write(revSentence + "\r\n");

            //Return the string variable sentence.
            return sentence;
        }
    }
}
