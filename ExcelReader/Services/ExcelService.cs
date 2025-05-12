using ExcelReader.Models;
using OfficeOpenXml;

namespace ExcelReader.Services;

public class ExcelService : IExcelService
{
    public Task<List<Population>> ReadExcelFileAsync(string filePath)
    {
        throw new NotImplementedException();
    }

    public Task<List<Population>> ReadExcelFileWithHeadersAsync(string filePath, bool hasHeaders)
    {
        throw new NotImplementedException();
    }

    public async Task WriteExcelFileAsync(string filePath, List<Population> data)
    {
        ExcelPackage.License.SetNonCommercialOrganization("My Noncommercial organization");

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
