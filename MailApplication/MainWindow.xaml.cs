using MailApplication.Models;
using MailApplication.Services;
using MailApplication.ViewModels;
using MailApplication.Views;
using MailApplication.Utility;
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

namespace MailApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AppViewModel app = new AppViewModel();
        public MainWindow()
        {
            InitializeComponent();          
        }

        private void btnContacts_Click(object sender, RoutedEventArgs e)
        {
            string con = "Contact";
            DataContext = new AppViewModel(con);
        }

        private void btnMessages_Click(object sender, RoutedEventArgs e)
        {
            string mes = "Message";
            DataContext = new AppViewModel(mes);
        }

        private void btnSetting_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
