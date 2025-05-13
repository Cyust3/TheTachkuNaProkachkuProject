using TheTachkuNaProkachkuConctrat.BusinessLogicsContracts;
using TheTachkuNaProkachkuConctrat.DataModels;

namespace TheTachkuNaProkachkuBusinessLogic.Implementations;

internal class SalaryBusinessLogicContract : ISalaryBusinessLogicContract
{

    public List<SalaryDataModel> GetAllSalariesByPeriod(DateTime fromDate, DateTime toDate)
    {
        return [];
    }

    public List<SalaryDataModel> GetAllSalariesByPeriodByWorker(DateTime fromDate, DateTime toDate, string workerId)
    {
        return [];
    }

    public void CalculateSalaryByMounth(DateTime date)
    {
    }
}
