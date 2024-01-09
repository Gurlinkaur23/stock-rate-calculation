using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace LabAssginments
{
    internal class Program
    {
        /// <summary>
        /// This program calculates the value of a stock and its market value using the formulae P = D / (R - G) and MV = P * S
        /// 
        /// R is interest rate, G is growth rate. These are inputs from the user as decimals.
        /// D is dividend, S is number of shares. These are inputs from the user as integers.
        /// 
        /// Using these values P (value of a stock) and MV (market value) are calculated.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Taking inputs from the user
            Console.Write("Enter the interest rate level as 'High', 'Medium' or 'Low': ");
            string inputInterestRate = Console.ReadLine().ToLower();

            Console.Write("Enter the growth rate of the stock as 'High', 'Medium' or 'Low': ");
            string inputGrowthRate = Console.ReadLine().ToLower();

            Console.Write("Enter the dividend ,i.e., an interger greater than 0 but less than 100: ");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of shares ,i.e., an integer greater than 0: ");
            int shares = Convert.ToInt32(Console.ReadLine());

            // Declaring the variables for interest rate and growth rate
            decimal interestRate;
            decimal growthRate;

            // Using if-else statement to determine the interest rate
            if (inputInterestRate == "high")
            {
                interestRate = 0.20m;
            }
            else if (inputInterestRate == "medium")
            {
                interestRate = 0.10m;
            }
            else
            {
                interestRate = 0.08m;
            }

            // Using if-else statement to determine the growth rate
            if (inputGrowthRate == "high")
            {
                growthRate = 0.075m;
            }
            else if (inputGrowthRate == "medium")
            {
                growthRate = 0.050m;
            }
            else
            {
                growthRate = 0.025m;
            }

            // Calculating value of a stock
            decimal price = dividend / (interestRate - growthRate);

            // Calculating the market value
            decimal marketValue = price * shares;

            // Rounding off the final values of price and market value
            decimal estimatedPrice = Math.Round(price, 3);
            decimal estimatedMarketValue = Math.Round(marketValue, 3);

            // Printing the calculated values for the value of a stock and market value
            Console.WriteLine("The value of the stock is: {0}", estimatedPrice);
            Console.WriteLine("The market value of the stock is: {0}", estimatedMarketValue);

            Console.ReadKey();
        }
    }
}
