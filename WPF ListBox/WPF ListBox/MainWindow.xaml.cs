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
using WPF_ListBox.Data;

namespace WPF_ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>   
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>
        {
            new Person{Name = "Tim", Age = 51},
            new Person{Name = "Ted", Age = 41},
            new Person{Name = "Joe", Age = 64},
            new Person{Name = "Jack", Age = 24},
            new Person{Name = "Mic", Age = 34},
        };
        public MainWindow()
        {
            InitializeComponent();

            ListBoxPeople.ItemsSource = People;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxPeople.SelectedItems;
            foreach (var selectedItem in selectedItems)
            {
                var person = (Person)selectedItem;
                MessageBox.Show(person.Name);
            }
        }
    }
}