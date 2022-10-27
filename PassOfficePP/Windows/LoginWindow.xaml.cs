using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace PassOfficePP
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var context = new PassOfficePPDBEntities();
            var user = context.User.FirstOrDefault(p => p.Login_User == LoginTb.Text
                                                        && p.Password_User == PassPb.Password);
            var mainWindow = new MainWindow(user);

            try
            {
                if (user == null)
                {
                    MessageBox.Show("Такого пользователя не существует!", "Ошибка авторизации",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    switch (user.Role_ID)
                    {
                        case 1:
                            MessageBox.Show("Авторизация в качестве системного администратора.",
                                "Успешная авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                            Close();
                            mainWindow.Show();
                            break;
                        case 2:
                            MessageBox.Show("Авторизация в качестве сотрудника отдела безопасности.",
                                "Успешная авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                            Close();
                            mainWindow.Show();
                            break;
                        default:
                            MessageBox.Show("Данные не обнаружены!", "Ошибка авторизации",
                                MessageBoxButton.OK, MessageBoxImage.Exclamation);
                            break;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}