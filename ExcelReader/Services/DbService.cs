using ExcelReader.Models;
namespace ExcelReader.Services;

public class DbService : IDbService
{
    public Task DbInitialize()
    {
        throw new NotImplementedException();
    }
    public Task<List<Population>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
    public Task<Population> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
    public Task AddAsync(Population entity)
    {
        throw new NotImplementedException();
    }
    public Task UpdateAsync(Population entity)
    {
        throw new NotImplementedException();
    }
    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}

