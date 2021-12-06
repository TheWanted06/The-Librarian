using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testing.Classes;

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
                //results.Add(theSet.Keys.ElementAt(indexes[i]));
            }

            // Return the selected items.
            return results;

        }
        //public static void callingNumber(Dictionary<int, string> theSet, List<int> randomNumbers)
        //{
        //    var random = new Random();
        //    int index1 = random.Next(theSet.Count);

        //    foreach (var theitem in randomNumbers)
        //    {
        //        foreach (var item in theSet)
        //        {

        //            if (item.Key == theitem)
        //            {
        //                calling = item.Key;
        //                callingNumberList.Add(calling);
        //                if (thenum == 2 || thenum == 4 || thenum == 6)
        //                {
        //                    desc = item.Value;
        //                    descriptions.Add(desc);
        //                }
        //            }

        //        }
        //    }

        //}
        public static void description()
        {
            

        }
        public static Tree<Book> pupulateTree()
        {
            string classfile = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), @"txt\1classes.txt");
            string divisionfile = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), @"txt\2Divisions.txt");
            string subdivisionfile = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), @"txt\3SubDivision.txt");

            var Classlines = File.ReadLines(classfile);

            var Divisionlines = File.ReadLines(divisionfile);

            var SubDivisionlines = File.ReadLines(subdivisionfile);

            string description;
            int CallNo;
            string[] wordArray;

            Tree<Book> collection = new Tree<Book>();
            collection.Root = new TreeNode<Book>
            {
                Data = new Book(1000, "Dewey Decimal system"),
                Parent = null
            };

            collection.Root.Children = new List<TreeNode<Book>>(10);
            for (int i = 0; i < collection.Root.Children.Count; i++)
            {

                string line = Classlines.Skip(i).Take(1).First();
                wordArray = line.Split(new char[] { ' ', ';' }, 2);
                CallNo = Convert.ToInt32(wordArray[0]);
                description = wordArray[1];

                collection.Root.Children[i] =
                new TreeNode<Book>()
                {
                    Data = new Book(CallNo, description),
                    Parent = collection.Root
                };
            }
            
            int counter = 0;
            for (int i = 0; i < collection.Root.Children.Count; i++)
            {
                collection.Root.Children[i].Children = new List<TreeNode<Book>>(10);
                for (int j = 0; i < collection.Root.Children[i].Children.Count; i++)
                {
                    string line = Divisionlines.Skip(counter).Take(1).First();
                    string[] newWordArray = line.Split(new char[] { ' ', ';' },2);
                    CallNo = Convert.ToInt32(newWordArray[0]);
                    description = newWordArray[1];

                    collection.Root.Children[i].Children[j] = new TreeNode<Book>()
                    {
                        Data = new Book(CallNo, description),
                        Parent = collection.Root.Children[i]
                    };
                    counter++;
                }
            }

            int counter2 = 0;
            for (int i = 0; i < collection.Root.Children.Count; i++)
            {
                for (int j = 0; j < collection.Root.Children[i].Children.Count; j++)
                {
                    collection.Root.Children[i].Children[j].Children = new List<TreeNode<Book>>(10);
                    for (int k = 0; k < collection.Root.Children[i].Children[j].Children.Count; k++)
                    {
                        string line = SubDivisionlines.Skip(counter).Take(1).First();
                        string[] newWordArray = line.Split(new char[] { ' ', ';' }, 2);
                        CallNo = Convert.ToInt32(newWordArray[0]);
                        description = newWordArray[1];

                        collection.Root.Children[i].Children[j].Children[k] = new TreeNode<Book>()
                        {
                            Data = new Book(CallNo, description),
                            Parent = collection.Root.Children[i].Children[j]
                        };
                        counter2++;
                    }
                }
            }

            return collection;
        }
        public 


    }
}
