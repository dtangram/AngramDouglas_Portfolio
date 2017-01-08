using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angram_Douglas_StringObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Douglas T. Angram
             * 11/12/16
             * String Objects
             */

            //Prompt the user to enter an email address
            Console.WriteLine("\r\nPlease enter your email address then press enter.");

            //Allow the user to input the email address.
            string inputAddress = Console.ReadLine();

            //Validate user input.
            string validateAddress = validate(inputAddress);

            //Store invoked method and argument in string variable.
            string emailAddress = checkAddress(validateAddress);

            //Display the valid email address.
            Console.WriteLine("\r\nValid email address.\r\nThe email you provided is " + emailAddress + ".");
            //-----------------


            //PROBLEM #2: SEPARATOR SWAP OUT

            //Create a string variable.
            string marvel1 = "Spider-Man, Iron-Man, Power-Man, Hulk, Wolverine, Falcon";

            //Create a string for comma.
            string useComma = ", ";

            //Create a string for semi-colon.
            string useSemiColon = "; ";

            //Store invoked method and argument in string variable.
            string separateChars = separator(marvel1, useComma, useSemiColon);

            //Display the new string with the new separator.
            Console.WriteLine("\r\nThe new string with a separator of '" + useSemiColon + "' is " + separateChars + ".");
        }

        //Create a validate method to hold all of the validations.
        public static string validate(string validateInput)
        {
            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(validateInput))
            {
                //Tell the user to not leave blank and to enter a number.
                Console.WriteLine("\r\nDo not leave blank.\r\nPlease type a value then press enter.");

                //Allow the user to type their response.
                validateInput = Console.ReadLine();
            }

            //Return the variable.
            return validateInput;
        }

        //Create a validate method to hold all of the validations.
        public static string checkAddress(string email)
        {
            //Check to see if the user left the iput blank.
            while (string.IsNullOrWhiteSpace(email) || email.IndexOf("@") <= 1 || email.IndexOf("@") < email.LastIndexOf("@") || email.IndexOf(".") <= email.IndexOf("@") || email.IndexOf(" ") >= 0)
            {
                //Tell the user to not leave blank and to enter a valid email address.
                Console.WriteLine("\r\nNot a valid email address.\r\nPlease type in a valid email address then press enter.");

                //Allow the user to type their response.
                email = Console.ReadLine();
            }

            //Return the variable.
            return email;
        }

        //Create a validate method to hold all of the validations.
        public static string separator(string marvel2, string comma, string semiColon)
        {
            //Create string array.
            marvel2 = "Spider-Man, Iron-Man, Power-Man, Hulk, Wolverine, Falcon";

            //Create a string variable to replace the separators.
            string newComma = marvel2.Replace(comma, semiColon);

            //Display the original string with the original separator.
            Console.WriteLine("\r\nThe first string with a separator '" + comma + "' is " + marvel2 + ".");

            //Return the variable.
            return newComma;
        }
    }
}
