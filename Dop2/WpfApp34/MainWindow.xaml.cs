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
using static System.Math;

namespace WpfApp34
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
        {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            TextBlockAnswer.Items.Clear();
            ListBoxData.Items.Clear();
            int k = -1;
            double[] a = new double[14];
            for (int i = 0; i < 14; i++)
            {
                if (k <= 0)
                {
                    a[i] = 1;
                    k++;
                }
                else
                {
                    a[i] = a[i - 2] + a[i - 1] / Pow(2, i - 1);
                }
                ListBoxData.Items.Add(a[i]);
            }
            double count = 1;
            for (int i = 0; i < 14; i++)
            {
                count *= a[i];
            }
            TextBlockAnswer.Items.Add(count);
        }

        
    }
    }

