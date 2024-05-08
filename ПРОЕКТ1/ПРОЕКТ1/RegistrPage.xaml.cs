using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace ПРОЕКТ1

{
    /// <summary>
    /// Логика взаимодействия для RegistrPage.xaml
    /// </summary>
    public partial class RegistrPage : Page
    {
        public RegistrPage()
        {
            InitializeComponent();
        }

        private void buttonGoMain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Frame());
        }

        private void ButtonRegistrGoKab_Click(object sender, RoutedEventArgs e)
        {
          
            NavigationService.Navigate(new PageLichKab());
        }

        private void ButtonRegistGoAvtoriz_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AvtorizPage());
        }
    }
}

