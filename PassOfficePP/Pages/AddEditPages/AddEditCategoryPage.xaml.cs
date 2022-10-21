using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace PassOfficePP.Pages.AddEditPages
{
    public partial class AddEditCategoryPage : Page
    {
        private readonly Category _currentCategory = new Category();

        public AddEditCategoryPage(Category selectedCategory)
        {
            InitializeComponent();
            if (selectedCategory != null)
            {
                _currentCategory = selectedCategory;
            }

            DataContext = _currentCategory;
        }

        private void BtnSave_OnClick(object sender, RoutedEventArgs e)
        {
            var errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentCategory.Name_Category))
                errors.AppendLine("Укажите наименование категории.");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Ошибка!");
                return;
            }

            if (_currentCategory.ID_Category == 0)
            {
                PassOfficePPDBEntities.GetContext().Category.Add(_currentCategory);
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