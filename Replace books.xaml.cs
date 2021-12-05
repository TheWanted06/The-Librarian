using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace testing
{
    /// <summary>
    /// Interaction logic for Replace_books.xaml
    /// </summary>
    public partial class Replace_books : Window
    {
        //Sample 02: Declare the Timer Reference
        //static Timer TTimer;
        //static ConsoleColor defaultC = Console.ForegroundColor;

        public Replace_books()
        {
            InitializeComponent();
            btStart.IsEnabled = true;
            List<double> oldlist = generate.Books();
            this.List1.ItemsSource = oldlist;
        }
        /*
        static void TickTimer(object state)
        {
            Console.Write("Tick! ");
            Console.WriteLine(
                Thread.CurrentThread.
                ManagedThreadId.ToString());
            Thread.Sleep(500);
        }
        */
        private void btStart_Click(object sender, RoutedEventArgs e)
        {
            buttonEnabler();
            //Thread thread = new Thread(theStopWatch);
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(theStopWatch);
            dispatcherTimer.Interval = new TimeSpan(0,0,1);
            dispatcherTimer.Start();
        }
        private void buttonEnabler()
        {
            btPlace.IsEnabled = true;
            btRemove.IsEnabled = true;
            btFinish.IsEnabled = true;
            List1.IsEnabled = true;
            List2.IsEnabled = true;
            btStart.IsEnabled = false;
        }
        private void theStopWatch(object sender, EventArgs e)
        {
            /*
            string elapsedTime;
            Stopwatch stopW = new Stopwatch();
            stopW.Start();
            Thread.Sleep(100);
            stopW.Stop();
            TimeSpan tspan = stopW.Elapsed;
            elapsedTime = String.Format(" {0:00}:{1:00}:{2:00}.{3:00} ",
            tspan.Hours, tspan.Minutes, tspan.Seconds, tspan.Milliseconds / 10);
            theWelcome.Content = elapsedTime;
            */
            theWelcome.Content = DateTime.Now.ToLongTimeString();
        }
        private void btFinish_Click(object sender, RoutedEventArgs e)
        {
            List<double> oldList = new List<double>();
            oldList = (List<double>)List1.ItemsSource;
            //add the items in the listbox in new list
            List<double> newList = new List<double>();
            newList = (List<double>)List2.ItemsSource;
            //send list to sorting
            Results1 results1 = new Results1(oldList, newList);
            results1.Show();
        }

        private void btPlace_Click(object sender, RoutedEventArgs e)
        {
            //List1.has
            if (!(List2.Items.Contains(List1.SelectedItem)))
                List2.Items.Add(List1.SelectedItem.ToString());

        }

        private void btRemove_Click(object sender, RoutedEventArgs e)
        {
            List2.Items.Remove(List2.SelectedItem);
        }
    }
}
