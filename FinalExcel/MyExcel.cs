using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Excel=Microsoft.Office.Interop.Excel;
using System.ComponentModel;

namespace MyExcelApp
{
    class MyExcel
    {
        public static string DB_PATH = @"";
        public static BindingList<ExcelRecord> ExcelList = new BindingList<ExcelRecord>();
        private static Excel.Workbook MyBook = null;
        private static Excel.Application MyApp = null;
        private static Excel.Worksheet MySheet = null;
        private static int lastRow=0;
        public static void InitializeExcel()
        {
            MyApp = new Excel.Application();
            MyApp.Visible = false;
            MyBook = MyApp.Workbooks.Open(DB_PATH);
            MySheet = (Excel.Worksheet)MyBook.Sheets[1]; // Explict cast is not required here
            lastRow = MySheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
        }
        public static BindingList<ExcelRecord> ReadMyExcel()
        {
            ExcelList.Clear();
            for (int index = 2; index <= lastRow; index++)
            {
                System.Array MyValues = (System.Array)MySheet.get_Range("A" + index.ToString(), "I" + index.ToString()).Cells.Value;
                ExcelList.Add(new ExcelRecord { 
                                            cdatetime = MyValues.GetValue(1,1).ToString(),
                                            address = MyValues.GetValue(1,2).ToString(),
                                            district = MyValues.GetValue(1,3).ToString(),
                                            beat = MyValues.GetValue(1,4).ToString(),
                                            grid = MyValues.GetValue(1, 5).ToString(),
                                            crimedescr = MyValues.GetValue(1, 6).ToString(),
                                            ucr_ncic_code = MyValues.GetValue(1, 7).ToString(),
                                            latitude = MyValues.GetValue(1, 8).ToString(),
                                            longitude = MyValues.GetValue(1, 9).ToString()

                                        });
            }
            return ExcelList;
        }
        public static void DeleteFromExcel(int index) {
            //MySheet.Rows[index].Delete();
            //((Excel.Range)MySheet.Rows[index]).Delete(Excel.XlDeleteShiftDirection.xlShiftUp);
            ExcelList.RemoveAt(index);
            MyBook.Save();
        }

        public static void WriteToExcel(ExcelRecord rec)
        {
            try
            {
                lastRow += 1;
                MySheet.Cells[lastRow, 1] = rec.cdatetime;
                MySheet.Cells[lastRow, 2] = rec.address;
                MySheet.Cells[lastRow, 3] = rec.district;
                MySheet.Cells[lastRow, 4] = rec.beat;
                MySheet.Cells[lastRow, 5] = rec.grid;
                MySheet.Cells[lastRow, 6] = rec.crimedescr;
                MySheet.Cells[lastRow, 7] = rec.ucr_ncic_code;
                MySheet.Cells[lastRow, 8] = rec.latitude;
                MySheet.Cells[lastRow, 9] = rec.longitude;
                ExcelList.Add(rec);
                MyBook.Save();
            }
            catch (Exception ex)
            { }

        }

        public static List<ExcelRecord> FilterExcelList(string searchValue, string searchExpr)
        {
            List<ExcelRecord> FilteredList = new List<ExcelRecord>();
            switch (searchValue.ToLower())
            {
                case "cdatetime":
                    FilteredList = ExcelList.ToList().FindAll(rec => rec.cdatetime.ToLower().Contains(searchExpr));
                    break;
                case "beat":
                    FilteredList = ExcelList.ToList().FindAll(rec => rec.beat.ToLower().Contains(searchExpr));
                    break;
                case "address":
                    FilteredList = ExcelList.ToList().FindAll(rec => rec.address.ToLower().Contains(searchExpr));
                    break;
                case "district":
                    FilteredList = ExcelList.ToList().FindAll(rec => rec.district.ToLower().Contains(searchExpr));
                    break;
                case "grid":
                    FilteredList = ExcelList.ToList().FindAll(rec => rec.grid.ToLower().Contains(searchExpr));
                    break;
                case "crimedescr":
                    FilteredList = ExcelList.ToList().FindAll(rec => rec.crimedescr.ToLower().Contains(searchExpr));
                    break;
                case "ucr_ncic_code":
                    FilteredList = ExcelList.ToList().FindAll(rec => rec.ucr_ncic_code.ToLower().Contains(searchExpr));
                    break;
                case "latitude":
                    FilteredList = ExcelList.ToList().FindAll(rec => rec.latitude.ToLower().Contains(searchExpr));
                    break;
                case "longitude":
                    FilteredList = ExcelList.ToList().FindAll(rec => rec.longitude.ToLower().Contains(searchExpr));
                    break;
                default:
                    break;
            }
            return FilteredList;
        }
        public static void CloseExcel()
        {
            MyBook.Saved = true;
            MyApp.Quit();

        }
        
    }
    
}
