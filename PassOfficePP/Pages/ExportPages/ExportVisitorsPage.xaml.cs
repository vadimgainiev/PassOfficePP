using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using PassOfficePP.Pages.DataPages;
using Excel = Microsoft.Office.Interop.Excel;

namespace PassOfficePP.Pages.ExportPages
{
    public partial class ExportVisitorsPage : Page
    {
        public ExportVisitorsPage()
        {
            InitializeComponent();

            UpdateVisitors();
        }

        private void UpdateVisitors()
        {
            var currentVisitors = PassOfficePPDBEntities.GetContext().Visitor.ToList();

            VisitorsGrid.ItemsSource = currentVisitors.OrderBy(p => p.Surname).ToList();
        }

        private void BtnExport_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var excel = new Excel.Application
                {
                    Visible = true
                };

                var workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                var sheet1 = (Excel.Worksheet)workbook.Sheets[1];
                sheet1.Name = "Сотрудники";
                sheet1.Columns.AutoFit();

                for (var i = 0; i < VisitorsGrid.Columns.Count; i++)
                {
                    var myRange = (Excel.Range)sheet1.Cells[1, i + 1];
                    sheet1.Cells[1, i + 1].Font.Bold = true;
                    myRange.Value2 = VisitorsGrid.Columns[i].Header;
                }

                for (var i = 0; i < VisitorsGrid.Columns.Count; i++)
                {
                    for (var j = 0; j < VisitorsGrid.Items.Count; j++)
                    {
                        var cellContent = VisitorsGrid.Columns[i].GetCellContent(VisitorsGrid.Items[j]) as TextBlock;
                        var myRange = (Excel.Range)sheet1.Cells[j + 2, i + 1];
                        myRange.Value2 = cellContent?.Text;
                    }

                    sheet1.Columns.AutoFit();
                }

                if (MessageBox.Show("Данные успешно экспортированы в новую книгу Excel.",
                        "Сведения о выполнении операции", MessageBoxButton.OK, MessageBoxImage.Information) ==
                    MessageBoxResult.OK)
                {
                    NavigationService?.GoBack();
                }

                NavigationService?.Navigate(new VisitorsPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сведения о выполнении операции", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }
    }
}