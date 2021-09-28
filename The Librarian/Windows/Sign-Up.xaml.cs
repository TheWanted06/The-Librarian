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
using The_Librarian;
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
            string theName = tbName.Text;
            string theSurname = tbSurname.Text;
            string theEmail = tbEmail.Text;
            string theUsername = tbUsername.Text;
            string thePassword = tbPassword.Text;
            User newUser = new User(theName, theSurname, theUsername, theEmail, thePassword);
            AddUser(newUser);
        }

        private void AddUser(User newUser)
        {
            try
            {
                string connectionString;
                SqlConnection cnn;

                connectionString = ConfigurationManager.ConnectionStrings["AutoBotSqlProvider"].ConnectionString;
                cnn = new SqlConnection(connectionString);

                cnn.Open();

                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "";

                sql = ($"insert into Users(FirstName,SurName,Email,Username,Password) values({newUser.FirstName},{newUser.Surname},{newUser.email},{newUser.Username},{newUser.password})");
                command = new SqlCommand(sql, cnn);

                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();
                cnn.Close();
                Redirect();

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
