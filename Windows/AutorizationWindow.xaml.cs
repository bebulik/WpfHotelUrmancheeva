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
using WpfHotel1.ClassHelper;
using WpfHotel1.DB;

namespace WpfHotel1.Windows
{
    /// <summary>
    /// Логика взаимодействия для AutorizationWindow.xaml
    /// </summary>
    public partial class AutorizationWindow : Window
    {
        public AutorizationWindow()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            this.Close();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            var Auth = Entities.Context.User.Where(x => x.Login == tb2.Text && x.Password == tb1.Password).FirstOrDefault();
            if (Auth != null)
            {
                MessageBox.Show("ОК!");
                MainWindow Bebra = new MainWindow();
                Bebra.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Пользователь не существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            }
        }
    }

