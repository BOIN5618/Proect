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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ПРОЕКТ1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection sqlConnection = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonVoiti_Click(object sender, RoutedEventArgs e)
        {
            AvtorizPage avtorizPage = new AvtorizPage();

            // Переходим на новую страницу
            this.mainFrame.Content = avtorizPage;
        }
        private void ButtonGoOproecte_Click(object sender, RoutedEventArgs e)
        {
            OproectePage oproectePage = new OproectePage();

            this.mainFrame.Content = oproectePage;
        }

        private void mainFrame_Navigated(object sender, NavigationEventArgs e)
        {
           
        }
    }
}
