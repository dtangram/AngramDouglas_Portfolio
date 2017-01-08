using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angram_Douglas_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Douglas T. Angram
             Section 02
             10/30/2016
             Arrays Assignment
             */

            //Declare and Define The Starting Number Arrays
            int[] firstArray = new int[4] { 4, 20, 60, 150 };
            double[] secondArray = new double[4] { 5, 40.5, 65.4, 145.98 };

            //Find the total of each array and store it in a variable and output to console

            /*In the first array, I created a variable and assigned it to all of the items in the firstArray variable and separated them 
            with plus signs to perform addition.*/
            int firstArrayTotal = firstArray[0] + firstArray[1] + firstArray[2] + firstArray[3];

            /*In the second array, I created a variable and assigned it to all of the items in the secondArray variable and separated them 
            with plus signs to perform addition.*/
            double secondArrayTotal = secondArray[0] + secondArray[1] + secondArray[2] + secondArray[3];

            //To display the sum, I Console.WriteLine the new variables and concatenated them with strings.
            Console.WriteLine("The total for the first array is " + firstArrayTotal + ". The total for the second array is " + secondArrayTotal + ".");


            //Calculate the average of each array and store it in a variable and output to console
            //Just a reminder to check the averages with a calculator as well, to make sure they are correct.

            /*I needed to get the average of the array, so in the first array, I created a variable and assigned it to all of the items in the firstArray variable and separated them 
            with plus signs to perform addition, and surrounded them with parentheses so that the addition can be performed first.
            Next I added the division operator and the number four so that the sum can be divided by 4 because that's the number of items in the array.*/
            int firstArrayAvg = (firstArray[0] + firstArray[1] + firstArray[2] + firstArray[3]) / 4;

            /*I needed to get the average of the array, so in the second array, I created a variable and assigned it to all of the items in the secondArray variable and separated them 
            with plus signs to perform addition, and surrounded them with parentheses so that the addition can be performed first.
            Next I added the division operator and the number four so that the sum can be divided by 4 because that's the number of items in the array.*/
            double secondArrayAvg = (secondArray[0] + secondArray[1] + secondArray[2] + secondArray[3]) / 4;

            //To display the results of both averages, I Console.WriteLine the new variables and concatenated them with strings.
            Console.WriteLine("The average for the first array is " + firstArrayAvg + " and the average for the second array is " + secondArrayAvg + ".");

            /*
               Create a 3rd number array.  
               The values of this array will come from the 2 given arrays.
                -You will take the first item in each of the 2 number arrays, add them together and then store this sum inside of the new array.
                -For example Add the index#0 of array 1 to index#0 of array2 and store this inside of your new array at the index#0 spot.
                -Repeat this for each index #.
                -Do not add them by hand, the computer must add them.
                -Do not use the numbers themselves, use the array elements.
                -After you have the completed new array, output this to the Console.
             */

            /*For each of the statements below, I used the double variable because some of the digits have decimals. I created a variable and assisnged it 
            to the zero, one, two and three indexes from both arrays and calculated the averages. Then displayed the answer in the console and concatenated 
            the variabes with strings.*/ 
            double indexZeroAvg = (firstArray[0] + secondArray[0]) / 2;
            Console.WriteLine("The average for index 0 in both arrays is " + indexZeroAvg + ".");

            double indexOneAvg = (firstArray[1] + secondArray[1]) / 2;
            Console.WriteLine("The average for index 1 in both arrays is " + indexOneAvg + ".");

            double indexTwoAvg = (firstArray[2] + secondArray[2]) / 2;
            Console.WriteLine("The average for index 2 in both arrays is " + indexTwoAvg + ".");

            double indexThreeAvg = (firstArray[3] + secondArray[3]) / 2;
            Console.WriteLine("The average for index 3 in both arrays is " + indexThreeAvg + ".");

            /*
               Given the array of strings below named MixedUp.  
               You must create a string variable that puts the items in the correct order to make a complete sentence.
                -Use each element in the array, do not re-write the strings themselves.
                -Concatenate them in the correct order to form a sentence.
                -Store this new sentence string inside of a string variable you create.
                -Output this new string variable to the console.
             */


            //Declare and Define The String Array
            string[] MixedUp = new string[] { "but the lighting of a", "Education is not", "fire.", "the filling", "of a bucket," };

            /*I created a string variable and assigned it to the items in the MixedUp array. I corrected the sentence by rearranging the items in the array
             and concatenating them with strings of empty spaces. Then I displayed the result in the console by placing my new variable in the parentheses.*/
            string decode = MixedUp[1] + " "+ MixedUp[3] + " " + MixedUp[4] + " " + MixedUp[0] + " " + MixedUp[2];
            Console.WriteLine(decode);
        }
    }
}
