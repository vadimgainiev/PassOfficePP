using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using PassOfficePP.Pages.AddEditPages;

namespace PassOfficePP.Pages.DataPages
{
    public partial class WorkSchedulePage : Page
    {
        public WorkSchedulePage()
        {
            InitializeComponent();
            //WorkScheduleGrid.ItemsSource = PassOfficePPDBEntities.GetContext().WorkSchedule.ToList();
        }

        private void BtnEdit_OnClick(object sender, RoutedEventArgs e)
        {
            //var addEditWorkSchedulePage = new AddEditWorkSchedulePage((sender as Button)?.DataContext as WorkSchedule);
            //addEditWorkSchedulePage.ShowDialog();
            NavigationService?.Navigate(new AddEditWorkSchedulePage((sender as Button)?.DataContext as WorkSchedule));
        }

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            //var addEditWorkSchedulePage = new AddEditWorkSchedulePage(null);
            //addEditWorkSchedulePage.ShowDialog();
            NavigationService?.Navigate(new AddEditWorkSchedulePage(null));
        }

        private void BtnDelete_OnClick(object sender, RoutedEventArgs e)
        {
            if (WorkScheduleGrid.SelectedCells.Count == 0)
            {
                MessageBox.Show("Сначала выберите строку для удаления!", "Внимание!",
                    MessageBoxButton.OK, MessageBoxImage.Stop);
            }
            else
            {
                var forRemove = WorkScheduleGrid.SelectedItems.Cast<WorkSchedule>().ToList();

                if (MessageBox.Show("Вы точно хотите удалить следующую запись?", "Внимание!",
                        MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes) return;
                try
                {
                    PassOfficePPDBEntities.GetContext().WorkSchedule.RemoveRange(forRemove);
                    PassOfficePPDBEntities.GetContext().SaveChanges();
                    MessageBox.Show("Информация удалена.", "Успешное удаление данных");

                    WorkScheduleGrid.ItemsSource = PassOfficePPDBEntities.GetContext().WorkSchedule.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
            }
        }

        private void WorkSchedulePage_OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility != Visibility.Visible) return;
            PassOfficePPDBEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            WorkScheduleGrid.ItemsSource = PassOfficePPDBEntities.GetContext().WorkSchedule
                .OrderBy(p => p.Name_WorkSchedule).ToList();
        }
    }
}