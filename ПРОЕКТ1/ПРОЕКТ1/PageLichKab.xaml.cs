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
using static System.Net.Mime.MediaTypeNames;

namespace ПРОЕКТ1
{
    /// <summary>
    /// Логика взаимодействия для PageLichKab.xaml
    /// </summary>
    public partial class PageLichKab : Page
    {
        public PageLichKab()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonGoMain1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Frame());
        }

        private void ButtonGoKursy_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageKursy());
        }
    }
}
