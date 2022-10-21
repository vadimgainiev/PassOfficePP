using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using PassOfficePP.Pages.AddEditPages;

namespace PassOfficePP.Pages.DataPages
{
    public partial class WorkPlacePage : Page
    {
        public WorkPlacePage()
        {
            InitializeComponent();
            //WorkPlaceDataGrid.ItemsSource = PassOfficePPDBEntities.GetContext().WorkSchedule.ToList();
        }

        private void WorkPlacePage_OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility != Visibility.Visible) return;
            PassOfficePPDBEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            WorkPlaceDataGrid.ItemsSource = PassOfficePPDBEntities.GetContext().WorkPlace.ToList().
                OrderBy(p => p.Name_WorkPlace);
        }

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AddEditWorkPlacePage(null));
        }

        private void BtnDelete_OnClick(object sender, RoutedEventArgs e)
        {
            var forRemove = WorkPlaceDataGrid.SelectedItems.Cast<WorkPlace>().ToList();

            if (MessageBox.Show("Вы точно хотите удалить следующую запись?", "Внимание!",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes) return;
            try
            {
                PassOfficePPDBEntities.GetContext().WorkPlace.RemoveRange(forRemove);
                PassOfficePPDBEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация удалена.", "Успешное удаление данных");

                WorkPlaceDataGrid.ItemsSource = PassOfficePPDBEntities.GetContext().WorkPlace.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        private void BtnEdit_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AddEditWorkPlacePage((sender as Button)?.DataContext as WorkPlace));
        }
    }
}