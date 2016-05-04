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
            bool isDistinct = boughtBooks.Distinct().Count() == boughtBooks.Count();
            if (boughtBooks.Count == 1)
                return 100;
            else if (boughtBooks.Count == 2)
                return (isDistinct) ? 190 : 100+100;
            else if (boughtBooks.Count == 3)
                return (isDistinct) ? 270 : 190+100;
            else if (boughtBooks.Count == 4)
                return (isDistinct) ? 320 : 270+100;
            else
                return (isDistinct) ? 375 : 320+100;
        }

    }
}