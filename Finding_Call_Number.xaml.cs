using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using testing.Classes;

namespace testing
{
    /// <summary>
    /// Interaction logic for Finding_Call_Number.xaml
    /// </summary>
    public partial class Finding_Call_Number : Window
    {
        public Finding_Call_Number()
        {
            InitializeComponent();
        }
        
        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            btStart.IsEnabled = false;
            btnFinish.IsEnabled = true;
            //startTimer();
            loadDesciption();
        }

        private void loadDesciption()
        {
            ListFromTree.Items.Clear();
            //randomly select Treenodes from the height of 4
            Tree<Book> newTree = generate.pupulateTree();
            Random Rand = new Random();
            int i = Rand.Next(newTree.Root.Children.Count);
            int k = Rand.Next(newTree.Root.Children[i].Children.Count);
            int j = Rand.Next(newTree.Root.Children[i].Children[k].Children.Count);

            TreeNode<Book> selectedBook = newTree.Root.Children[i].Children[k].Children[j];
            int selectedCallNo = selectedBook.Data.CallNumber;
            string selectedDesc = selectedBook.Data.Description;

            List<int> displayList = new List<int>();
            displayList.Add(selectedCallNo);

            i = Rand.Next(newTree.Root.Children.Count);
            k = Rand.Next(newTree.Root.Children[i].Children.Count);
            j = Rand.Next(newTree.Root.Children[i].Children[k].Children.Count);

            selectedBook = newTree.Root.Children[i].Children[k].Children[j];
            int newselectedCallNo = selectedBook.Data.CallNumber;

            for (int t = 0; t < 3; t++)
            {
                while (displayList.Contains(newselectedCallNo))
                {
                    i = Rand.Next(newTree.Root.Children.Count);
                    k = Rand.Next(newTree.Root.Children[i].Children.Count);
                    j = Rand.Next(newTree.Root.Children[i].Children[k].Children.Count);

                    selectedBook = newTree.Root.Children[i].Children[k].Children[j];
                    newselectedCallNo = selectedBook.Data.CallNumber;
                }
                displayList.Add(newselectedCallNo);
            }

            tbDesc.Text = selectedDesc;
            ListFromTree.Items.Add(displayList);
        }

        private void startTimer()
        {
            int secondsCount = 0;
            Timer aTimer = new Timer(100000);
            aTimer.Elapsed += ATimer_Elapsed;
            aTimer.Enabled = true;
            aTimer.AutoReset = true;
            aTimer.Start();
        }

        private void ATimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }

        private void ListFromTree_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //check if click option is correct

            bool SelectedItem = VerifyClickedItem();
            if(SelectedItem == true)
            {

            }
            else
            {
                //...indicate that the item selected is wrong
                wrongAnswer();

                //..Reload the list
                loadDesciption();

            }
        }

        private void wrongAnswer()
        {
            throw new NotImplementedException();
        }

        private bool VerifyClickedItem()
        {
            throw new NotImplementedException();
        }

        private void btnFinish_Click(object sender, RoutedEventArgs e)
        {
            btStart.IsEnabled = true;
            btnFinish.IsEnabled = false;
            
            //...Open the results window 
        }
    }
}
