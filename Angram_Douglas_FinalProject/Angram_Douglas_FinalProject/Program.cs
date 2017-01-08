using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angram_Douglas_FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Douglas T. Angram
             * 11/16/16
             * Final Project
             */

            //Create a string variable.
            string newString = "it's a trap!!";

            //Create a string variable to hold the custom method.
            string newString2 = upperCase(newString);

            //Display the original string using its variable and display the new string by invoking the method. 
            Console.WriteLine("\r\nThis is the lower case version of the sentence, '" + newString + "'\r\nand this is the proper case version of the sentence, '" + newString2 + "'.");
        }
        
        //Create a validate method to hold all of the validations.
        public static string upperCase(string upperLetters)
        {
            //Create a char array and assign it to the string variable. Use dot notation on the string variable to invoke the method ToCharArray().
            char[] arrayUpper = upperLetters.ToCharArray();

            //Create a char variable and assign it to the empty space between words in a sentence.
            char upperChar = ' ';

            //Create a for loop to loop through the array.
            for (int i = 0; i < arrayUpper.Length; i++)
            {
                //Create a char variable and assign it to the indexes of the array.
                char upperCurr = arrayUpper[i];
                
                //Create an if statement and use logic operators to test if empty space is present and that the current index is a lower case letter in the alphabet.
                if(upperChar == ' ' && upperCurr >= 'a' && upperCurr <= 'z')
                {
                    //Create an int to locate the space between each word.
                    int spaceBetween = upperCurr - 'a';

                    //If there is space, only capitalize the letter after the blank space.
                    arrayUpper[i] = (char)('A' + spaceBetween);
                }

                //Assign the string literal to the array.
                upperChar = arrayUpper[i];

                //Change the array to a string and assign it back to the original string.
                upperLetters = new string(arrayUpper);
            }

            //Return the string.
            return (upperLetters);
        }
    }
}
