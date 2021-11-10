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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace testing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btReplacing_Click(object sender, RoutedEventArgs e)
        {
            Replace_books replace_ = new Replace_books();
            replace_.Show();
            this.Hide();
        }

        private void btIndentify_Click(object sender, RoutedEventArgs e)
        {
            Identify_Area identify_ = new Identify_Area();
            identify_.Show();
            this.Hide();
        }

        private void btFinding_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
