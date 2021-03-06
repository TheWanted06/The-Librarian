using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Librarian
{
    class generateBooks
    {
        public static double NextDouble(Random rand, double minValue, double maxValue, int decimalPlaces)
        {
            double randNumber = rand.NextDouble() * (maxValue - minValue) + minValue;
            return Convert.ToDouble(randNumber.ToString("f" + decimalPlaces));
        }

        public static BookList<double> generate()
        {
            int No_Of_Books = 10;
            Random rand = new Random();
            double randNumber; 
            //then add the randomly generate number to the Booklist 
            BookList<double> newBookList = new BookList<double>();
            for (int i = 0; i < No_Of_Books; i++)
            {
                randNumber = NextDouble(rand, 000.00, 999.999, 3); // Round to 3 decimal places
                newBookList.Add(randNumber);
            }
            return newBookList;
        }
    }
}
