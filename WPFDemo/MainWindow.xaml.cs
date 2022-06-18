using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Users> users = new List<Users>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click_1(object sender, RoutedEventArgs e)
        {
            users.Add(new Users
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text
            });

            comboUsers.ItemsSource = users;

            MessageBox.Show(String.Format("Hello {0} your account is beend added",txtFirstName.Text),
                "Alert",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }
    }

    public class Users 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName {
            get
            {
                return String.Format("{0} {1}",FirstName,LastName);
            }
        }
    }

}
