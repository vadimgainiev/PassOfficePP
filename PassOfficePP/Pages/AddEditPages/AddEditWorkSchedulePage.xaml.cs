using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace PassOfficePP.Pages.AddEditPages
{
    public partial class AddEditWorkSchedulePage : Page
    {
        private readonly WorkSchedule _currentWorkSchedule = new WorkSchedule();

        public AddEditWorkSchedulePage(WorkSchedule selectedWorkSchedule)
        {
            InitializeComponent();
            if (selectedWorkSchedule != null)
            {
                _currentWorkSchedule = selectedWorkSchedule;
            }

            DataContext = _currentWorkSchedule;
        }

        private void BtnSave_OnClick(object sender, RoutedEventArgs e)
        {
            var errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentWorkSchedule.Name_WorkSchedule))
                errors.AppendLine("Укажите наименование графика работы.");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Ошибка!");
                return;
            }

            if (_currentWorkSchedule.ID_WorkSchedule == 0)
            {
                PassOfficePPDBEntities.GetContext().WorkSchedule.Add(_currentWorkSchedule);
            }

            try
            {
                PassOfficePPDBEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена.", "Успешное выполнение операции");
                NavigationService?.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }
    }
}