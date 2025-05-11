
namespace ExcelReader.Services;

internal class ExcelService : IExcelService
{
    public Task<List<T>> ReadExcelFileAsync(string filePath)
    {
        throw new NotImplementedException();
    }

    public Task<List<T>> ReadExcelFileWithHeadersAsync(string filePath, bool hasHeaders)
    {
        throw new NotImplementedException();
    }

    public Task WriteExcelFileAsync(string filePath, List<T> data)
    {
        throw new NotImplementedException();
    }

    public Task WriteExcelFileWithHeadersAsync(string filePath, List<T> data, bool hasHeaders)
    {
        throw new NotImplementedException();
    }
}
