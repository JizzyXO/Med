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

namespace Med
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
        private void CalculateRiskButton_Click(object sender, RoutedEventArgs e)
        {
            int score = CalculateRiskScore();
            double bmi = CalculateBMI(Convert.ToDouble(txtWeight.Text), Convert.ToDouble(txtHeight.Text);
            string riskGroup = DetermineRiskGroup(score, bmi);
            IblResult.Content = "Группа риска (riskGroup)";
        }
        private int CalculateRiskScore()
        {
            int score = 0;
            if(chkPreviousVTE.IsChecked == true) { }
        }
    }
}
