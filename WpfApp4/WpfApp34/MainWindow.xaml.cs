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
            
            int leng = ListBoxData.Items.Count;
            double[] mass = new double[leng];
            int count = 0;
            for (int i = 0; i < leng; i++)
            {
                mass[i] = Convert.ToInt32(ListBoxData.Items[i]);
            }
            double a = mass[0];
            for (int i = 0; i <= mass[1]-mass[0]; i++)
            {
                if (a % 2 == 0)
                    count++;
                a++;
            }
            TextBlockAnswer.Text = Convert.ToString(count);
            ListBoxData.Items.Clear();
        }

            private void BtnAdd_Click(object sender, RoutedEventArgs e)
            {
            if ((String.IsNullOrEmpty(TbNumber.Text)))
            {
                return;
            }
            try
            {
                int xa = Convert.ToInt32(TbNumber.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ListBoxData.Items.Add(TbNumber.Text);
            }
    }
    }

