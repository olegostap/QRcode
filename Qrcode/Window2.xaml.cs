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
using System.Windows.Shapes;

namespace Qrcode
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        //MainWindow secondForm;
        public Window2()
        {
            InitializeComponent();
        }


        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Helow");
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        { 
                this.Close();   
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainWindow secondForm = new MainWindow();
            secondForm.Show();
            this.Close();
        }
    }
}
