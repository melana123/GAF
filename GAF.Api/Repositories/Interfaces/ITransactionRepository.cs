using GAF.Api.Models;

namespace GAF.Api.Repositories.Interfaces;

public interface ITransactionRepository
{
    Task<IEnumerable<Transaction>> GetAllByUserId(string userId);
    Task<Transaction> GetByIdAsync(int id, string userId);
    Task<IEnumerable<Transaction>> GetByDateRangeAsync(string userId, DateTime startDate, DateTime endDate);
    Task<IEnumerable<Transaction>> GetByCategoryAsync(string userId, int categoryId);
    Task<Transaction> CreateAsync(Translaction translaction);
    Task<Transaction> UpdateAsync(Translaction translaction);
    Task<bool> DeleteAsync(int id, string userId);
    Task<decimal> GetTotalIncomeByMonthAsync(string userId, int month, int year);
    Task<decimal> GetTotalExpensesByMonthAsync(string userId, int month, int year);
    Task<IEnumerable<Transaction>> GetRecentTransaction(string userId, int count = 10);

   
}
