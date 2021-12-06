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
            startTimer();
            loadDesciption();
        }

        private void loadDesciption()
        {
            ListFromTree.Items.Clear();
            List<int> callNo = new List<int>();
            //callNo = getCallNo();
            ListFromTree.ItemsSource = callNo;

            //string Description = getDescription();
            //tbDesc.Text = Description;
        }

        private void startTimer()
        {
            throw new NotImplementedException();
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
