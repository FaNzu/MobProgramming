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

namespace WPFSimpleGui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] Labels = new string[4]; 
        public MainWindow()
        {
            InitializeComponent();
            Labels[0] = tbLine1.Text;
            Labels[1] = tbLine2.Text;
            Labels[2] = tbLine3.Text;
            Labels[3] = tbLine4.Text;
        }

        private void TextBox_1(object sender, TextChangedEventArgs e)
        {


        }
        private void TextBox_2(object sender, TextChangedEventArgs e)
        {

        }
        private void TextBox_3(object sender, TextChangedEventArgs e)
        {

        }
        private void TextBox_4(object sender, TextChangedEventArgs e)
        {

        }


        private void Button_Up(object sender, RoutedEventArgs e)
        {
            String temp = tbLine1.Text;
            tbLine1.Text = tbLine2.Text;
            tbLine2.Text = tbLine3.Text;
            tbLine3.Text = tbLine4.Text;
            tbLine4.Text = temp;
        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            tbLine1.Text = Labels[0];
            tbLine2.Text = Labels[1];
            tbLine3.Text = Labels[2];
            tbLine4.Text = Labels[3];
        }

        private void Button_Down(object sender, RoutedEventArgs e)
        {
            String temp = tbLine4.Text;
            tbLine4.Text = tbLine3.Text;
            tbLine3.Text = tbLine2.Text;
            tbLine2.Text = tbLine1.Text;
            tbLine1.Text = temp;
        }

    }
}
