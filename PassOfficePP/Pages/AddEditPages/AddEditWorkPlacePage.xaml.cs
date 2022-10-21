using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace PassOfficePP.Pages.AddEditPages
{
    public partial class AddEditWorkPlacePage : Page
    {
        private readonly WorkPlace _currentWorkPlace = new WorkPlace();

        public AddEditWorkPlacePage(WorkPlace selectedWorkPlace)
        {
            InitializeComponent();
            if (selectedWorkPlace != null)
            {
                _currentWorkPlace = selectedWorkPlace;
            }

            DataContext = _currentWorkPlace;
        }

        private void BtnSave_OnClick(object sender, RoutedEventArgs e)
        {
            var errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentWorkPlace.Name_WorkPlace))
                errors.AppendLine("Укажите наименование места работы.");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Ошибка!");
                return;
            }

            if (_currentWorkPlace.ID_WorkPlace == 0)
            {
                PassOfficePPDBEntities.GetContext().WorkPlace.Add(_currentWorkPlace);
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