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
using WpfHotel1.Windows;

namespace WpfHotel1.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
            cb1.ItemsSource = ClassHelper.Entities.Context.Gender.ToList();
            cb1.SelectedIndex = 0;
            cb1.DisplayMemberPath = "NameOfGender";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb1.Text))
            {
                MessageBox.Show("Поле логин должно быть заполнено", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(tb2.Text))
            {
                MessageBox.Show("Поле пароль должно быть заполнено", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(tb3.Text))
            {
                MessageBox.Show("Поле фамилия должно быть заполнено", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(tb4.Text))
            {
                MessageBox.Show("Поле имя должно быть заполнено", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(tb6.Text))
            {
                MessageBox.Show("Поле телефон должно быть заполнено", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(tb8.Text))
            {
                MessageBox.Show("Поле серия паспорта должно быть заполнено", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(tb9.Text))
            {
                MessageBox.Show("Поле номер паспорта должно быть заполнено", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            Entities.Context.User.Add(new User
            {
                Login = tb1.Text,
                Password = tb2.Text,
            });

            Entities.Context.SaveChanges();
            var user = Entities.Context.User.Where(x => x.Login == tb1.Text && x.Password == tb2.Text).FirstOrDefault();
            

            Entities.Context.Client.Add(new Client
            {
                FirstName = tb3.Text,
                LastName = tb4.Text,
                Patronymic = tb5.Text,
                IdGender = (cb1.SelectedItem as Gender).IdGender,
                Phone = tb6.Text,
                Email = tb7.Text,
                PassportSeries = tb8.Text,
                PassportNumber = tb9.Text,
                IdUser = user.IdUser
            }
                ) ;

            Entities.Context.SaveChanges();
            MessageBox.Show("Регистрация прошла успешно!");
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            AutorizationWindow autorizationWindow = new AutorizationWindow();
            autorizationWindow.Show();
            this.Close();
        }

        private void tb1_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void tb1_GotFocus(object sender, RoutedEventArgs e)
        {
            tb1.Text = "";
        }

        private void tb2_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void tb2_GotFocus(object sender, RoutedEventArgs e)
        {
            tb2.Text = "";
        }

        private void tb3_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void tb3_GotFocus(object sender, RoutedEventArgs e)
        {
            tb3.Text = "";
        }

        private void tb4_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void tb4_GotFocus(object sender, RoutedEventArgs e)
        {
            tb4.Text = "";
        }

        private void tb5_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void tb5_GotFocus(object sender, RoutedEventArgs e)
        {
            tb5.Text = "";
        }

        private void tb6_GotFocus(object sender, RoutedEventArgs e)
        {
            tb6.Text = "";
        }

        private void tb7_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void tb7_GotFocus(object sender, RoutedEventArgs e)
        {
            tb7.Text = "";
        }

        private void tb8_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void tb8_GotFocus(object sender, RoutedEventArgs e)
        {
            tb8.Text = "";
        }

        private void tb9_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void tb9_GotFocus(object sender, RoutedEventArgs e)
        {
            tb9.Text = "";
        }
    }
}
