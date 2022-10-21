using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using PassOfficePP.Pages.AddEditPages;
using PassOfficePP.Pages.CompareExcelDataPages;
using PassOfficePP.Pages.ExportPages;

namespace PassOfficePP.Pages.DataPages
{
    public partial class VisitorsPage : Page
    {
        public VisitorsPage()
        {
            InitializeComponent();

            VisitorProfile.Visibility = Visibility.Hidden;

            UpdateVisitors();
        }

        private void UpdateVisitors()
        {
            var currentVisitors = PassOfficePPDBEntities.GetContext().Visitor.ToList();

            currentVisitors = currentVisitors.Where(p =>
                p.Surname.ToLower().Contains(SearchTextBox.Text.ToLower())).ToList();

            VisitorsGrid.ItemsSource = currentVisitors.OrderBy(p => p.Surname).ToList();
        }

        private void BtnEdit_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AddEditVisitorPage((sender as Button)?.DataContext as Visitor));
        }

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AddEditVisitorPage(null));
        }

        private void BtnDelete_OnClick(object sender, RoutedEventArgs e)
        {
            if (VisitorsGrid.SelectedCells.Count == 0)
            {
                MessageBox.Show("Сначала выберите строку для удаления!", "Внимание!",
                    MessageBoxButton.OK, MessageBoxImage.Stop);
            }
            else
            {
                var forRemove = VisitorsGrid.SelectedItems.Cast<Visitor>().ToList();

                if (MessageBox.Show("Вы точно хотите удалить следующую запись?", "Внимание!",
                        MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes) return;
                try
                {
                    PassOfficePPDBEntities.GetContext().Visitor.RemoveRange(forRemove);
                    PassOfficePPDBEntities.GetContext().SaveChanges();
                    MessageBox.Show("Информация удалена.", "Успешное удаление данных");

                    VisitorsGrid.ItemsSource = PassOfficePPDBEntities.GetContext().Visitor.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void VisitorsGrid_OnSelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            VisitorProfile.Visibility = VisitorsGrid.SelectedItem != null ? Visibility.Visible : Visibility.Hidden;
        }

        private void VisitorsPage_OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility != Visibility.Visible) return;
            PassOfficePPDBEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            VisitorsGrid.ItemsSource = PassOfficePPDBEntities.GetContext().Visitor.ToList().OrderBy(p => p.Surname);
            //VisitorsGrid.SelectedIndex = -1;
        }

        private void SearchTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateVisitors();
        }

        private void BtnExportToExcel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new ExportVisitorsPage());
        }

        private void CompareBtn_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new CompareVisitorsExcelData());
        }
    }
}