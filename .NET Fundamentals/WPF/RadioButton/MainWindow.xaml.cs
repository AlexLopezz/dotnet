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

namespace RadioButton
{
    public partial class MainWindow : Window
    {
        string messageResult;
        public MainWindow()
        {
            InitializeComponent();
            messageResult = txbResultCalc.Text;
        }

        private void bttCalcularCalc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int value1 = int.Parse(txtValor1Calc.Text);
                int value2 = int.Parse(txtValor2Calc.Text);

                int result= 0;

                if (rdSum.IsChecked==true) result = Calculator.sum(value1, value2);
                if(rdSubstract.IsChecked == true) result = Calculator.substract(value1, value2);
                if (rdMulti.IsChecked==true) result = Calculator.multiplication(value1, value2);
                if(rdDiv.IsChecked==true) result = Calculator.division(value1, value2);

                txbResultCalc.Text = $"El resultado es: {result}";

            }catch(FormatException)
            {
                MessageBox.Show("No se puede calcular letras, ni simbolos especiales(tampoco, la nada misma)");
                txtValor1Calc.Text = string.Empty;
                txtValor2Calc.Text = string.Empty;
                txbResultCalc.Text = messageResult;
            }
        }

        private void bttConvert_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }catch(FormatException)

        }


    }
}
