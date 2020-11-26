using System;
using GemBox.Spreadsheet;

namespace GemBoxIssue
{
    class Program
    {
        static void Main(string[] args)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            var excel = new ExcelFile();
            var worksheet = excel.Worksheets.Add("Default");

            worksheet.Cells[0, 0].SetValue("1234");
            worksheet.Cells[1, 0].SetValue("5678");

            worksheet.Cells[0, 1].SetValue(DateTime.Now);

            worksheet.IgnoredErrors.Add("A:A", IgnoredErrorTypes.NumberStoredAsText);

            excel.Save(@"c:\temp\gemboxExcelTest.xlsx", SaveOptions.XlsxDefault);
        }
    }
}
