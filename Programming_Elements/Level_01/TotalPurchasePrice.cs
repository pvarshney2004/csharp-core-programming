using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class TotalPurchasePrice
    {
        public void CalculateTotalPurchasePrice(double unitPrice, int quantity)
        {

            double total = unitPrice * quantity;
            Console.WriteLine($"The total purchase price is INR {total} if the quantity {quantity} and unit price is INR {unitPrice}");
        }
    }
}
