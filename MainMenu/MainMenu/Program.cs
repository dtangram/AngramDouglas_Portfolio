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
            Console.WriteLine("Typing the number of the of the menu item you want and pressing enter.\r\n1. SwapName  2. Backwards  3. AgeConvert  4. TempConvert\r\n");

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

                        //Create case to store the code for the menu item.
                        case 2:
                            //Prompt the user to type a sentence.
                            Console.WriteLine("\r\nEnter a sentence using only 6 words.");

                            //Invoke the method and pass in the arguments.
                            Backwards();

                            //Break out of the case when complete.
                            break;

                        //Create case to store the code for the menu item.
                        case 3:
                            //Prompt the user to type their name.
                            Console.WriteLine("\r\nType your name then press enter.");

                            //Prompt the user to type a sentence.
                            string inputName = Console.ReadLine();

                            //Validate the user input.
                            string nameInput = validateString(inputName);

                            //Prompt the user to type their name.
                            Console.WriteLine("\r\nType your age then press enter.");

                            //Prompt the user to type a sentence.
                            string inputAge = Console.ReadLine();

                            //Validate the user input.
                            decimal ageInput = validate(inputAge);

                            //Invoke the method and pass in the arguments.
                            AgeConvert(nameInput, ageInput);

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
                Console.WriteLine("\r\nPlease do not leave blank.\r\n");

                //Allow the user to type their response.
                validateInput = Console.ReadLine();
            }

            //Return the variable validateInput.
            return validateInput;
        }

        //Create a validate method to hold the validations for numbers.
        public static decimal validate(string validateInput)
        {
            //Declare a variable to hold the converted value.
            decimal validInput;

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(validateInput))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("\r\nDo not leave blank.\r\nPlease type a number then press enter.\r\n");

                //Allow the user to type their response.
                validateInput = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a number.
            while (!decimal.TryParse(validateInput, out validInput))
            {
                //Tell the user to type enter a number.
                Console.WriteLine("\r\nYou have typed something other than a number.\r\nPlease type a number then press enter.\r\n");

                //Allow the user to type their response.
                validateInput = Console.ReadLine();
            }

            //Return the variable validInput.
            return validInput;
        }

        //Create SwapName method.
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

        //Create Backwards method.
        public static void Backwards()
        {
            //Assign the variable to a string literal.
            string sentence = "";

            //Assign the variable to a string literal.
            string revSentence = "";

            //Allow the user to type their response.
            sentence = Console.ReadLine();

            //Create while loop to check if nothing is entered.
            while (string.IsNullOrWhiteSpace(sentence))
            {
                //Inform user to not leave the input blank.
                Console.WriteLine("\r\nPlease do not leave blank.\r\n");

                //Allow the user to type their response.
                sentence = Console.ReadLine();
            }

            //Create while loop to check if there are more than six words in the sentence.
            while (sentence.IndexOf(" ") >= 6)
            {
                //inform the user that they typed more than 6 words.
                Console.WriteLine("\r\nYou must have 6 words in your sentence.\r\n");

                //Allow the user to type their response.
                sentence = Console.ReadLine();
            }

            //Create a for loop to reverse user input.
            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                //Increment both string literals.
                revSentence += sentence[i];
            }

            //Display the reversed sentence.
            Console.Write(revSentence + "\r\n");
        }

        //Create AgeConvert method.
        public static decimal AgeConvert(string name, decimal age)
        {
			//Create variables to hold the values of the year, day, hour, minute, second and leap year.
            decimal numDays;
            decimal numHours;
            decimal numMinutes;
            decimal numSeconds;
			decimal yearBorn;
			DateTime dt = DateTime.Now;
			decimal numLeapYear;
			decimal newNumLeap;
			decimal numDaysLeap;
			decimal numHoursLeap;
			decimal numMinutesLeap;
			decimal numSecondsLeap;

			//Calculate the year the user was born.
			yearBorn = dt.Year - age;

			//Calculate the number of days the users has lived.
			numDays = age * 365;

			//Calculate the number of hours the users has lived.
			numHours = age * 365 * 24;

			//Calculate the number of minutes the users has lived.
			numMinutes = age * 365 * 24 * 60;

			//Calculate the number of seconds the users has lived.
			numSeconds = age * 365 * 24 * 60 * 60;

			//Calculate the number of leap years the users has lived.
			numLeapYear = (age + 1) / 4;

			//Round up the number of leap years.
			newNumLeap = Math.Ceiling(numLeapYear);

			//Calculate the number of days the users has lived including leap year.
			numDaysLeap = numDays + newNumLeap;

			//Calculate the number of hours the users has lived including leap year.
			numHoursLeap = numHours + (newNumLeap * 24);

			//Calculate the number of minutes the users has lived including leap year.
			numMinutesLeap = numMinutes + (newNumLeap * 24 * 60);

			//Calculate the number of seconds the users has lived including leap year.
			numSecondsLeap = numSeconds + (newNumLeap * 24 * 60 * 60);

			//Create a variable to hold the string for plural and singular string.
			string addS;

			//Create a variable to hold the leap year string.
			string numLeapString;
			
			//Create an if statement to check if the age of the user is equal to 1.
			if (age == 1)
            {
				//Display the year string if the age is equal to 1.
                addS = "year";
            }

			//Create else statement if age is more than 1.
			else
			{
				//Display the years string if the age is more than 1.
				addS = "years";
			}

			//Create if statement to check if the year the user was born was a leap year.
			if ((yearBorn % 4 == 0 && yearBorn % 100 != 0) || (yearBorn % 400 == 0))
			{
				//If the user was born on a leap year, display the numLeapString.
				numLeapString = ", which was a leap year, ";
			}

			//Create else statement if the year born was not a leap year.
			else
			{
				//If the user wasn't born on a leap year, display an empty string.
				numLeapString = " ";
			}

			//Display the users name, the year born, age, days lived, hours lived, minutes lived and seconds lived.
			Console.WriteLine("\r\n{0}, you were born {1}{2}and you have lived {3} {4}, \r\n{5} days, {6} hours, {7} minutes and {8} seconds.", name, yearBorn, numLeapString, age, addS, numDays, numHours, numMinutes, numSeconds);

			//Display the number of leap years the user has lived and display the new amount of days lived, hours lived, minutes lived and seconds lived.
			Console.WriteLine("\r\nIncluding {0} leap {1}, you've lived {2} days, {3} hours,\r\n{4} minutes and {5} seconds.\r\n", newNumLeap, addS, numDaysLeap, numHoursLeap, numMinutesLeap, numSecondsLeap);
			
			//Return the age parameter.
			return age;
        }
    }
}
