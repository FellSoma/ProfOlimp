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
    /// Логика взаимодействия для CalculateMoney.xaml
    /// </summary>
    public partial class CalculateMoney : Window
    {
        public CalculateMoney()
        {
            InitializeComponent();



        }
        Int64 money, days, addmoney;

        private void Next(object sender, RoutedEventArgs e)
        {
            DataBase.Stability = tbStability.Text;
            DataBase.Optimale = tbOptimal.Text;
            DataBase.Standart = tbStandart.Text;
            ComparisonOfparameters w = new ComparisonOfparameters();
            w.Show();
        }


        public double Stabile;
        public double Optimale;
        public double Standart;
        public int a;
        public void Exemple(object sender, RoutedEventArgs e)
        {
            days = Convert.ToInt32(slDays.Value);
            money = Convert.ToInt32(Money.Text);
            addmoney = Convert.ToInt32(addMoney.Text);

            Stabile = Convert.ToDouble((money * 8 * days / 365) / 100);
            Optimale = Convert.ToDouble((money * 5 * days / 365) / 100);
            Standart = Convert.ToDouble((money * 6 * days / 365) / 100);

            tbStability.Text = "0";
            tbOptimal.Text = "0";
            tbStandart.Text = "0";

            tbStability.Text = Stabile.ToString();
            tbOptimal.Text = Optimale.ToString();
            tbStandart.Text = Standart.ToString();
        }
    }
}
