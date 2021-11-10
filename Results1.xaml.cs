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
    /// Interaction logic for Results1.xaml
    /// </summary>
    public partial class Results1 : Window
    {
        public Results1(List<double> oldList, List<double> newList)
        {
            InitializeComponent();

        }
    }
}
