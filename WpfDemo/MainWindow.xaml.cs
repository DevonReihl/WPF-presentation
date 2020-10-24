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

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> people = new List<Person>();

        public MainWindow()
        {
            InitializeComponent();

            people.Add(new Person { FirstName = "Devon", LastName = "Reihl" });
            people.Add(new Person { FirstName = "Phoenixx", LastName = "Reihl" });
            people.Add(new Person { FirstName = "Izzy", LastName = "Reihl" });

            recommendedImage.ItemsSource = people;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello { firstNameText.Text }");
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
