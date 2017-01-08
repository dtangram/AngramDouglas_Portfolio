using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDI_Find_Errors_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
              /*Douglas T. Angram
                10/3/2016
                Find the Errors Conditional*/
            //  Scalable Data Infrastructures
            //  Day 4 Lab
            //  Find and fix the errors

            String myName = "John Doe";
            String myJob = "\"Cat Wrangler\"";

            decimal myRatePerCat = 7.50m;
            decimal totalPay = 0;

            int numberOfCats = 40;
            Boolean employed = true;

            Console.WriteLine("Hello!  My name is " + myName + ".");
            Console.WriteLine("I'm a " + myJob + ".");
            Console.WriteLine("My current assignment has me wrangling " + numberOfCats + " cats.");
            Console.WriteLine("So, let's get to work!");

            while (numberOfCats > 0)
            {
                if(employed == true && numberOfCats > 5)
                {
                    totalPay += myRatePerCat;
                    Console.WriteLine("I've wrangled another cat and I have made $"+totalPay+" so far.  \r\nOnly " + numberOfCats + " left!");
                }

                else
                {
                    Console.WriteLine("I've been fired! Someone else will have to wrangle the rest!");
                    break;
                };

                numberOfCats--;
            }
        }
    }
}





            