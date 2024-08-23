using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows;

namespace WpfApp5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateSum_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Mixed Number 1
                int whole1 = int.Parse(Whole1.Text);
                int num1 = int.Parse(Num1.Text);
                int den1 = int.Parse(Den1.Text);

                // Mixed Number 2
                int whole2 = int.Parse(Whole2.Text);
                int num2 = int.Parse(Num2.Text);
                int den2 = int.Parse(Den2.Text);

                if (den1 == den2)
                {
                    WholeRezult.Text = (whole1 + whole2).ToString();
                    NumRezult.Text = (num1 + num2).ToString();
                    DenRezult.Text = (den1 + den2).ToString();
                }
                else if (den1 != den2)
                {
                    WholeRezult.Text = (whole1 + whole2).ToString();
                    DenRezult.Text = (den1 * den2).ToString();
                    NumRezult.Text = ((den2 * num1) + (den1 * num2)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Whole1.Text = null; Whole2.Text = null;
            Den1.Text = null; Den2.Text = null;
            Num1.Text = null; Num2.Text = null;
            WholeRezult.Text = null;
            NumRezult.Text = null;
            DenRezult.Text = null;
        }
    }
}
