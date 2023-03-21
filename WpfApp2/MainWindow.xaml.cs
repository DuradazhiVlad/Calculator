using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {      
            DataTable dataTable = new DataTable();
            double b;
            string a=t.Text;
            object result = dataTable.Compute(a, "");
            //=double.Parse(a);

            t2.Text += result;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int a;
            a = 1;
            t.Text += a.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int a;
            a = 2;
            t.Text += a.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int a;
            a = 3;               
            t.Text += a.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int a;
            a = 4;
            t.Text += a.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int a;
            a = 5;
            t.Text += a.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            int a;
            a = 6;
            t.Text += a.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            int a;
            a = 7;
            t.Text += a.ToString();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            int a;
            a = 8;
            t.Text += a.ToString();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            int a;
            a = 9;
            t.Text += a.ToString();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            string a;
            a = "+";
            t.Text += a.ToString();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            t.Clear();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            t2.Clear();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (t2.Text != "") 
            {
                t2.Undo();
            }
            else if(t.Text != "") t.Undo();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            string a;
            a = "-";
            t.Text += a.ToString();
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            string a;
            a = "*";
            t.Text += a.ToString();
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            string a;
            a = "/";
            t.Text += a.ToString();
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            string a;
            a = ".";
            t.Text += a.ToString();
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            int a;
            a = 0;
            t.Text += a.ToString();
        }
    }
}
