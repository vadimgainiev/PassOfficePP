using System;
using System.Data;
using System.Windows;
using Microsoft.Office.Interop.Excel;
using Microsoft.Win32;
using Application = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;

namespace PassOfficePP.Pages.CompareExcelDataPages
{
    public partial class CompareVisitorsExcelData
    {
        public CompareVisitorsExcelData()
        {
            InitializeComponent();

            ResultsFirstToSecondDataGrid.Visibility = Visibility.Hidden;
            ResultsSecondToFirstDataGrid.Visibility = Visibility.Hidden;
            UniqueCasesDatagrid1.Visibility = Visibility.Hidden;
            UniqueCasesDatagrid2.Visibility = Visibility.Hidden;
        }

        private void BtnCompare_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (FilePath1.Text == "" || FilePath2.Text == "")
                {
                    MessageBox.Show("Не выбраны списки для сравнения. Повторите попытку ввода данных.",
                        "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    var dataTable1 = ((DataView)ExcelInputDataGrid1.ItemsSource).ToTable();
                    var dataTable2 = ((DataView)ExcelInputDataGrid2.ItemsSource).ToTable();

                    if (AreTablesTheSame(dataTable1, dataTable2))
                    {
                        MessageBox.Show("Загруженные списки равны.", "Результат сравнения",
                            MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Загруженные списки не равны.", "Результат сравнения",
                            MessageBoxButton.OK, MessageBoxImage.Warning);

                        ResultsFirstToSecondDataGrid.ItemsSource =
                            GetDifferencesBetweenTables1(dataTable1, dataTable2).AsDataView();
                        ResultsSecondToFirstDataGrid.ItemsSource =
                            GetDifferencesBetweenTables2(dataTable1, dataTable2).AsDataView();

                        ResultsFirstToSecondDataGrid.Visibility = Visibility.Visible;
                        ResultsSecondToFirstDataGrid.Visibility = Visibility.Visible;
                        UniqueCasesDatagrid1.Visibility = Visibility.Visible;
                        UniqueCasesDatagrid2.Visibility = Visibility.Visible;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }

        private void BrowseSheetBtn1_OnClick(object sender, RoutedEventArgs e)
        {
            var op = new OpenFileDialog
            {
                Title = "Выберите таблицу",
                Filter = "Excel-файлы(*.xlsx;*.xls) | *.xlsx;*.xls"
            };

            var dataTable = new DataTable();

            if (op.ShowDialog() != true) return;
            FilePath1.Text = op.FileName;

            var excelApp = new Application();
            var workbook =
                excelApp.Workbooks.Open(FilePath1.Text, 0, true, 5,
                    "", "", true,
                    XlPlatform.xlWindows, "\t", false, false,
                    0, true, 1, 0);
            var excelSheet = (Worksheet)workbook.Worksheets.Item[1];
            var myRange = excelSheet.UsedRange;

            int rowCount;
            int colCount;

            for (colCount = 1; colCount <= myRange.Columns.Count; colCount++)
            {
                var strColumn = "";
                strColumn = (string)((Range)myRange.Cells[1, colCount]).Value2;
                dataTable.Columns.Add(strColumn, typeof(string));
            }

            for (rowCount = 2; rowCount <= myRange.Rows.Count; rowCount++)
            {
                var strData = "";
                for (colCount = 1; colCount <= myRange.Columns.Count; colCount++)
                {
                    try
                    {
                        var cellContent = (string)((Range)myRange.Cells[rowCount, colCount]).Value2;
                        strData += cellContent + "|";
                    }
                    catch (Exception)
                    {
                        double doubleCellContent = ((Range)myRange.Cells[rowCount, colCount]).Value2;
                        strData += doubleCellContent + "|";
                    }
                }

                strData = strData.Remove(strData.Length - 1, 1);
                dataTable.Rows.Add(strData.Split('|'));
            }

            ExcelInputDataGrid1.ItemsSource = dataTable.DefaultView;

            workbook.Close(true);
            excelApp.Quit();
        }

        private void BrowseSheetBtn2_OnClick(object sender, RoutedEventArgs e)
        {
            var op = new OpenFileDialog
            {
                Title = "Выберите таблицу",
                Filter = "Excel-файлы(*.xlsx;*.xls) | *.xlsx;*.xls"
            };

            var dataTable = new DataTable();

            if (op.ShowDialog() != true) return;
            FilePath2.Text = op.FileName;

            var excelApp = new Application();
            var workbook =
                excelApp.Workbooks.Open(FilePath2.Text, 0, true, 5,
                    "", "", true,
                    XlPlatform.xlWindows, "\t", false, false,
                    0, true, 1, 0);
            var excelSheet = (Worksheet)workbook.Worksheets.Item[1];
            var myRange = excelSheet.UsedRange;

            int rowCount;
            int colCount;

            for (colCount = 1; colCount <= myRange.Columns.Count; colCount++)
            {
                var strColumn = (string)((Range)myRange.Cells[1, colCount]).Value2;
                dataTable.Columns.Add(strColumn, typeof(string));
            }

            for (rowCount = 2; rowCount <= myRange.Rows.Count; rowCount++)
            {
                var strData = "";
                for (colCount = 1; colCount <= myRange.Columns.Count; colCount++)
                {
                    try
                    {
                        var cellContent = (string)((Range)myRange.Cells[rowCount, colCount]).Value2;
                        strData += cellContent + "|";
                    }
                    catch (Exception)
                    {
                        double doubleCellContent = ((Range)myRange.Cells[rowCount, colCount]).Value2;
                        strData += doubleCellContent + "|";
                    }
                }

                strData = strData.Remove(strData.Length - 1, 1);
                dataTable.Rows.Add(strData.Split('|'));
            }

            ExcelInputDataGrid2.ItemsSource = dataTable.DefaultView;

            workbook.Close(true);
            excelApp.Quit();
        }

        private static bool AreTablesTheSame(DataTable dataTable1, DataTable dataTable2)
        {
            if (dataTable1.Rows.Count != dataTable2.Rows.Count || dataTable1.Columns.Count != dataTable2.Columns.Count)
            {
                return false;
            }

            for (var i = 0; i < dataTable1.Rows.Count; i++)
            {
                for (var j = 0; j < dataTable1.Columns.Count; j++)
                {
                    if (!Equals(dataTable1.Rows[i][j], dataTable2.Rows[i][j]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static DataTable GetDifferencesBetweenTables1(DataTable dataTable1, DataTable dataTable2)
        {
            var resultTable = new DataTable();

            using (var dataSet = new DataSet())
            {
                dataSet.Tables.AddRange(new[]
                {
                    dataTable1.Copy(),
                    dataTable2.Copy()
                });

                var firstCols = new DataColumn[dataSet.Tables[0].Columns.Count];
                var secondCols = new DataColumn[dataSet.Tables[1].Columns.Count];

                for (var i = 0; i < firstCols.Length; i++)
                {
                    firstCols[i] = dataSet.Tables[0].Columns[i];
                }

                for (var i = 0; i < secondCols.Length; i++)
                {
                    secondCols[i] = dataSet.Tables[1].Columns[i];
                }

                var r1 = new DataRelation(string.Empty, firstCols, secondCols, false);
                dataSet.Relations.Add(r1);

                var r2 = new DataRelation(string.Empty, secondCols, firstCols, false);
                dataSet.Relations.Add(r2);

                for (var i = 0; i < dataTable2.Columns.Count; i++)
                {
                    resultTable.Columns.Add(dataTable1.Columns[i].ColumnName, dataTable1.Columns[i].DataType);
                }

                resultTable.BeginLoadData();

                foreach (DataRow parentRow in dataSet.Tables[0].Rows)
                {
                    var childRows = parentRow.GetChildRows(r1);
                    if (childRows.Length == 0)
                    {
                        resultTable.LoadDataRow(parentRow.ItemArray, true);
                    }
                }

                resultTable.EndLoadData();
            }

            return resultTable;
        }

        private static DataTable GetDifferencesBetweenTables2(DataTable dataTable1, DataTable dataTable2)
        {
            var resultTable = new DataTable();

            using (var dataSet = new DataSet())
            {
                dataSet.Tables.AddRange(new[]
                {
                    dataTable1.Copy(),
                    dataTable2.Copy()
                });

                var firstCols = new DataColumn[dataSet.Tables[0].Columns.Count];
                var secondCols = new DataColumn[dataSet.Tables[1].Columns.Count];

                for (var i = 0; i < firstCols.Length; i++)
                {
                    firstCols[i] = dataSet.Tables[0].Columns[i];
                }

                for (var i = 0; i < secondCols.Length; i++)
                {
                    secondCols[i] = dataSet.Tables[1].Columns[i];
                }

                var r1 = new DataRelation(string.Empty, firstCols, secondCols, false);
                dataSet.Relations.Add(r1);

                var r2 = new DataRelation(string.Empty, secondCols, firstCols, false);
                dataSet.Relations.Add(r2);

                for (var i = 0; i < dataTable2.Columns.Count; i++)
                {
                    resultTable.Columns.Add(dataTable1.Columns[i].ColumnName, dataTable1.Columns[i].DataType);
                }

                resultTable.BeginLoadData();

                foreach (DataRow parentRow in dataSet.Tables[1].Rows)
                {
                    var childRows = parentRow.GetChildRows(r2);
                    if (childRows.Length == 0)
                    {
                        resultTable.LoadDataRow(parentRow.ItemArray, true);
                    }
                }

                resultTable.EndLoadData();
            }

            return resultTable;
        }

        private void BtnMerge_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (FilePath1.Text == "" || FilePath2.Text == "")
                {
                    MessageBox.Show("Не выбраны списки для слияния. Повторите попытку ввода данных.",
                        "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    var dataTable1 = ((DataView)ExcelInputDataGrid1.ItemsSource).ToTable();
                    var dataTable2 = ((DataView)ExcelInputDataGrid2.ItemsSource).ToTable();

                    var mergedDataTable = dataTable1.Copy();
                    mergedDataTable.Merge(dataTable2);

                    MergedDataGrid.ItemsSource = mergedDataTable.AsDataView();

                    var excel = new Application
                    {
                        Visible = true
                    };

                    var workbook = excel.Workbooks.Add();
                    var sheet1 = (Worksheet)workbook.ActiveSheet;
                    sheet1.Name = "Сотрудники";
                    sheet1.Columns.AutoFit();

                    for (var i = 0; i < mergedDataTable.Columns.Count; i++)
                    {
                        sheet1.Range["A1"].Offset[0, i].Value = mergedDataTable.Columns[i].ColumnName;
                        sheet1.Cells[1, i + 1].Font.Bold = true;
                    }

                    for (var i = 0; i < mergedDataTable.Rows.Count; i++)
                    {
                        sheet1.Range["A2"].Offset[i].Resize[1, mergedDataTable.Columns.Count].Value =
                            mergedDataTable.Rows[i].ItemArray;
                    }

                    sheet1.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}