using ExcelReader.Models;
namespace ExcelReader.Services;

public interface IDbService
{
    Task DbInitialize();
    Task<List<Population>> GetAllAsync();
    Task<Population> GetByIdAsync(int id);
    Task AddAsync(Population entity);
    Task UpdateAsync(Population entity);
    Task DeleteAsync(int id);
}
