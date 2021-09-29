using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using The_Librarian.Classes;

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
            if (tbEmail.Text.Length == 0)
            {
                Error.Content = "Enter an email.";
                tbEmail.Focus();
            }
            else if (!Regex.IsMatch(tbEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                Error.Content = "Enter a valid email.";
                tbEmail.Select(0, tbEmail.Text.Length);
                tbEmail.Focus();
            }
            else
            {
                try
                {
                    string email = tbEmail.Text;
                    string password = tbPassword.Password;

                    string con_string = "Select * from Users where Email='" + email + "'  and Password='" + password + "'";
                    DataSet dataSet = Db.Get_DataTable(con_string);

                    if (dataSet.Tables[0].Rows.Count > 0)
                    {
                        //string username = dataSet.Tables[0].Rows[0]["FirstName"].ToString() + " " + dataSet.Tables[0].Rows[0]["LastName"].ToString();
                        //MainWindow.lText = username;//Sending value from one form to another form.  
                        Redirect();
                    }
                    else
                    {
                        Error.Content = "Sorry! Please enter existing email/password.";
                    }
                    Db.Close_DB_Connection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

            
            
            
        }

        private void Redirect()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void BtCancel_Click(object sender, RoutedEventArgs e)
        {
            tbEmail.Clear();
            tbPassword.Clear();
            tbEmail.Focus();
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
