﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace barbershop
{
    public static class ExcelSaver
    {
        public static async void Save(DataGridView dataGrid)
        {
            string path = Application.ExecutablePath + $"{dataGrid.Name}.xlsx";
            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook = application.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            worksheet.Rows.AutoFit();
            await Task.Run(() =>
            {
                for (int i = 0; i < dataGrid.ColumnCount; i++)
                {
                    worksheet.Rows[1].Columns[i+1] = dataGrid.Columns[i].HeaderText;
                }
                for (int i = 0; i < dataGrid.RowCount; i++)
                {
                    for (int j = 0; j < dataGrid.ColumnCount; j++)
                    {
                        worksheet.Rows[i + 2].Columns[j + 1] = dataGrid.Rows[i].Cells[j].Value;
                    }
                }
                MessageBox.Show("Сохранено");
            });
            application.AlertBeforeOverwriting = false;
            workbook.SaveAs(path);
            application.Quit();
        }
    }
}