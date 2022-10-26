using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using PassOfficePP.Pages.DataPages;

namespace PassOfficePP
{
    public partial class MainWindow : Window
    {
        public MainWindow(User currentUser)
        {
            InitializeComponent();

            if (currentUser.Role_ID == 1)
            {
                ShowCategoryPage.Visibility = Visibility.Visible;
                ShowPostPage.Visibility = Visibility.Visible;
                ShowAccessLevelPage.Visibility = Visibility.Visible;
                ShowWorkPlacePage.Visibility = Visibility.Visible;
                ShowWorkSchedulePage.Visibility = Visibility.Visible;
            }
            else
            {
                ShowCategoryPage.Visibility = Visibility.Hidden;
                ShowPostPage.Visibility = Visibility.Hidden;
                ShowAccessLevelPage.Visibility = Visibility.Hidden;
                ShowWorkPlacePage.Visibility = Visibility.Hidden;
                ShowWorkSchedulePage.Visibility = Visibility.Hidden;
            }
        }

        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void ShowVisitorPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new VisitorsPage();
            Title = "Сотрудники";
        }

        private void ShowAccessLevelPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new AccessLevelPage();
            Title = "Уровни доступа";
        }

        private void ShowPostPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new PostPage();
            Title = "Должности";
        }

        private void ShowCategoryPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new CategoryPage();
            Title = "Категории";
        }

        private void ShowWorkPlacePage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new WorkPlacePage();
            Title = "Места работы";
        }

        private void ShowWorkSchedulePage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new WorkSchedulePage();
            Title = "Графики работы";
        }

        private void ExitBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var loginWindow = new LoginWindow();
            loginWindow.Show();
            Close();
        }
    }
}