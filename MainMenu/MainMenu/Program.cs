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
            Console.WriteLine("Please choose the menu item you need by typing it and pressing enter.\r\n1. SwapName  2. Backwards  3.AgeConvert  4. TempConvert");

            //Allow the user to enter a value.
            string inputSwapName = Console.ReadLine();

            //Validate user input.
            string swapNameInput = validateString(inputSwapName);

            //Write a condition that will display SwapName.
            if (swapNameInput == SwapNameString)
            {
                //Allow the user to enter their first name.
                string inputFirstName = Console.ReadLine();

                //Allow the user to enter their last name.
                string inputLastName = Console.ReadLine();

                //Invoke the method SwapName.
                SwapName(inputFirstName, inputLastName);                
            }
        }

        //Create a validate method to hold SwapName validations.
        public static string validateString(string validateInput)
        {
            //Create String variables.
            string SwapName = "SwapName";

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(validateInput))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("\r\nDo not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                validateInput = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a menu item.
            while (validateInput != SwapName)
            {
                Console.WriteLine("\r\nPlease choose from the menu items listed.");

                //Allow the user to type their response.
                validateInput = Console.ReadLine();
            }

            //Return the variable validateInput.
            return validateInput;
        }

        //Create a validate method to hold the validations for numbers.
        public static double validate(string validateInput)
        {
            //Create String variables.
            string Backwards = "Backwards";
            string AgeConvert = "AgeConvert";
            string TempConvert = "TempConvert";

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

            //Check to see if the user entered anything other than a number.
            while (validateInput != Backwards || validateInput != AgeConvert || validateInput != TempConvert)
            {
                Console.WriteLine("\r\nPlease choose from the menu items listed.");

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
            Console.WriteLine("\r\nYour last name has been swapped with " + nameLast + ".");

            //Return the variable nameFirst.
            return nameFirst;
        }
    }
}
