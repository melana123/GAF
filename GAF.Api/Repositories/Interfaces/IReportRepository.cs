using GAF.Api.Models;

namespace  GAF.Api.Repositories.Interfaces;

public interface IReportRepository
{
    Task<Report> GetMonthlyReportAsync(string userId, int month, int year);
    Task<IEnummerable> GetYearlyReportAsync(string userId, int month, int year);
    Task<Report> CreateOrUpdateMonthlyReportAsync (Report report);
}
