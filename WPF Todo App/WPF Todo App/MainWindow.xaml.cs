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

namespace WPF_Todo_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddTodoButton_Click(object sender, RoutedEventArgs e)
        {
            string todoText = TodoInput.Text;

            if (!string.IsNullOrEmpty(todoText)) 
            {
                TextBlock todoItem = new TextBlock
                {
                    Text = todoText
                };

                TodoList.Children.Add(todoItem);

                TodoInput.Clear();
            }
        }
    }
}