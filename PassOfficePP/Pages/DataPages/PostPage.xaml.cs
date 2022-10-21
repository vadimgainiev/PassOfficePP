using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using PassOfficePP.Pages.AddEditPages;

namespace PassOfficePP.Pages.DataPages
{
    public partial class PostPage : Page
    {
        public PostPage()
        {
            InitializeComponent();
        }

        private void PostPage_OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility != Visibility.Visible) return;
            PassOfficePPDBEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            PostDataGrid.ItemsSource = PassOfficePPDBEntities.GetContext().Post.OrderBy(p => p.Name_Post).ToList();
        }

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AddEditPostPage(null));
        }

        private void BtnDelete_OnClick(object sender, RoutedEventArgs e)
        {
            var forRemove = PostDataGrid.SelectedItems.Cast<Post>().ToList();

            if (MessageBox.Show("Вы точно хотите удалить следующую запись?", "Внимание!",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes) return;
            try
            {
                PassOfficePPDBEntities.GetContext().Post.RemoveRange(forRemove);
                PassOfficePPDBEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация удалена.", "Успешное удаление данных");

                PostDataGrid.ItemsSource = PassOfficePPDBEntities.GetContext().Post.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        private void BtnEdit_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AddEditPostPage((sender as Button)?.DataContext as Post));
        }
    }
}