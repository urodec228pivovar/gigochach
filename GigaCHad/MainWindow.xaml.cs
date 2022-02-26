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


namespace GigaCHad
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            GraphBT.Visibility = Visibility.Hidden;
            Uroki.Visibility = Visibility.Hidden;
            PassKursBT.Visibility = Visibility.Hidden;
            OtchetBT.Visibility = Visibility.Hidden;
            AllKurseBT.Visibility = Visibility.Hidden;
            AddKurseBT.Visibility = Visibility.Hidden;

        }

        private void LoginBT_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTB.Text == "adm")
                if (PasswordPB.Password == "123")
                {
                    GraphBT.Visibility = Visibility.Visible;
                    Uroki.Visibility = Visibility.Visible;
                    PassKursBT.Visibility = Visibility.Visible;
                    OtchetBT.Visibility = Visibility.Visible;
                    AllKurseBT.Visibility = Visibility.Visible;
                    AddKurseBT.Visibility = Visibility.Visible;

                    LogLabel.Visibility = Visibility.Hidden;
                    LoginPanel.Visibility = Visibility.Hidden;
                    
                    LoginTB.Text = "";
                    PasswordPB.Password = "";

                }

                else
                    MessageBox.Show("Неверный");
            
                MessageBox.Show("Неверный");

            if (LoginTB.Text == "user")
                if (PasswordPB.Password == "123")
                {
                    GraphBT.Visibility = Visibility.Visible;
                    Uroki.Visibility = Visibility.Visible;
                    PassKursBT.Visibility = Visibility.Visible;
                    OtchetBT.Visibility = Visibility.Visible;



                    LogLabel.Visibility = Visibility.Hidden;
                    LoginPanel.Visibility = Visibility.Hidden;

                    LoginTB.Text = "";
                    PasswordPB.Password = "";

                }
                
             else
                    MessageBox.Show("Неверный");
            else
                MessageBox.Show("Неверный");
  


        }

        private void ExitBT_Click(object sender, RoutedEventArgs e)
        {
            GraphBT.Visibility = Visibility.Hidden;
            Uroki.Visibility = Visibility.Hidden;
            PassKursBT.Visibility = Visibility.Hidden;
            OtchetBT.Visibility = Visibility.Hidden;
            AllKurseBT.Visibility = Visibility.Hidden;
            AddKurseBT.Visibility = Visibility.Hidden;
            LogLabel.Visibility = Visibility.Visible;
            LoginPanel.Visibility = Visibility.Visible;

            LoginTB.Text = "";
            PasswordPB.Password = "";
        }

        private void GraphBT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PassKursBT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Uroki_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
