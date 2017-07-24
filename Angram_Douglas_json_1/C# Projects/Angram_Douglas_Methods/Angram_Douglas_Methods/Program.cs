using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angram_Douglas_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Douglas T. Angram
             * 11/10/16
             * Methods
             */

            //PROBLEM #1: PAINTING A WALL

            //Prompt the user to enter a width for the wall.
            Console.WriteLine("\r\nPlease enter the number of feet for the width of the wall then press enter.");

            //Allow the user to enter a value.
            string inputWidth = Console.ReadLine();

            //Validate user input.
            double width = validate(inputWidth);

            //Display the users input.
            Console.WriteLine(width + "ft");

            //Prompt the user to enter a height for the wall.
            Console.WriteLine("\r\nPlease enter the number of feet for the height of the wall then press enter.");

            //Allow the user to enter a value.
            string inputHeight = Console.ReadLine();

            //Validate user input.
            double height = validate(inputHeight);

            //Display the users input.
            Console.WriteLine(height + "ft");

            //Prompt the user to enter a number for the wall's surface area.
            Console.WriteLine("\r\nPlease enter the number of square feet for the surface area of the wall then press enter.");

            //Allow the user to enter a value.
            string inputSurfArea = Console.ReadLine();

            //Validate user input.
            double surfArea = validate(inputSurfArea);

            //Display the users input.
            Console.WriteLine(surfArea + "sqft");

            //Prompt the user to enter the number of coats of paint they want to apply to the wall.
            Console.WriteLine("\r\nPlease enter how many coats of paint you want to apply then press enter.");

            //Allow the user to enter a value.
            string inputCoatsOfPaint = Console.ReadLine();

            //Validate user input.
            double coatsOfPaint = validate(inputCoatsOfPaint);

            //Calculate the number of gallons needed to paint the wall
            double gallons = (width * height) / surfArea * coatsOfPaint;

            //Convert from double to decimal to perform rounding.
            decimal newGallons = (decimal)gallons;

            //Round to the decimal hundredths place.
            decimal totalGallons = Math.Round(newGallons, 2);

            Console.WriteLine("\r\nFor " + coatsOfPaint + " coats on the wall, you will need " + totalGallons + " gallons of paint.");

            /*Test:
             Width - 10ft, Height - 30ft, Surface Area - 100sqft, Coats of Paint - 2
             For 2 coats on the wall, you will need 6 gallons of paint.*/

            //-----------------


            //PROBLEM #2: STUNG!

            double beeSting = 9;

            //Prompt the user to enter the animal's weight.
            Console.WriteLine("\r\nPlease enter the animal's weight then press enter.");

            //Allow the user to input the number.
            string inputWeight = Console.ReadLine();

            //Validate user input.
            double animalWeight = validate(inputWeight);

            //Display the results to the user.
            Console.WriteLine(animalWeight + "lbs");

            //Call the method the stores the calculations.
            double numberOfStings = stingAnimal(animalWeight, beeSting);

            //Display the results to the user.
            Console.WriteLine("\r\nIt takes " + numberOfStings + " bee stings to kill this animal.");

            /*Test:
             Animal's Weight - 40lbs
             It takes 360 bee stings to kill this animal.*/

            //-----------------

            //PROBLEM #3: REVERSE IT

            //Create an array
            string[] jl = new string[5] { "Superman", "Batman", "Wonder Woman", "Green Lantern", "Flash" };

            //Refernce the method.
            leagueMembers(jl);

            /*Test:
             Initial array -["Superman", "Batman", "Wonder Woman", "Green Lantern", "Flash"]
             Results - Your original array was Superman, Batman, Wonder Woman, Green Lantern, Flash.
             Your reverse array is Flash, Green Lantern, Wonder Woman, Batman, Superman.
             */
        }

        //Create a validate method to hold all of the validations.
        public static double validate(string validateInput)
        {
            //Declare a variable to hold the converted value.
            double validInput;

            //Check to see if the user left the iput blank.
            while(string.IsNullOrWhiteSpace(validateInput))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("\r\nDo not leave blank.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                validateInput = Console.ReadLine();
            }

            //Check to see if the user entered anything other than a number.
            while(!double.TryParse(validateInput, out validInput))
            {
                //Tell the user to type enter a number.
                Console.WriteLine("\r\nYou have typed something other than a number.\r\nPlease type a number then press enter.");

                //Allow the user to type their response.
                validateInput = Console.ReadLine();
            }

            //Return the variable wallWidth.
            return validInput;
        }

        //Create method to store the calculation of the animal weight and the number of bee stings.
        public static double stingAnimal(double weightofAnimal, double bsting)
        {
            //Multiply the weight of the animal with the number of bee stings.
            double totalStings = weightofAnimal * bsting;

            //Return the total stings.
            return totalStings;
        }

        //Create a method to loop through the array and dispaly the original order and the reverse order.
        public static string[] leagueMembers(string[] justiceLeague)
        {
            //Create for each loop to store the original order of the array.
            foreach (string eachMember in justiceLeague)
            {
                //Dispaly the original array.
                Console.WriteLine("\r\nYour original array is {0}.", eachMember);
            }

            //Create a for loop to reverse the array.
            for (int i = justiceLeague.Length - 1; i >= 0; i--)
            {
                //Display the array in reverse.
                Console.WriteLine("\r\nYour reverse array is " + justiceLeague[i] + ".");
            }

            //Return the parameters.
            return justiceLeague;
        }
    }
}
