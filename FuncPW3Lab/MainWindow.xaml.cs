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
using ExFuncs;

namespace FuncPW3Lab
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ex1FindY_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Ex1Y.Text = From1To5.Ex1FindY(Convert.ToDouble(Ex1X.Text)).ToString();
            }
            catch
            {
                BadValMessage();
                Ex1X.Focus();                
            }
        }
        private void BadValMessage()
        {
            MessageBox.Show("Введено некорректно значение!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Ex2FindY_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Ex2Y.Text = From1To5.Ex1FindY(Convert.ToDouble(Ex2X.Text)).ToString();
            }
            catch
            {
                BadValMessage();
                Ex2X.Focus();
            }
        }

        private void Ex3FindS_Click(object sender, RoutedEventArgs e)
        {
            int n;
            double x;
            try
            {
                x = Convert.ToDouble(Ex3X.Text);
            }
            catch
            {
                BadValMessage();
                Ex3X.Focus();
                return;
            }
            try
            {
                n = Convert.ToInt32(Ex3N.Text);
            }
            catch
            {
                BadValMessage();
                Ex3N.Focus();
                return;
            }
            Ex3S.Text = From1To5.Ex3FindS(x, n).ToString();
        }
    }
}
