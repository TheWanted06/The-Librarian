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
using The_Librarian;
using The_Librarian.Classes;
using The_Librarian.Windows;

namespace The_Librarian
{
    /// <summary>
    /// Interaction logic for Sign_Up.xaml
    /// </summary>
    public partial class Sign_Up : Window
    {
        public Sign_Up()
        {
            InitializeComponent();
        }
        
        private void BtSignUp_Click(object sender, RoutedEventArgs e)
        {
            string theEmail = tbEmail.Text;

            if (theEmail.Length == 0 )
            {
                tbError.Content = "Enter a Email";
                tbEmail.Focus();
            }
            else if (!Regex.IsMatch(tbEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                tbError.Content = "Enter a valid email.";
                tbEmail.Select(0, tbEmail.Text.Length);
                tbEmail.Focus();
            }
            else
            {
                string theName = tbName.Text;
                string theSurname = tbSurname.Text;
                string theUsername = tbUsername.Text;
                string thePassword = tbPassword.Password;
                string theConfirmedPassword = tbConfirmPassword.Password;
                string theError = tbError.Content.ToString();

                if (thePassword.Length == 0)
                {
                    tbError.Content = "Enter password.";
                    tbPassword.Focus();
                }
                else if (theConfirmedPassword.Length == 0)
                {
                    tbError.Content = "Enter Confirm password.";
                    tbConfirmPassword.Focus();
                }
                else if (thePassword != theConfirmedPassword)
                {
                    tbError.Content = "Confirm password must be same as password.";
                    tbConfirmPassword.Focus();
                }
                else
                {
                    tbError.Content = "";
                    User newUser = new User(theName, theSurname, theUsername, theEmail, thePassword);
                    AddUser(newUser);
                }
            }
        }

        private void AddUser(User newUser)
        {
            try
            {
                string sql = ($"Insert into Users(FirstName,SurName,Email,Username,Password) values({newUser.FirstName},{newUser.Surname},{newUser.email},{newUser.Username},{newUser.password})");
                Db.Execute_SQL(sql);
                Redirect();
                Db.Close_DB_Connection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
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
            Clear();
        }
        public void Clear()
        {
            tbName.Clear();
            tbSurname.Clear();
            tbUsername.Clear();
            tbEmail.Clear();
            tbPassword.Clear();
            tbName.Focus();
        }

        private void btLogin_Click(object sender, RoutedEventArgs e)
        {
            Login newLogin = new Login();
            newLogin.Show();
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
