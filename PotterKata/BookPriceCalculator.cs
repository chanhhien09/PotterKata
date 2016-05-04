using System;
using System.Linq;
using System.Collections.Generic;

namespace PotterKata
{
    public class BookPriceCalculator
    {
        private int PricePerBook = 100;
        private double[] DiscountForDistinctBooks = new double[]
        {
            1, 0.95, 0.9, 0.8, 0.75
        };

        public int CalculatePrice(List<int> boughtBooks)
        {
            int price = 0;
            while (boughtBooks.Count != 0)
            {
                List<int> distinctBooks = boughtBooks.Distinct().ToList();
                foreach (int book in distinctBooks)
                    boughtBooks.Remove(book);
                price += CalculatePricesForDistinctBooks(distinctBooks.Count);
            }

            return price;
        }

        private int CalculatePricesForDistinctBooks(int distinctBooksCount)
        {
            return (int)(PricePerBook*distinctBooksCount*DiscountForDistinctBooks[distinctBooksCount-1]);
        }
    }
}