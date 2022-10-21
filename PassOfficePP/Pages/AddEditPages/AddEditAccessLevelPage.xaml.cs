using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace PassOfficePP.Pages.AddEditPages
{
    public partial class AddEditAccessLevelPage : Page
    {
        private readonly AccessLevel _currentAccessLevel = new AccessLevel();

        public AddEditAccessLevelPage(AccessLevel selectedAccessLevel)
        {
            InitializeComponent();
            if (selectedAccessLevel != null)
            {
                _currentAccessLevel = selectedAccessLevel;
            }

            DataContext = _currentAccessLevel;
        }

        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }

        private void BtnSave_OnClick(object sender, RoutedEventArgs e)
        {
            var errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentAccessLevel.AccessLevel_Name))
                errors.AppendLine("Укажите наименование уровня доступа.");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Ошибка!");
                return;
            }

            if (_currentAccessLevel.ID_AccessLevel == 0)
            {
                PassOfficePPDBEntities.GetContext().AccessLevel.Add(_currentAccessLevel);
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
    }
}