using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace PassOfficePP.AddEditWindows
{
    public partial class AddEditVisitorWindow : Window
    {
        private Visitor _currentVisitor = new Visitor();

        public AddEditVisitorWindow()
        {
            InitializeComponent();
            DataContext = _currentVisitor;

            CategoryComboBox.ItemsSource = PassOfficePPDBEntities.GetContext().Category.ToList();
            PostComboBox.ItemsSource = PassOfficePPDBEntities.GetContext().Post.ToList();
            AccessLevelComboBox.ItemsSource = PassOfficePPDBEntities.GetContext().AccessLevel.ToList();
            WorkPlaceComboBox.ItemsSource = PassOfficePPDBEntities.GetContext().WorkPlace.ToList();
            WorkScheduleComboBox.ItemsSource = PassOfficePPDBEntities.GetContext().WorkSchedule.ToList();
        }

        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnSave_OnClick(object sender, RoutedEventArgs e)
        {
            var errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentVisitor.Surname))
                errors.AppendLine("Укажите фамилию сотрудника.");
            if (string.IsNullOrWhiteSpace(_currentVisitor.Name))
                errors.AppendLine("Укажите имя сотрудника.");
            //if (_currentVisitor.WorkPlace.Name == null)
            //    errors.AppendLine("Выберите должность.");
            //if (_currentVisitor.Category.Name == null)
            //    errors.AppendLine("Выберите филиал");
            //if (_currentVisitor.WorkSchedule.Name == null)
            //    errors.AppendLine("Выберите должность.");
            //if (_currentVisitor.Post.Name == null)
            //    errors.AppendLine("Выберите должность.");
            //if (_currentVisitor.AccessLevel.Name == null)
            //    errors.AppendLine("Выберите должность.");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Ошибка!");
                return;
            }

            if (_currentVisitor.ID_Visitor == Guid.Empty)
            {
                PassOfficePPDBEntities.GetContext().Visitor.Add(_currentVisitor);
            }
            
            try
            {
                PassOfficePPDBEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена", "Успешное выполнение операции");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        private void SetImage_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                        "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                        "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                ProfilePhoto.Source = new BitmapImage(new Uri(op.FileName));
            }
        }
    }
}