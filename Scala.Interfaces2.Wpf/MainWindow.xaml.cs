﻿using System;
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

namespace Scala.Interfaces2.Wpf
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
        void ShowFeedback(string feedback, bool isError = true)
        {
            tbkFeedBack.Visibility = Visibility.Visible;
            tbkFeedBack.Text = feedback;
            tbkFeedBack.Background = isError ? Brushes.IndianRed : Brushes.DeepSkyBlue;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void LstPersons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnGo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
