using BlackJackClient.ServiceReference1;
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

namespace BlackJackClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CallbackHandler ch = new CallbackHandler();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btReady_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btOneMore_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btPass_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
