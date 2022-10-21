using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace PassOfficePP.Pages.AddEditPages
{
    public partial class AddEditPostPage : Page
    {
        private readonly Post _currentPost = new Post();

        public AddEditPostPage(Post selectedPost)
        {
            InitializeComponent();
            if (selectedPost != null)
            {
                _currentPost = selectedPost;
            }

            DataContext = _currentPost;
        }

        private void BtnSave_OnClick(object sender, RoutedEventArgs e)
        {
            var errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentPost.Name_Post))
                errors.AppendLine("Укажите наименование должности.");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Ошибка!");
                return;
            }

            if (_currentPost.ID_Post == 0)
            {
                PassOfficePPDBEntities.GetContext().Post.Add(_currentPost);
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