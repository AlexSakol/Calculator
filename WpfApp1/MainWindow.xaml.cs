using System.Windows;
using System.Windows.Controls;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a , b, result;
        char? operation;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Number_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text is "0")
                TextBox.Text = (sender as Button)?.Content.ToString();
            else { if (TextBox.Text.Length < 21) TextBox.Text += (sender as Button)?.Content; }
            
        }

        private void Button_Comma_Click(object sender, RoutedEventArgs e)
        { 
            if (!TextBox.Text.Contains(",")) TextBox.Text += ","; 
        }               
        

        private void Button_Erase_Click(object sender, RoutedEventArgs e)
        {
            a = 0;
            b = 0;
            result = 0;
            operation = null;
            TextBox.Text = result.ToString();
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 1)
                TextBox.Text = TextBox.Text.ToString().Substring(0, TextBox.Text.Length - 1);
            else TextBox.Text = "0";
        }
        
        private void Button_Operation_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TextBox.Text.ToString(), out a))
            {
                operation = (sender as Button)?.Content?.ToString()?[0];
                TextBox.Text = "0";
            }
        }

        private void Button_Result_Click(object sender, RoutedEventArgs e)
        {         
            if (double.TryParse(TextBox.Text.ToString(), out b))
            {
                if (operation == '+') result = a + b;
                else if (operation == '-') result = a - b;
                else if (operation == '*') result = a * b;
                else if (operation == '/') result = a / b;          
            }
            TextBox.Text = result.ToString();
        }
    }
}
