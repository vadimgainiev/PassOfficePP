using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using PassOfficePP.Pages.DataPages;

namespace PassOfficePP
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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
    }
}