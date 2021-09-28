using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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

namespace The_Librarian.Windows
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string theUsername = tbUsername.Text;
                string thePassword = tbPassword.Text;
                string DbUser = " ";
                string DbPw = "";

                string connectionString;
                SqlConnection cnn;

                connectionString = Properties.Settings.Default.ConnectionString;
                cnn = new SqlConnection(connectionString); 

                cnn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql = ($"Select Password from Users where Username={tbUsername}");

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    DbPw = dataReader.GetString(0);
                }
                if (DbPw == thePassword)
                {
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void BtCancel_Click(object sender, RoutedEventArgs e)
        {
            tbUsername.Clear();
            tbPassword.Clear();
            tbUsername.Focus();
        }

        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {
            Sign_Up sign_ = new Sign_Up();
            sign_.Show();
            this.Hide();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var response = MessageBox.Show("Do you really want to exit?", "Exiting...",
                                   MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (response == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Current.Shutdown();
            }
        }
    }
}
