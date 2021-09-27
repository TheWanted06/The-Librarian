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

namespace The_Librarian
{
    /// <summary>
    /// Interaction logic for Splash_Screen.xaml
    /// </summary>
    public partial class Splash_Screen : Window
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }
        public double Progress
        {
            get { return progressBar.Value; }
            set { progressBar.Value = value; }
        }
    }
}
