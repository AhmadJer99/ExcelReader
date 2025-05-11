namespace ExcelReader.Services;

internal interface IDbService
{
    Task<> DbInitialize();
    Task<List<T>> GetAllAsync<T>();
    Task<T> GetByIdAsync<T>(int id);
    Task AddAsync<T>(T entity);
    Task UpdateAsync<T>(T entity);
    Task DeleteAsync<T>(int id);
}
