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
            int[] mass = new int[leng];
            for (int i = 0; i < leng; i++)
                mass[i] = Convert.ToInt32(ListBoxData.Items[i]);
            int a = mass[0], b = mass[1];
            double count = 0;
            if (leng == 2)
            {
                for (int i = 1; i <= b; i++)
                {
                    count = Pow(a, i);
                    TextBlockAnswer.Text += Convert.ToString($"{a} в {i} степени = " + count + "\n");
                }

            }
            else
                MessageBox.Show("Введено более 1 значения");

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

