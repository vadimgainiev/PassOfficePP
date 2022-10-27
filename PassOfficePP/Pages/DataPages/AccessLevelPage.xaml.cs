using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using PassOfficePP.Pages.AddEditPages;

namespace PassOfficePP.Pages.DataPages
{
    public partial class AccessLevelPage : Page
    {
        public AccessLevelPage()
        {
            InitializeComponent();
        }

        private void AccessLevelPage_OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility != Visibility.Visible) return;
            PassOfficePPDBEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            AccessLevelDataGrid.ItemsSource = PassOfficePPDBEntities.GetContext().AccessLevel.ToList()
                .OrderBy(p => p.AccessLevel_Name);
        }

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AddEditAccessLevelPage(null));
        }

        private void BtnDelete_OnClick(object sender, RoutedEventArgs e)
        {
            if (AccessLevelDataGrid.SelectedCells.Count == 0)
            {
                MessageBox.Show("Сначала выберите строку для удаления!", "Внимание!",
                    MessageBoxButton.OK, MessageBoxImage.Stop);
            }
            else
            {
                var forRemove = AccessLevelDataGrid.SelectedItems.Cast<AccessLevel>().ToList();

                if (MessageBox.Show("Вы точно хотите удалить следующую запись?", "Внимание!",
                        MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes) return;
                try
                {
                    PassOfficePPDBEntities.GetContext().AccessLevel.RemoveRange(forRemove);
                    PassOfficePPDBEntities.GetContext().SaveChanges();
                    MessageBox.Show("Информация удалена.", "Успешное удаление данных");

                    AccessLevelDataGrid.ItemsSource = PassOfficePPDBEntities.GetContext().AccessLevel.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
            }
        }

        private void BtnEdit_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AddEditAccessLevelPage((sender as Button)?.DataContext as AccessLevel));
        }
    }
}