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
        Int64 money,days,addmoney;
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
                 Stabile = Convert.ToDouble((money * 8 * days/365)/100);
                 Optimale = Convert.ToDouble((money * 5 * days / 365) / 100);
                 Standart = Convert.ToDouble((money * 6 * days / 365) / 100);

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
      
    }
}
