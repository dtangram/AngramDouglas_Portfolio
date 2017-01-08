using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angram_Douglas_CustomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Douglas T. Angram
             11/15/16
             Custom Class*/

            //Instantiate the constructor method.
            AnimalShelter numberOfDogs = new AnimalShelter(50, 0, 0);

            //Invoke the custom method and pass its arguments.
            animalCount(numberOfDogs.GetMaxNumber(), numberOfDogs.GetLowestNumber(), numberOfDogs.GetCurrentNumber());
        }

        //Create a validate method to hold all of the validations.
        public static int validate(string validateInput)
        {
            //Declare a variable to hold the converted value.
            int validInput;

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(validateInput))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("\r\nDo not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                validateInput = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a number.
            while (!int.TryParse(validateInput, out validInput))
            {
                //Tell the user to type enter a number.
                Console.WriteLine("\r\nYou have typed something other than a number.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                validateInput = Console.ReadLine();
            }

            //Return the variable.
            return validInput;
        }

        //Create a cusotm method to count the amount of dogs the user can add to the animal shelter.
        public static int animalCount(int max, int minimal, int current)
        {
            //Create a variable to count the number of times the loop runs.
            int counter = 0;

            //Create a while loop to continuously loop until the conditon is false.
            while (counter <= 5)
            {
                //Prompt the user to enter an amount of dogs to add to the shelter.
                Console.WriteLine("\r\nThe shelter's capacity for dogs is {0}.\r\nPlease type the number of dogs you want to add to the shelter then press enter.", max);

                //Allow the user to type their response.
                string inputAmount = Console.ReadLine();

                //Validate user input.
                int dogAmount = validate(inputAmount);

                //Add the current amount to the amount entered and assign the value back to the current amount.
                current += dogAmount;

                //Create a variable to hold the value produced by subtracting the current amount from the max amount.
                int increase = max - current;

                //Create a conditional using the logical operator && to test if the current amount is less than the max and the current amount is greater than the minimal amount.
                if (current < max && current > minimal)
                {
                    if (counter == 5)
                    {
                        //Display to the user that they are no longer able to add or remove dogs at this time.
                        Console.WriteLine("\r\nYou have changed the amount of dog(s) by " + dogAmount + ", but you have reached your limit of adding and removing dogs.\r\nPlease resume at a later date.");

                        //Break out of the loop if the loop has run 5 times.
                        break;
                    }

                    //Display to the user the amount of dogs they are able to add.
                    Console.WriteLine("\r\nYou can still add {0} dog(s) to the shelter.", increase);

                    //Validate user input.
                    dogAmount = validate(inputAmount);
                }

                //Create an else if condition to test if the current and max amounts are equal.
                else if (current == max)
                {
                    //Display to the user that the shelter is at capacity.
                    Console.WriteLine("\r\nThe shelter is at capacity for dogs.");
                }

                //Create an else if condition to test if the decreased amount is less than the amount entered.
                else if (current < minimal)
                {
                    current -= dogAmount;
                    //Display to the user that the number they entered is less than the minimal amount.
                    Console.WriteLine("\r\nThe number you entered is less than the minimal amount.");

                    //Validate user input.
                    dogAmount = validate(inputAmount);
                }

                //Create a while loop to continuously loop until the conditon is false.
                while (current > max)
                {
                    //Create a variable to hold the value produced by subtracting the max amount from the current amount.
                    int decrease = current - max;

                    if (counter == 5)
                    {
                        //Display to the user that they are no longer able to add or remove dogs at this time.
                        Console.WriteLine("\r\nYou have changed the amount of dog(s) by " + dogAmount + ", but you have reached your limit of adding and removing dogs.\r\nPlease resume at a later date.");

                        //Break out of the loop if the loop has run 5 times.
                        break;
                    }

                    //Prompt the user to enter an amount of dogs to add to the shelter.
                    Console.WriteLine("\r\nPlease decrease the amount of dogs by {0}.", decrease);

                    //Allow the user to type their response.
                    inputAmount = Console.ReadLine();

                    //Validate user input.
                    dogAmount = validate(inputAmount);

                    //Subtract the current amount to the amount entered and assign the value back to the current amount.
                    current -= dogAmount;

                    //Create a conditional using the logical operator && to test if the current amount is less than the max, the current amount is greater than the minimal amount and the decreased amount is less than the amount entered.
                    if (current < max && current > minimal && decrease > dogAmount)
                    {
                        if (counter == 5)
                        {
                            //Display to the user that they are no longer able to add or remove dogs at this time.
                            Console.WriteLine("\r\nYou have changed the amount of dog(s) by " + dogAmount + ", but you have reached your limit of adding and removing dogs.\r\nPlease resume at a later date.");

                            //Break out of the loop if the loop has run 5 times.
                            break;
                        }

                        //Add the current amount to the amount entered and assign the value back to the current amount.
                        current += dogAmount;

                        //Display to the user the amount of dogs they are able to add.
                        Console.WriteLine("\r\nYou can still add {0} dog(s) to the shelter.", increase);

                        //Validate user input.
                        dogAmount = validate(inputAmount);
                    }

                    //Create an else if condition to test if the current and max amounts are equal.
                    else if (current == max)
                    {
                        //Display to the user that the shelter is at capacity.
                        Console.WriteLine("\r\nThe shelter is at capacity for dogs.");
                    }

                    //Create an else if condition to test if the decreased amount is less than the amount entered.
                    else if (decrease < dogAmount)
                    {
                        if (counter == 5)
                        {
                            //Display to the user that they are no longer able to add or remove dogs at this time.
                            Console.WriteLine("\r\nYou have changed the amount of dog(s) by " + dogAmount + ", but you have reached your limit of adding and removing dogs.\r\nPlease resume at a later date.");

                            //Break out of the loop if the loop has run 5 times.
                            break;
                        }

                        //Subtract the decreased amount from the amount entered and assign the value to the increased amount.
                        increase = dogAmount - decrease;

                        //Display to the user the amount of dogs they are able to add.
                        Console.WriteLine("\r\nYou can still add {0} dog(s) to the shelter.", increase);

                        //Validate user input.
                        dogAmount = validate(inputAmount);
                    }
                }

                //Increment the counter by one.
                counter++;
            }

            //Return the variable.
            return current;
        }
    }
}
