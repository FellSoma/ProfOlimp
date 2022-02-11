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

            StabilityFinal.Text = DataBase.SumStabile.ToString();
            OptimaleFinal.Text = DataBase.SumOptimale.ToString();
            StandartFinal.Text = DataBase.SumStandart.ToString();
            IncomeStability.Text = DataBase.Stability;
            IncomeOptimale.Text = DataBase.Optimale;
            IncomeStandart.Text = DataBase.Standart;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
