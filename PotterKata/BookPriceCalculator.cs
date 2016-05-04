using System;
using System.Linq;
using System.Collections.Generic;

namespace PotterKata
{
    public class BookPriceCalculator
    {
        private int PricePerBook = 100;

        public int CalculatePrice(List<int> boughtBooks)
        {
            int price = 0;
            while (boughtBooks.Count != 0)
            {
                List<int> distinctBooks = boughtBooks.Distinct().ToList();
                foreach (int book in distinctBooks)
                    boughtBooks.Remove(book);
                price += CalculatePricesForDistinctBooks(distinctBooks);
            }

            return price;
        }

        private int CalculatePricesForDistinctBooks(List<int> distinctBooks)
        {
            double discount;
            if (distinctBooks.Count == 1)
                discount = 1;
            else if (distinctBooks.Count == 2)
                discount = 0.95;
            else if (distinctBooks.Count == 3)
                discount = 0.9;
            else if (distinctBooks.Count == 4)
                discount = 0.8;
            else
                discount = 0.75;
            return (int)(PricePerBook*distinctBooks.Count*discount);
        }
    }
}