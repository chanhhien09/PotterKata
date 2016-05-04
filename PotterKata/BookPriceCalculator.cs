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
            List<List<int>> setOfDistinctBooks = new List<List<int>>();
            int price = 0;
            while (boughtBooks.Count != 0)
            {
                List<int> distinctBooks = boughtBooks.Distinct().ToList();
                setOfDistinctBooks.Add(distinctBooks);
                foreach (int book in distinctBooks)
                    boughtBooks.Remove(book);
                price += CalculatePricesForDistinctBooks(distinctBooks);
            }

            return price;
        }

        private int CalculatePricesForDistinctBooks(List<int> boughtBooks)
        {
            if (boughtBooks.Count == 1)
                return 100;
            else if (boughtBooks.Count == 2)
                return 190;
            else if (boughtBooks.Count == 3)
                return 270;
            else if (boughtBooks.Count == 4)
                return 320;
            else
                return 375;
        }
    }
}