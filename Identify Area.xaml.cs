using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace testing
{
    /// <summary>
    /// Interaction logic for Identify_Area.xaml
    /// </summary>
    public partial class Identify_Area : Window
    {
        public Identify_Area()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            //ENABLER...I call upon thee 
            theEnabler();
            //some say without him, nothing works...!!!

            var random = new Random();
            Dictionary<int, string> theSet = theDictionary.addToDictionary();
            int index1 = random.Next(theSet.Count);

            List<int> randomNumbers = new List<int>();
            randomNumbers.Add(index1);

            for (int i = 0; i < 6; i++)
            {
                bool isUnique = true;
                index1 = random.Next(theSet.Count);
                //check if new index1 is in randomNumbers list
                if (randomNumbers.Contains(index1))
                    isUnique = false;
                while (isUnique == false)
                {
                    index1 = random.Next(theSet.Count);
                    if (!randomNumbers.Contains(index1))
                        isUnique = true;
                    
                }
                randomNumbers.Add(index1);
            }
            List<int> callingNumberList = new List<int>();
            List<string> descriptions = new List<string>();

            int thenum = 1;
            int calling;
            string desc;


            //who has more?? is it Cal or is it Des?
            bool more = callingHasMore();
            if(more == true)
            {
                foreach (var theitem in randomNumbers)
                {
                    foreach (var item in theSet)
                    {

                        if (item.Key == theitem)
                        {
                            calling = item.Key;
                            callingNumberList.Add(calling);
                            if(thenum ==2|| thenum ==4 || thenum ==6)
                            {
                                desc = item.Value;
                                descriptions.Add(desc);
                            }
                        }

                    }
                }

            }
            else
            {
                foreach (var theitem in randomNumbers)
                {
                    foreach (var item in theSet)
                    {

                        if (item.Key == theitem)
                        {
                            desc = item.Value;
                            descriptions.Add(desc);
                            if (thenum == 2 || thenum == 4 || thenum == 6)
                            {
                                calling = item.Key;
                                callingNumberList.Add(calling);
                            }
                        }

                    }
                }
            }

            matchinglv1.ItemsSource = callingNumberList;
            matchinglv2.ItemsSource = descriptions;

        }

        private bool callingHasMore()
        {
            //1 for calling numbers to have 7 option
            //2 for description to have 7 options

            Random rnd = new Random();
            int days = rnd.Next(0, 3);
            if(days== 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void theEnabler()
        {
            matchinglv1.IsEnabled = true;
            matchinglv2.IsEnabled = true;
            matchinglv3.IsEnabled = true;

            btNextQuestions.IsEnabled = true;
            btFinish.IsEnabled = true;
            btPair.IsEnabled = true;
            btUnPair.IsEnabled = true;
        }

        private void btNextQuestions_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btFinish_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btPair_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btUnPair_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
