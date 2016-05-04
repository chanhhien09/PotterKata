using System;
using System.Collections.Generic;

namespace PotterKata
{
    public class BookPriceCalculator
    {
        private int PricePerBook = 100;

        public int CalculatePrice(List<int> boughtBooks)
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