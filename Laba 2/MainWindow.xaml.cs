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

namespace Laba_2
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var product = new Product(
                Convert.ToInt32(quantity.Text),
                Convert.ToInt32(price.Text));

            var mark = new Markers(
                Convert.ToString(name_Copy.Text),
                Convert.ToInt32(quantity_Copy.Text),
                Convert.ToInt32(price_Copy.Text),
                Convert.ToInt32(sort.Text));

            total.Content = product.GetTotalPrice().ToString();
            total_Copy.Content = mark.GetTotalPrice().ToString();
        }
    }
}
