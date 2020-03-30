using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            
            int noOfBooksInOrder = 23;
            int noOfDVDsInOrder = 16;
            int noOfGamesInOrder = 7;
            double netPriceBook = 30;
            double netPriceDVD = 50;
            double netPriceGame = 100;
            int shipping = 49;
            double taxPercentage = 10;
            double cardFeePercentage = 2;

            double netprice = netPriceBook*noOfBooksInOrder + netPriceDVD * noOfDVDsInOrder + netPriceGame * noOfGamesInOrder;
            double netPricePlusTax = netprice * (taxPercentage / 100);
            double priceWithCardfee = (shipping + netPricePlusTax) * (cardFeePercentage / 100);
            
            double totalPrice = priceWithCardfee; // This variable should contain the total price for the order

            Console.WriteLine($"You ordered {noOfBooksInOrder} books, {noOfDVDsInOrder} DVDs and {noOfGamesInOrder} games");
            Console.WriteLine($"Total cost including tax, shipping and credit card fee: {totalPrice} kr.");


            // The LAST line of code should be ABOVE this line
        }
    }
}
