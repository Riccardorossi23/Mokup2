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

namespace Mokup2
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            txtslider1.IsEnabled = true;
            txtslider2.IsEnabled = true;
            txtNum2.IsEnabled = true;
            txtNum1.IsEnabled = true;
            txtSum.IsEnabled = true;

        }
        private void check_Unchecked(object sender, RoutedEventArgs e)
        {
            txtslider1.IsEnabled = false;
            txtslider2.IsEnabled = false;
            txtNum2.IsEnabled = false;
            txtNum1.IsEnabled = false;
            txtSum.IsEnabled = false;
        }

        private void txtSum_TextChanged(object sender, TextChangedEventArgs e)
        {

            
        }
        private void txtslider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int numero1 = (int)txtslider1.Value;
            txtNum1.Text = numero1.ToString();
            int numero2 = (int)txtslider2.Value;
            txtNum2.Text = numero2.ToString();
            int somma = numero1 + numero2;
            txtNum2.Text = txtslider2.Value.ToString();
        }

        private void txtNum2_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void txtslider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int numero1 = (int)txtslider1.Value;
            txtNum1.Text = numero1.ToString();
            int numero2 = (int)txtslider2.Value;
            txtNum2.Text = numero2.ToString();
            int somma = numero1 + numero2;
            txtSum.Text = somma.ToString();
            txtNum1.Text = txtslider1.Value.ToString();
        }
    }
}
             
    
