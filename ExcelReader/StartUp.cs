using ExcelReader.Services;
using ExcelReader.Models;
namespace ExcelReader;

public class StartUp
{
    private readonly IExcelService _excelService;
    private readonly IDbService _dbService;

    public StartUp(IExcelService excelService, IDbService dbService)
    {
        _excelService = excelService;
        _dbService = dbService;
    }

    public async Task ExecuteAsync()
    {
        // await _excelService.WriteExcelFileAsync("ExportedPopulation.xlsx", [
        //     new() {Year="2024",Gender="Male",PopulationCount=11111 }
        // ]);
        
        await _excelService.ReadExcelFileAsync("AmmanPopulation.xlsx");
    }
}