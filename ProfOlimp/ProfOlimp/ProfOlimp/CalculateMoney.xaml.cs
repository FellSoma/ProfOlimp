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
        int money,days,addmoney;
        double Stabile;
        double Optimale;

        private void Exemple(object sender, RoutedEventArgs e)
        {

            try
            {
                days = Convert.ToInt32(slDays.Value);
                money = Convert.ToInt32(Money.Text);
                addmoney = Convert.ToInt32(addMoney.Text);

            }
            catch (Exception)
            {

               
            }

            try
            {
                 Stabile = money * 0.08;
                 Optimale = money * 0.05;
                 Standart =money * 0.06;

            }
            catch (Exception)
            {

               
            }
            try
            {

                tbStability.Text = "0";
                tbOptimal.Text = "0";
                tbStandart.Text = "0";

                tbStability.Text = Stabile.ToString();
                tbOptimal.Text = Optimale.ToString();
                tbStandart.Text = Standart.ToString();
            
            }
            catch (Exception)
            {

                
            }
        }

        double Standart;
        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
