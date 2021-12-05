using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class generate
    {
        Dictionary<int, string> theSet = theDictionary.addToDictionary();
        List<int> randomNumbers = new List<int>();
        private static Random Rand = null;

        public static double NextDouble(Random rand, double minValue, double maxValue, int decimalPlaces)
        {
            double randNumber = rand.NextDouble() * (maxValue - minValue) + minValue;
            return Convert.ToDouble(randNumber.ToString("f" + decimalPlaces));
        }

        public static List<double> Books()
        {
            int No_Of_Books = 10;
            Random rand = new Random();
            double randNumber;
            //then add the randomly generate number to the Booklist 
            List<double> newBookList = new List<double>();
            for (int i = 0; i < No_Of_Books; i++)
            {
                randNumber = NextDouble(rand, 000.000, 999.999, 3); // Round to 3 decimal places
                newBookList.Add(randNumber);
            }
            return newBookList;
        }
        public bool doestheCallNoHaveMore()
        {
            //1 for calling numbers to have 7 option
            //2 for description to have 7 options

            Random rnd = new Random();
            int days = rnd.Next(0, 3);
            if (days == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<T> PickRandom<T>(Dictionary<int, string> theSet)
        {


            //the goal is to return a random list of calling numbers from the dictionary

            // Create the Random object if it doesn't exist.
            if (Rand == null) Rand = new Random();

            // Don't exceed the Lists' length.
            int num_values = theSet.Count -1;

            // Make a list of indexes 0 through values.Length - 1.
            List<int> indexes = Enumerable.Range(0, theSet.Count).ToList();

            // Build the return list.
            List<T> results = new List<T>();

            // Randomize the first num_values indexes.
            for (int i = 0; i < num_values; i++)
            {
                // Pick a random entry between i and values.Length - 1.
                int j = Rand.Next(i, theSet.Count);

                // Swap the values.
                int temp = indexes[i];
                indexes[i] = indexes[j];
                indexes[j] = temp;

                // Save the ith value.
                results.Add(theSet.Keys.ElementAt(indexes[i]]);
            }

            // Return the selected items.
            return results;

        }
        public static void callingNumber(Dictionary<int, string> theSet, List<int> randomNumbers)
        {
            var random = new Random();
            int index1 = random.Next(theSet.Count);

            foreach (var theitem in randomNumbers)
            {
                foreach (var item in theSet)
                {

                    if (item.Key == theitem)
                    {
                        calling = item.Key;
                        callingNumberList.Add(calling);
                        if (thenum == 2 || thenum == 4 || thenum == 6)
                        {
                            desc = item.Value;
                            descriptions.Add(desc);
                        }
                    }

                }
            }

        }
        public static void description()
        {

        }

    }
}
