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
using System.Windows.Shapes;

namespace ProfOlimp
{
    /// <summary>
    /// Логика взаимодействия для ComparisonOfparameters.xaml
    /// </summary>
    public partial class ComparisonOfparameters : Window
    {
        public ComparisonOfparameters()
        {
            InitializeComponent();

            CalculateMoney calculate = new CalculateMoney();
           
            IncomeStability.Text = calculate.Stabile.ToString();
            IncomeOptimale.Text = calculate.Optimale.ToString();
            IncomeStandart.Text = calculate.Standart.ToString();

            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
