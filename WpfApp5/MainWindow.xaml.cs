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
using WpfApp5;
namespace WpfApp5
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Purchases pok = new Purchases();
            this.Content = pok;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Buyers buy = new Buyers();
            this.Content = buy;
        }
    }
}