﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Data_Binding.Data;

namespace WPF_Data_Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person
        {
            Name = "Tim",
            Age = 16,
        };
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = person;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string personData = $"{person.Name} is {person.Age} years old.";
            MessageBox.Show(personData);
        }
    }
}