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

            days = Convert.ToInt32(slDays.Value);
            money = Convert.ToInt32(slSumm.Value);
            addmoney = Convert.ToInt32(slPlus.Value);

            Stabile = Convert.ToDouble((money * 8 * days / 365) / 100);
            Optimale = Convert.ToDouble((money * 5 * days / 365) / 100);
            Standart = Convert.ToDouble((money * 6 * days / 365) / 100);

           tbStability.Text = Stabile.ToString();
            tbOptimal.Text = Optimale.ToString();
            tbStandart.Text = Standart.ToString();

        }
        Int64 money, days, addmoney;

        public double Stabile;
        public double Optimale;
        public double Standart;

     

        private void slAll_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            money = Convert.ToInt32(slSumm.Value);
            if(slDays==null)
            {
                return;
            }
            else
            {
              days = Convert.ToInt32(slDays.Value);
                if (slPlus == null)
                {
                    return;
                }
                else
                {
                  addmoney = Convert.ToInt32(slPlus.Value); 
                  Stabile = Convert.ToDouble((money * 8 * days / 365) / 100);
                  Optimale = Convert.ToDouble((money * 5 * days / 365) / 100);
                  Standart = Convert.ToDouble((money * 6 * days / 365) / 100);
                
                  tbStability.Text = Stabile.ToString();
                  tbOptimal.Text = Optimale.ToString();
                  tbStandart.Text = Standart.ToString();
                }
            
            }
        }

        private void slSumm_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            days = Convert.ToInt32(slDays.Value);
            money = Convert.ToInt32(Money.Text);
            addmoney = Convert.ToInt32(addMoney.Text);

            Stabile = Convert.ToDouble((money * 8 * days / 365) / 100);
            Optimale = Convert.ToDouble((money * 5 * days / 365) / 100);
            Standart = Convert.ToDouble((money * 6 * days / 365) / 100);

            tbStability.Text = Stabile.ToString();
            tbOptimal.Text = Optimale.ToString();
            tbStandart.Text = Standart.ToString();

        }

        private void Exemple(object sender, RoutedEventArgs e)
        {
            Window w = new ComparisonOfparameters();
            w.Show();
        }
      
    }
}
