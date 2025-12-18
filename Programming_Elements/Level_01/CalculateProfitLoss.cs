using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class CalculateProfitLoss
    {
        public void ComputeProfit(int costPrice, int sellingPrice)
        {
            int profit = sellingPrice - costPrice;
            double profitPercentage = (profit / (double)costPrice) * 100;
            Console.WriteLine($"The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}");
            Console.WriteLine($"The Profit is INR {profit} and Profit Percentage is {profitPercentage}%");
        }
    }
}
