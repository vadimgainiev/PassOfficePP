using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media.Imaging;

namespace PassOfficePP.Pages.AddEditPages
{
    public partial class EditVisitorPage : Page
    {
        private readonly Visitor _currentVisitor = new Visitor();

        public EditVisitorPage(Visitor selectedVisitor)
        {
            InitializeComponent();

            if (selectedVisitor != null)
            {
                _currentVisitor = selectedVisitor;
            }

            DataContext = _currentVisitor;

            CategoryComboBox.ItemsSource = PassOfficePPDBEntities.GetContext().Category.ToList();
            PostComboBox.ItemsSource = PassOfficePPDBEntities.GetContext().Post.ToList();
            AccessLevelComboBox.ItemsSource = PassOfficePPDBEntities.GetContext().AccessLevel.ToList();
            WorkPlaceComboBox.ItemsSource = PassOfficePPDBEntities.GetContext().WorkPlace.ToList();
            WorkScheduleComboBox.ItemsSource = PassOfficePPDBEntities.GetContext().WorkSchedule.ToList();
        }

        private void BtnSave_OnClick(object sender, RoutedEventArgs e)
        {
            var errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentVisitor.Surname))
                errors.AppendLine("Укажите фамилию сотрудника.");
            if (string.IsNullOrWhiteSpace(_currentVisitor.Name))
                errors.AppendLine("Укажите имя сотрудника.");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Ошибка!");
                return;
            }

            string visitorImage = _currentVisitor.VisitorImage.ToString();
            var uri = new Uri(visitorImage, UriKind.RelativeOrAbsolute);
            var profilePhoto = new BitmapImage(uri);
            ProfilePhoto.Source = profilePhoto;

            _currentVisitor.VisitorImage = GetJpgFromImageControl(ProfilePhoto.Source as BitmapImage);

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

        private void SetImage_OnClick(object sender, RoutedEventArgs e)
        {
            var op = new OpenFileDialog
            {
                Title = "Выберите фото",
                Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                         "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                         "Portable Network Graphic (*.png)|*.png"
            };

            if (op.ShowDialog() == true)
            {
                ProfilePhoto.Source = new BitmapImage(new Uri(op.FileName));
            }
        }

        private static byte[] GetJpgFromImageControl(BitmapImage imageC)
        {
            var memStream = new MemoryStream();
            var encoder = new JpegBitmapEncoder();

            encoder.Frames.Add(BitmapFrame.Create(imageC));
            encoder.Save(memStream);

            return memStream.ToArray();
        }
    }
}
