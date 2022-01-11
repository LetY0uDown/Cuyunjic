using StringMath;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Куюнджик
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
            textBox.Text += $"{(sender as Button).Tag}";
        }

        private void bDEL_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textResult.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Calculator calculator = new Calculator();
            try
            {
                double result = calculator.Evaluate(textBox.Text);
                textResult.Text = "= " + result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Вы ввели фигню");
            }
        }
    }
}
