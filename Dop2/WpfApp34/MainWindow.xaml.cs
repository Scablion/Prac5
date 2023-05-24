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
        public int Factorial(int numb)
        {
            int res = 1;
            for (int i = numb; i > 1; i--)
                res *= i;
            return res;
        }
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
            
            double S = 0;
            int leng = ListBoxData.Items.Count;
            double[] mass = new double[leng];

            for (int i = 0; i < leng; i++)
                mass[i] = Convert.ToDouble(ListBoxData.Items[i]);
            double a = mass[0];
                if (leng == 2)
                {
                    for (int i = 1; i > 0; i++)
                    {
                        if (a == 1)
                        {
                            S += 1 / Pow(i, 2); 
                        }
                        else if (a == 2)
                        {
                            S += 1 / (i*(i+1));
                        }
                        else if (a == 3)
                        {
                            S += Pow(-1, i)/ Factorial(i);
                        }
                        else if (a == 4)
                        {
                            S += Pow(-2, i) / Factorial(i);
                        }
                        else if (a == 5)
                        {
                            S += Pow(-1, i + 1) / (i * (i + 1) * (i + 2));
                        }
                        else
                        {
                            S += 1 / (Pow(4, i) + Pow(5, i) + 2); 
                        }
                        if (S >= Abs(mass[1]))
                        {
                            TextBlockAnswer.Text = Convert.ToString(S);
                            ListBoxData.Items.Clear();
                            return; 
                        }
                    }
                    
                }
                else
                    MessageBox.Show("Введено более 2 значения");
            
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(TbNumber.Text)))
            {
                return;
            }
            try
            {
                double xa = Convert.ToDouble(TbNumber.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            ListBoxData.Items.Add(TbNumber.Text);
        }
    }
}

