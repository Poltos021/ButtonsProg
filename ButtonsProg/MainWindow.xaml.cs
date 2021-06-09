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
using System.Windows.Shapes;

namespace ButtonsProg
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CheckBox check4;
        public MainWindow()
        {
            InitializeComponent();

            check4 = new CheckBox
            {
                Content = "Конструктор",
                IsChecked = null,
                IsThreeState = true,
            };

            check4.Checked += CheckBox_ChangeState;
            check4.Unchecked += CheckBox_ChangeState;
            check4.Indeterminate += CheckBox_ChangeState;
            sp.Children.Add(check4);
        }

        private void entarBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Операция выполнена!");
        }

        private void escapeBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Repeat_Click(object sender, RoutedEventArgs e)
        {
            int score = Int32.Parse(Score.Text);
            score++;
            Score.Text = score.ToString();
        }

        private void CheckBox_ChangeState(object sender, RoutedEventArgs e)
        {
            string state = "Пусто";
            switch (check4.IsChecked)
            {
                case true: state = "нажата"; break;
                case false: state = "снять"; break;
            }

            MessageBox.Show("check4 перешел в состояние " + state);
        }

        private void Check1_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((CheckBox)sender).Name + " Рикошет");
        }
        private void Check1_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((CheckBox)sender).Name + " Попал");
        }

        private void Check2_Indeterminate(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((CheckBox)sender).Name + " WHO??");
        }

    }
}
