

namespace ExcelReader.Services;

internal interface IExcelService
{
    Task<List<T>> ReadExcelFileAsync(string filePath);
    Task WriteExcelFileAsync(string filePath, List<T> data);
    Task<List<T>> ReadExcelFileWithHeadersAsync(string filePath, bool hasHeaders);
    Task WriteExcelFileWithHeadersAsync(string filePath, List<T> data, bool hasHeaders);
}
