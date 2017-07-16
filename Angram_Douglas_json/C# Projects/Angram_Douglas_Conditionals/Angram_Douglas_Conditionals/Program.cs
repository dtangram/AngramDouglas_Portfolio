using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angram_Douglas_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Douglas T. Angram
             10/3/2016
             Conditionals*/

            //PROBLEM #1: TEMPERATURE CONVERTER

            //Create String variables for "F" and "C".
            string fahrenheit = "F";
            string lowerF = "f";
            string lowerC = "c";
            string celsius = "C";

            //Prompt the user to type in a temperature in decimal numbers only.
            Console.WriteLine("Type a temperature in Celsius with only numbers and decimals to view the Fahrenheit conversion,\r\nor type a temperature in Fahrenheit to view the Celsius conversion. Press enter when you're done.");

            //Allow the user to type the temperature.
            string inputTemp = Console.ReadLine();

            //Convert the string to a number. Use the double datatype to allow decimal numbers.
            double inputConvret;

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(inputTemp))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("Do not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputTemp = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a number.
            while (!double.TryParse(inputTemp, out inputConvret))
            {
                //Tell the user to type enter a number.
                Console.WriteLine("\r\nYou have typed something other than a number.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputTemp = Console.ReadLine();
            }

            //Prompt the user to type in an "F" for Fahrenheit or a "C" for Celsius.
            Console.WriteLine("\r\nType lower case or uppercase '" + celsius + "' for Celsius, or type lower case or uppercase '" + fahrenheit + "' for Fahrenheit, then press enter.");

            //Allow the user to type "F" or "C".
            string tempBool = Console.ReadLine();

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(tempBool))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("Do not leave blank.\r\nPlease type a \"C\" or an \"F\" then press enter.");

                //Allow the user to type their response.
                tempBool = Console.ReadLine();
            }

            //Convert from Fahrenheit to Celsius. 
            double fahrenConvert = (inputConvret - 32) * 5 / 9;

            //Convert from Celsius to Fahrenheit.
            double celsConvert = (inputConvret * 9 / 5) + 32;

            //Write a condition using the logical operator "or" that will display the conversion of Celsius to Fahrenheit it the user types "C" or "c".
            if (tempBool == celsius || tempBool == lowerC)
            {
                //Display the results.
                Console.WriteLine("\r\nThe temperature is " + celsConvert + " degrees Fahrenheit.");
            }

            //Write a condition using the logical operator "or" that will display the conversion of Fahrenheit to Celsius it the user types "F" or "f".
            else if (tempBool == fahrenheit || tempBool == lowerF)
            {
                //Display the results.
                Console.WriteLine("\r\nThe temperature is " + fahrenConvert + " degrees Celsius.");
            }
            //-----------------


            //PROBLEM #2: LAST CHANCE FOR GAS

            //Prompt the user to enter the amount of gas their vehicle holds.
            Console.WriteLine("\r\nEnter the amount of gallons your car tank holds then press enter.");

            //Allow the user to enter the amount.
            string gallAmt = Console.ReadLine();

            //Convert the string into a number.
            double inputGall;

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(gallAmt))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("Do not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                gallAmt = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a number.
            while (!double.TryParse(gallAmt, out inputGall))
            {
                //Tell the user to type enter a number.
                Console.WriteLine("\r\nYou have typed something other than a number.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                gallAmt = Console.ReadLine();
            }

            //Prompt the user to enter the amount of gas in their tank.
            Console.WriteLine("\r\nHow full is your gas tank? Enter the percentage. Type only the number and not the percent sign then press enter.");

            //Allow the user to enter the amount.
            string tankAmt = Console.ReadLine();

            //Convert the string into a number.
            double inputTank;

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(tankAmt))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("Do not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                tankAmt = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a number.
            while (!double.TryParse(tankAmt, out inputTank))
            {
                //Tell the user to type enter a number.
                Console.WriteLine("\r\nYou have typed something other than a number.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                tankAmt = Console.ReadLine();
            }

            //Prompt the user to enter the miles per gallon their car can get.
            Console.WriteLine("\r\nEnter the miles per gallon your car can go. Type only numbers then press enter.");

            //Allow the user to enter the amount.
            string mpgAmt = Console.ReadLine();

            //Convert the string into a number.
            double inputMPG;

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(mpgAmt))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("Do not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                mpgAmt = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a number.
            while (!double.TryParse(mpgAmt, out inputMPG))
            {
                //Tell the user to type enter a number.
                Console.WriteLine("\r\nYou have typed something other than a number.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                mpgAmt = Console.ReadLine();
            }

            //Calculate to find the number of miles the car can travel based on the amount of gas in the tank, how much the gas tank can store and how many mile per gallon the car can get.
            double fullMile = (inputTank / 100) * inputGall * inputMPG;

            //Use a condition to display a message based on the number of miles the car can go.
            if (fullMile >= 200)
            {
                //Display this message if the miles that the car can travel is greater than or equal to 200.
                Console.WriteLine("\r\nYou can drive " + fullMile + " more miles. You don't need to stop for gas.");
            }

            //Use else for any miles that are less than 200.
            else
            {
                //Display this message if the miles that the car can travel is less than 200.
                Console.WriteLine("\r\nYou can only drive " + fullMile + " more miles. You need to stop for gas!!");
            }
            //-----------------


            //PROBLEM #3: GRADE LETTER CALCULATOR

            //Create string variables to hold the letter grades.
            string gradeA = "an A";
            string gradeB = "a B";
            string gradeC = "a C";
            string gradeD = "a D";
            string gradeF = "an F";

            //Prompt the user to enter their grade.
            Console.WriteLine("\r\nPlese type your number grade and press enter.");

            //Allow the user to enter their grade.
            string grade = Console.ReadLine();

            //Convet string into an interger.
            int gradeInput;

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(grade))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("Do not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                grade = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a number.
            while (!int.TryParse(grade, out gradeInput))
            {
                //Tell the user to type enter a number.
                Console.WriteLine("\r\nYou have typed something other than a number.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                grade = Console.ReadLine();
            }

            //Use conditional statement to test whether a user has a grade between 100-90.
            if (gradeInput <= 100 && gradeInput >= 90)
            {
                //Display to the user they made an A grade based on their number grade they entered.
                Console.WriteLine("\r\nYou made " + grade + "% for your grade, which means you made " + gradeA + ".");
            }

            //Use conditional statement to test whether a user has a grade between 89-80.
            else if(gradeInput <= 89 && gradeInput >= 80)
            {
                //Display to the user they made an B grade based on their number grade they entered.
                Console.WriteLine("\r\nYou made " + grade + "% for your grade, which means you made " + gradeB + ".");
            }

            //Use conditional statement to test whether a user has a grade between 79-73.
            else if(gradeInput <= 79 && gradeInput >= 73)
            {
                //Display to the user they made an C grade based on their number grade they entered.
                Console.WriteLine("\r\nYou made " + grade + "% for your grade, which means you made " + gradeC + ".");
            }

            //Use conditional statement to test whether a user has a grade between 72-70.
            else if(gradeInput <= 72 && gradeInput >= 70)
            {
                //Display to the user they made an D grade based on their number grade they entered.
                Console.WriteLine("\r\nYou made " + grade + "% for your grade, which means you made " + gradeD + ".");
            }

            //Use conditional statement to test whether a user has a grade between 69-0.
            else if(gradeInput <= 69 && gradeInput >= 0)
            {
                //Display to the user they made an F grade based on their number grade they entered.
                Console.WriteLine("\r\nYou made " + grade + "% for your grade, which means you made " + gradeF + ".");
            }
            //-----------------


            //PROBLEM #4: DISCOUNT DOUBLE CHECK

            //Create number variables for the percentages.
            decimal tenPer = 10m;
            decimal fivePer = 5m;

            //Prompt the user to enter their first price.
            Console.WriteLine("\r\nPlease type the price of your first item then press enter.");

            //Allow the user to enter their price.
            string inputItemOne = Console.ReadLine();

            //Convert the string into a decimal.
            decimal itemOnePrice;

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(inputItemOne))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("Do not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputItemOne = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a number.
            while (!decimal.TryParse(inputItemOne, out itemOnePrice))
            {
                //Tell the user to type enter a number.
                Console.WriteLine("\r\nYou have typed something other than a number.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputItemOne = Console.ReadLine();
            }

            //Prompt the user to enter their second price.
            Console.WriteLine("\r\nPlease type the price of your second item then press enter.");

            //Allow the user to enter their price.
            string inputItemTwo = Console.ReadLine();

            //Convert the string into a decimal.
            decimal itemTwoPrice;

            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(inputItemTwo))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("Do not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputItemTwo = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a number.
            while (!decimal.TryParse(inputItemTwo, out itemTwoPrice))
            {
                //Tell the user to type enter a number.
                Console.WriteLine("\r\nYou have typed something other than a number.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                inputItemTwo = Console.ReadLine();
            }

            //Add both prices.
            decimal bothPrices = itemOnePrice + itemTwoPrice;

            //Create an if statement to determine if the user's price is $100 or more.
            if (bothPrices >= 100)
            {
                //Perform math to reduce price by 10%.
                decimal bothDiscount = bothPrices - ((tenPer / 100) * bothPrices);

                //Display only two digits after the decimal.
                decimal newbothDiscount = Math.Round(bothDiscount, 2);

                //Display the new discounted price to the user.
                Console.WriteLine("\r\nYour total price is $" + newbothDiscount + " which includes a " + tenPer + "% discount.");
            }

            //Create an if statement to determine if the user's price is between $50 and $100.
            else if (bothPrices >= 50 && bothPrices <= 100)
            {
                //Perform math to reduce price by 5%.
                decimal bothDiscount = bothPrices - ((fivePer / 100) * bothPrices);

                //Display only two digits after the decimal.
                decimal newbothDiscount = Math.Round(bothDiscount, 2);

                //Display the new discounted price to the user.
                Console.WriteLine("\r\nYour total price is $" + newbothDiscount + " which includes a " + fivePer + "% discount.");
            }

            //Use else if the user spends less than $50.
            else if (bothPrices < 50)
            {
                //Display the price to the user.
                Console.WriteLine("\r\nYour total price is $" + bothPrices + ".");
            }
        }
    }
}
