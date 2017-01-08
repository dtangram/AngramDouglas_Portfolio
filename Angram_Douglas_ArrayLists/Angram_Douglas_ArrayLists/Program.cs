using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angram_Douglas_ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Douglas T. Angram
             * 11/13/2016
             * ArrayLists
             */

            //Create an ArrayList for the artists.
            ArrayList musicLegends = new ArrayList();

            //Add artits to the list.
            musicLegends.Add("Prince");
            musicLegends.Add("Billy Joel");
            musicLegends.Add("Elvis");
            musicLegends.Add("Michael");
            musicLegends.Add("Stevie");

            //Create an ArrayList for the artists' descriptions.
            ArrayList legendsDescript = new ArrayList();

            //Add artits' descriptions to the list.
            legendsDescript.Add("Multi-talented");
            legendsDescript.Add("a Rock Legend");
            legendsDescript.Add("the King of Rock");
            legendsDescript.Add("the King of Pop");
            legendsDescript.Add("a Pop, R&B and Soul Legend");

            //Invoke the method and pass the arguements.
            legends(musicLegends, legendsDescript);
        }

        //Create method to store the calculation of the animal weight and the number of bee stings.
        public static void legends(ArrayList array1, ArrayList array2)
        {
            //Create a for-loop using the logic operator, "&&" to loop through both ArrayLists.
           for (int i = 0; i < array1.Count && i < array2.Count; i++)
            {
                //Display the sentence using the arrays.
                Console.WriteLine("\r\nMusic legend " + array1[i] + " is " + array2[i] + ".");
            }

           //Use the Remove method to remove to indexes from both ArrayLists.
            array1.Remove(array1[1]);
            array1.Remove(array1[2]);
            array2.Remove(array2[1]);
            array2.Remove(array2[2]);

            //Use the Insert method to add an index to the top of both ArrayLists.
            array1.Insert(0, "James");
            array2.Insert(0, "the God-father of Soul");

            //Create a for-loop using the logic operator, "&&" to loop through both ArrayLists.
            for (int j = 0; j < array1.Count && j < array2.Count; j++)
            {
                //Display the sentence using the arrays.
                Console.WriteLine("\r\nMusic legend " + array1[j] + " is " + array2[j] + ".");
            }
        }
    }
}
