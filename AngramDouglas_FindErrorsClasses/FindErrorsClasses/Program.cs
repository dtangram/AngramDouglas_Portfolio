using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindErrorsClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Theater AmcCineplex20 = new Theater("AMC Cineplex 20", 20, 10.00m);
            Theater RegalCinema = new Theater("Regal Cinema", 15, 8.00m);

            Console.WriteLine("\r\nLet's go see a movie at {0}!\r\nThey have {1} movies to choose from and the average ticket price is {2}.", AmcCineplex20.GetName(), AmcCineplex20.GetNumScreens(), AmcCineplex20.GetTicketPrice().ToString("C"));
            Console.WriteLine("\r\nWhat about {0} instead?\r\nTheir average ticket price is only {1}.\r\nThe only drawback is that they only have {2} screens.", RegalCinema.GetName(), RegalCinema.GetTicketPrice().ToString("C"), RegalCinema.GetNumScreens());

            
            decimal totalRegal = TotalTicketCost(RegalCinema.GetTicketPrice());

            Console.WriteLine("\r\nIf all 4 of us go to {0}, then that would bring the total cost to {1}.", RegalCinema.GetName(), totalRegal.ToString("C"));
            Console.WriteLine("\r\nWait, I forgot I have a coupon for $3.00 off a movie at the {0}!", AmcCineplex20.GetName());

            decimal totalAMC = (AmcCineplex20.GetTicketPrice() - 3);

            Console.WriteLine("\r\nThat would make a ticket there cost only {0}.", totalAMC.ToString("C"));

            decimal newTotalAMC = totalAMC * 4;

            Console.WriteLine("\r\nWith your coupon, all 4 of us can go for only {0}!\r\nLet's go to {1}", newTotalAMC.ToString("C"), AmcCineplex20.GetName());

        }

        //Custom function to return how much #number of tickets will be
        public static decimal TotalTicketCost(decimal _AverageTicketPrice)
        {
            decimal totalCost = _AverageTicketPrice * 4;

            return totalCost;

        }
    }
}
