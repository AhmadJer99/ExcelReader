using ExcelReader.Models;
using OfficeOpenXml;
using Spectre.Console;

namespace ExcelReader.Services;

public class ExcelService : IExcelService
{
    
    public ExcelService()
    {
        // sets the license to a commerical license.
        ExcelPackage.License.SetNonCommercialOrganization("My Noncommercial organization");
    }
    public Task<List<Population>> ReadExcelFileAsync(string filePath)
    {
        AnsiConsole.MarkupLine("[Green]Reading From Excel...[/]");
        
        using (var package = new ExcelPackage(new FileInfo(@filePath))) // Loaded the Excel file.
        {

        }

        throw new NotImplementedException();
    }

    public Task<List<Population>> ReadExcelFileWithHeadersAsync(string filePath, bool hasHeaders)
    {
        throw new NotImplementedException();
    }

    public async Task WriteExcelFileAsync(string filePath, List<Population> data)
    {
        Type type = typeof(Population);

        var properties = type.GetProperties();

        using var package = new ExcelPackage(@filePath);
        var sheet = package.Workbook.Worksheets.Add("PopulationData");
        sheet.Cells["A1"].Value = properties[0].Name;
        sheet.Cells["B1"].Value = properties[1].Name;
        sheet.Cells["C1"].Value = properties[2].Name;

        var rows = data.Count;
        for (int i = 0; i < rows; i++)
        {
            sheet.Cells[i + 2, 1].Value = data[i].Year;
            sheet.Cells[i + 2, 2].Value = data[i].Gender;
            sheet.Cells[i + 2, 3].Value = data[i].PopulationCount;
        }
        await package.SaveAsync();
    }

    public async  Task WriteExcelFileWithHeadersAsync(string filePath, List<Population> data, bool hasHeaders)
    {
        throw new NotImplementedException();
    }
}
