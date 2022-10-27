using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using PassOfficePP.Pages.AddEditPages;

namespace PassOfficePP.Pages.DataPages
{
    public partial class CategoryPage : Page
    {
        public CategoryPage()
        {
            InitializeComponent();
        }

        private void CategoryPage_OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility != Visibility.Visible) return;
            PassOfficePPDBEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            CategoryDataGrid.ItemsSource =
                PassOfficePPDBEntities.GetContext().Category.ToList().OrderBy(p => p.Name_Category);
        }

        private void BtnDelete_OnClick(object sender, RoutedEventArgs e)
        {
            if (CategoryDataGrid.SelectedCells.Count == 0)
            {
                MessageBox.Show("Сначала выберите строку для удаления!", "Внимание!",
                    MessageBoxButton.OK, MessageBoxImage.Stop);
            }
            else
            {
                var forRemove = CategoryDataGrid.SelectedItems.Cast<Category>().ToList();

                if (MessageBox.Show("Вы точно хотите удалить следующую запись?", "Внимание!",
                        MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes) return;
                try
                {
                    PassOfficePPDBEntities.GetContext().Category.RemoveRange(forRemove);
                    PassOfficePPDBEntities.GetContext().SaveChanges();
                    MessageBox.Show("Информация удалена.", "Успешное удаление данных");

                    CategoryDataGrid.ItemsSource = PassOfficePPDBEntities.GetContext().Category.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
            }
        }

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AddEditCategoryPage(null));
        }

        private void BtnEdit_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AddEditCategoryPage((sender as Button)?.DataContext as Category));
        }
    }
}