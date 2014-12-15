using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPFCalc
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

        private void WrapPanel_Click(object sender, RoutedEventArgs e)
        {
            Debug.Write("");

            Button b = e.Source as Button;
            if (b is Button)
            {
                com.dneonline.www.Calculator calc = new com.dneonline.www.Calculator();

                Debug.WriteLine(b.Content.ToString());
                int x = Convert.ToInt32(txt1.Text);
                int y = Convert.ToInt32(txt2.Text);
                int result = 0;
                switch (b.Content.ToString())
                {
                    case "/":
                        if (y == 0)
                        {
                            MessageBox.Show("Cant divide by zero");
                            return;
                        }
                        else
                            result = calc.Divide(x, y);
                        break;
                    case "X":
                        result = calc.Multiply(x, y);
                        break;
                    case "-":
                        result = calc.Subtract(x, y);
                        break;
                    case "+":
                        result = calc.Add(x, y);
                        break;
                    default:
                        break;
                }
                MessageBox.Show(result.ToString(), "result", MessageBoxButton.OK);
            }
        }
    }
}
