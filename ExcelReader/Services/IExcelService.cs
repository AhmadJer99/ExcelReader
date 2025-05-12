using ExcelReader.Models;

namespace ExcelReader.Services;

public interface IExcelService
{
    Task<List<Population>> ReadExcelFileAsync(string filePath);
    Task WriteExcelFileAsync(string filePath, List<Population> data);
    Task<List<Population>> ReadExcelFileWithHeadersAsync(string filePath, bool hasHeaders);
    Task WriteExcelFileWithHeadersAsync(string filePath, List<Population> data, bool hasHeaders);
}
