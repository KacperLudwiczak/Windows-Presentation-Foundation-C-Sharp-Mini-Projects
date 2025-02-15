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

namespace WPF_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button myButton = new Button();
            myButton.Content = "Button B";

            Grid.SetRow(myButton, 3);
            Grid.SetColumn(myButton, 4);

            Grid myGrid = (Grid)FindName("myGrid");
            myGrid.Children.Add(myButton);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am the Button A.");
        }
    }
}