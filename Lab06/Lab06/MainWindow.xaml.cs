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

namespace Lab06
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double NumKQ = 0;
        private double Num1 = 0;
        private double Num2 = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            if (Convert.ToInt32(lblKetQua.Content) == 0)
            {
                lblKetQua.Content = b.Content;
            }
            else
            {
                lblKetQua.Content = lblKetQua.Content.ToString() + b.Content.ToString();
            }
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            lblKetQua.Content = "0";
        }

        private void btnCong_Click(object sender, RoutedEventArgs e)
        {
            NumKQ += Convert.ToDouble(lblKetQua.Content);

            
        }
    }
}
