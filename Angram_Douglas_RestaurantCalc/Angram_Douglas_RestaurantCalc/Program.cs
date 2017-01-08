using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angram_Douglas_RestaurantCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Douglas T. Angram
             10/31/2016
             Tip Calculator
             */

            //Prompt customer 1 to type in 3 prices for their apetizer.
            Console.WriteLine("Please enter the price of your apetizer and press enter. Please enter numbers and decimals only, no dollar signs ($).");

            //Use ReadLine so that the customer can respond to my request.
            string meal1 = Console.ReadLine();

            //Convert the string into a number so that it can be calculated.
            double meal1Number = double.Parse(meal1);

            //Prompt customer to type in the price for their dinner.
            Console.WriteLine("Please enter the price of your dinner and press enter. Please enter numbers and decimals only, no dollar signs ($).");

            //Use ReadLine so that the customer can respond to my request.
            string meal2 = Console.ReadLine();

            //Convert the string into a number so that it can be calculated.
            double meal2Number = double.Parse(meal2);

            //Prompt customer to type in the price for their desert.
            Console.WriteLine("Please enter the price of your dinner and press enter. Please enter numbers and decimals only, no dollar signs ($).");

            //Use ReadLine so that the customer can respond to my request.
            string meal3 = Console.ReadLine();

            //Convert the string into a number so that it can be calculated.
            double meal3Number = double.Parse(meal3);

            //Prompt customer 1 for a tip.
            Console.WriteLine("Please enter an amount for a tip then press enter. For example, if you want to leave a 10% tip, type the number 10.");

            //Use ReadLine so that the customer can respond to my request.
            string tip1 = Console.ReadLine();

            // Convert the string into a number so that it can be calculated.
            double tip1Number = double.Parse(tip1);

            //Calculate the tip percentage, multiply by the total of the meal then add to the total of the meal.
            double newTotal1 = ((tip1Number / 100) * meal1Number + meal1Number);

            //Convert to decimal.
            decimal newTotDec = (decimal)newTotal1;

            //Use Math.Round to display round to the hunderdth place behind the decimal so that only two places behind the decimal are displayed.
            decimal newMeal1Price = Math.Round(newTotDec, 2);

            //Display new total to customer 1.
            Console.WriteLine("Your total including tip is $" + newMeal1Price + ". Thank you!");

            //Prompt customer 2 for a tip.
            Console.WriteLine("Please enter an amount for a tip then press enter. For example, if you want to leave a 10% tip, type the number 10..");

            //Use ReadLine so that the customer can respond to my request.
            string tip2 = Console.ReadLine();

            // Convert the string into a number so that it can be calculated.
            double tip2Number = double.Parse(tip2);

            //Calculate the tip percentage, multiply by the total of the meal then add to the total of the meal.
            double newTotal2 = ((tip2Number / 100) * meal2Number + meal2Number);

            //Convert to decimal.
            decimal newTot2Dec = (decimal)newTotal2;

            //Use Math.Round to display round to the hunderdth place behind the decimal so that only two places behind the decimal are displayed.
            decimal newMeal2Price = Math.Round(newTot2Dec, 2);

            //Display new total to customer 2.
            Console.WriteLine("Your total including tip is $" + newMeal2Price + ". Thank you!");

            //Prompt customer 3 for a tip.
            Console.WriteLine("Please enter an amount for a tip then press enter. For example, if you want to leave a 10% tip, type the number 10..");

            //Use ReadLine so that the customer can respond to my request.
            string tip3 = Console.ReadLine();

            // Convert the string into a number so that it can be calculated.
            double tip3Number = double.Parse(tip3);

            //Calculate the tip percentage, multiply by the total of the meal then add to the total of the meal.
            double newTotal3 = ((tip3Number / 100) * meal3Number + meal3Number);

            //Convert to decimal.
            decimal newTot3Dec = (decimal)newTotal3;

            //Use Math.Round to display round to the hunderdth place behind the decimal so that only two places behind the decimal are displayed.
            decimal newMeal3Price = Math.Round(newTot3Dec, 2);

            //Display new total to customer 2.
            Console.WriteLine("Your total including tip is $" + newMeal3Price + ". Thank you!");

            //Calculate to for the meal. Use the double variable in case the customer uses decimals.
            double mealPrice = meal1Number + meal2Number + meal3Number;

            //Convert to decimal.
            decimal newmealPrice = (decimal)mealPrice;

            //Use Math.Round to display round to the hunderdth place behind the decimal so that only two places behind the decimal are displayed.
            decimal mealPriceNew = Math.Round(newmealPrice, 2);

            //Display the full price of the meal to the customer.
            Console.WriteLine("The total of all 3 meals without tips is $" + mealPriceNew + ". Thank you.");

            //Calculate to for the meal. Use the double variable in case the customer uses decimals.
            double tipPrice = (tip1Number / 100) + (tip2Number / 100) + (tip3Number / 100);

            //Convert to decimal.
            decimal newtipPrice = (decimal)tipPrice;

            //Use Math.Round to display round to the hunderdth place behind the decimal so that only two places behind the decimal are displayed.
            decimal tipPriceNew = Math.Round(newtipPrice, 2);

            //Display the total of all 3 tips.
            Console.WriteLine("The total of all 3 tips is $" + tipPriceNew + ". Thank you.");

            //Add all totals for meals and tips.
            double fullMealTotal = mealPrice + tipPrice;

            //Convert to decimal.
            decimal newfullMealTotal = (decimal)fullMealTotal;

            //Use Math.Round to display round to the hunderdth place behind the decimal so that only two places behind the decimal are displayed.
            decimal grandTotal = Math.Round(newfullMealTotal, 2);

            //Display the grand total.
            Console.WriteLine("The grand total of all 3 meals and all 3 tips is $" + grandTotal + ". Thank you.");

            //Divide the grand total by the number of customers.
            decimal divideTotal = (grandTotal / 3);

            //Use Math.Round to display round to the hunderdth place behind the decimal so that only two places behind the decimal are displayed.
            decimal splitBill = Math.Round(divideTotal, 2);

            //Display the total that each customer will have to pay.
            Console.WriteLine("If the three of you would like to spit the bill, the price per person will be $" + splitBill + ". Thank you.");
        }
    }
}
