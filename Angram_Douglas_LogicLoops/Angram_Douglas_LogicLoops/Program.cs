using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angram_Douglas_LogicLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Douglas T. Angram
             10/5/2016
             Logic and Loops*/

            //PROBLEM #1: LOGICAL OPERATORS: TIRE PRESSURE 1

            //Declare array for tire pressure
            int[] tirePressure = new int[4];

            //Define the array.
            tirePressure[0] = 34;
            tirePressure[1] = 34;
            tirePressure[2] = 32;
            tirePressure[3] = 32;

            //Prompt the user to enter the tire pressure for the front left tire.
            Console.WriteLine("Please enter the tire pressure for the front left tire then press enter.");

            //Allow the user to type their response.
            string inputFL = Console.ReadLine();

            //Declare a variable to hold the converted value.
            int newInputFL;

            //Check to see if the user left the iput blank.
            while(string.IsNullOrWhiteSpace(inputFL))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("\r\nDo not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputFL = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a number.
            while(!int.TryParse(inputFL, out newInputFL))
            {
                //Tell the user to type enter a number.
                Console.WriteLine("\r\nYou have typed something other than a number.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputFL = Console.ReadLine();
            }

            //Prompt the user to enter the tire pressure for the front right tire.
            Console.WriteLine("\r\nPlease enter the tire pressure for the front right tire then press enter.");

            //Allow the user to type their response.
            string inputFR = Console.ReadLine();

            //Declare a variable to hold the converted value.
            int newInputFR;

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(inputFR))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("\r\nDo not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputFR = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a number.
            while (!int.TryParse(inputFR, out newInputFR))
            {
                //Tell the user to type enter a number.
                Console.WriteLine("\r\nYou have typed something other than a number.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputFR = Console.ReadLine();
            }

            //Prompt the user to enter the tire pressure for the rear left tire.
            Console.WriteLine("\r\nPlease enter the tire pressure for the rear left tire then press enter.");

            //Allow the user to type their response.
            string inputRL = Console.ReadLine();

            //Declare a variable to hold the converted value.
            int newInputRL;

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(inputRL))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("\r\nDo not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputRL = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a number.
            while (!int.TryParse(inputRL, out newInputRL))
            {
                //Tell the user to type enter a number.
                Console.WriteLine("\r\nYou have typed something other than a number.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputRL = Console.ReadLine();
            }

            //Prompt the user to enter the tire pressure for the rear right tire.
            Console.WriteLine("\r\nPlease enter the tire pressure for the rear right tire then press enter.");

            //Allow the user to type their response.
            string inputRR = Console.ReadLine();

            //Convert the string into an interger.
            int newInputRR;

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(inputRR))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("\r\nDo not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputRR = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a number.
            while (!int.TryParse(inputRR, out newInputRR))
            {
                //Tell the user to type enter a number.
                Console.WriteLine("\r\nYou have typed something other than a number.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputRR = Console.ReadLine();
            }

            //Create a condition to test the tire pressure.
            if(newInputFL == tirePressure[0] && newInputFR == tirePressure[1] && newInputRL == tirePressure[2] && newInputRR == tirePressure[3])
            {
                //Display to the user that the tires pass spec.
                Console.WriteLine("\r\nThe tires pass spec!");
            }

            //Create an else to catch the tire spec if it doesn't pass.
            else
            {
                //Display to the user that the tires need to be checked.
                Console.WriteLine("\r\nGet your tires checked out!");
            }

            /*Test:
             Front Left - 34, Front Right - 34, Rear Left - 32, Rear Right - 32  The tires pass spec!
             Front Left - 33, Front Right - 35, Rear Left - 32, Rear Right - 30  Get your tires checked out!
             */

            //-----------------


            //PROBLEM #2: LOGICAL OPERATORS: MOVIE TICKET PRICE

            //Create a decimal varible
            decimal priceOne = 12m;
            decimal priceTwo = 7m;

            //Prompt the user to enter their age.
            Console.WriteLine("\r\nPlease type your age then press enter.");

            //Allow the user to input their age.
            string inputAge = Console.ReadLine();

            //Convert the string into an interger.
            int newAge;

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(inputAge))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("\r\nDo not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputAge = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a number.
            while (!int.TryParse(inputAge, out newAge))
            {
                //Tell the user to type enter a number.
                Console.WriteLine("\r\nYou have typed something other than a number.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputAge = Console.ReadLine();
            }

            //Prompt the user to enter the time they want to see the movie.
            Console.WriteLine("\r\nPlease type the time you want to see the movie then press enter.");

            //Allow the user to input the time.
            string inputTime = Console.ReadLine();

            //Convert the string into an interger.
            int newTime;

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(inputTime))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("\r\nDo not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputTime = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a number.
            while (!int.TryParse(inputTime, out newTime) || newTime > 24)
            {
                //Tell the user to type enter a number.
                Console.WriteLine("\r\nYou have typed something other than a number or a number larger than 24.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputTime = Console.ReadLine();
            }

            //Create conditional with logical operators to test the users age and time they want to see the movie.
            if(newAge >= 55 || newAge <= 10 || newTime >= 14 && newTime <= 17)
            {
                //Display the price to the user.
                Console.WriteLine("\r\nThe ticket price is $" + priceTwo + ".");
            }

            //Use else if the if statement fails.
            else
            {
                //Display the price to the user.
                Console.WriteLine("\r\nThe ticket price is $" + priceOne + ".");
            }

            /*Test:
              Age-34, Time-20, Ticket Price - $12.
              Age-11, Time-16, Ticket Price - $7.
             */

            //-----------------


            //PROBLEM #3: FOR LOOP: ADD UP THE ODDS OR EVENS

            //Declare an array with eight intergers
            int[] intArray = new int[7] {31, 42, 53, 64, 75, 86, 97};

            //Create string variables for odd and even.
            string odd = "odd";
            string even = "even";

            //Prompt user to see the sum of the odd or even numbers.
            Console.WriteLine("\r\nType odd to see the sum of the odd numbers or type even to see the sum of the even numbers.");

            //Allow the user to respond.
            string inputNew = Console.ReadLine();

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(inputNew))
            {
                //Tell the user to not leave blank and to type odd or even.
                Console.WriteLine("Do not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputNew = Console.ReadLine();
            }

            //Declare an interger and assign it to 0;
            int totalOdd = 0;

            //Write a for loop to loop throught the array
            for(int i = 0; i < intArray.Length; i++)
            {
                //Write a condition to test if the user typed odd or even.
                if (inputNew == odd)
                {
                    //Create a nested conditional to pick out the odd numbers.
                    if(intArray[i] % 2 == 1)
                    {
                        //Add the totalOdd and intArray.
                        totalOdd = totalOdd + intArray[i];

                        //Display the results to the user.
                        Console.WriteLine("\r\nThe sum of the odd numbers is " + totalOdd);
                    }
                }

                //Write a condition to test if the user typed odd or even.
                if (inputNew == even)
                {
                    //Create a nested conditional to pick out the odd numbers.
                    if (intArray[i] % 2 == 0)
                    {
                        //Add the totalOdd and intArray.
                        totalOdd = totalOdd + intArray[i];

                        //Display the results to the user.
                        Console.WriteLine("\r\nThe sum of the even numbers is " + totalOdd);
                    }
                }
            }

            /*Test:
              If the user types the word "odd", the response will be, "The odd numbers is 256."
              If the user types the word "odd", the response will be, "The odd numbers is 192."
             */

            //-----------------


            //PROBLEM #4: WHILE LOOP: CHARGE IT!

            //Prompt the user to enter their credit limit
            Console.WriteLine("\r\nPlease enter your max line of credit then press enter.");

            //Allow the user to enter the amount
            string inputMax = Console.ReadLine();

            //Convert string into decimal
            decimal newInputMax;

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(inputMax))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("\r\nDo not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputMax = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a number.
            while (!decimal.TryParse(inputMax, out newInputMax))
            {
                //Tell the user to type enter a number.
                Console.WriteLine("\r\nYou have typed something other than a number.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputMax = Console.ReadLine();
            }

            //Prompt the user to enter their credit limit
            Console.WriteLine("\r\nPlease enter your purchase amount then press enter.");

            //Allow the user to enter the amount
            string inputPurchase = Console.ReadLine();

            //Create a variable to hold the purchase
            decimal purchase;

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(inputPurchase))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("\r\nDo not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputPurchase = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a number.
            while (!decimal.TryParse(inputPurchase, out purchase))
            {
                //Tell the user to type enter a number.
                Console.WriteLine("\r\nYou have typed something other than a number.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputPurchase = Console.ReadLine();
            }

            //Subtract the new purchase amount from the new max total.
            decimal newTotalMax = (newInputMax - purchase);

            //Create a while loop to continue looping until the user goes over their limit.
            while (newTotalMax > purchase)
            {
               //Alert the user of their new balance.
                Console.WriteLine("\r\nFrom your current purchase of $" + purchase + " you can still spend $" + newTotalMax + ".");

                newTotalMax -= purchase;
            }

            //Alert the user of their new balance.
            Console.WriteLine("\r\nFrom your most recent purchase you have exceeded your limit by $" + newTotalMax + ".");

            /*Test:
         User enters $20.
         From your current purchase of $4 you can still spend $16.*/
        }
    }
}
