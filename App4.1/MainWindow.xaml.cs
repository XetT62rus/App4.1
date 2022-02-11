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

namespace App4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            Double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            Double resDouble = rateEuro * sumEuro;
            resSum1.Text = resDouble.ToString();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGrivna = Convert.ToDouble(rate2.Text);
            double sumGrivna = Convert.ToDouble(sum2.Text);
            Double resDouble = rateGrivna * sumGrivna;
            resSum2.Text = resDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDrama = Convert.ToDouble(rate3.Text);
            double sumDrama = Convert.ToDouble(sum3.Text);
            Double resDouble = rateDrama * sumDrama;
            resSum3.Text = resDouble.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rast = Convert.ToDouble(length.Text);
            double metr = rast * 0.0254;
            result.Text = metr.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rast1 = Convert.ToDouble(length1.Text);
            double metr1 = rast1 * 0.3048;
            result1.Text = metr1.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rast2 = Convert.ToDouble(length2.Text);
            double metr2 = rast2 * 1609;
            result2.Text = metr2.ToString();
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rast3 = Convert.ToDouble(length3.Text);
            double metr3 = rast3 * 1066.8;
            result3.Text = metr3.ToString();
        }
    }
}
