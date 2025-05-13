using Microsoft.Extensions.Logging;
using TheTachkuNaProkachkuConctrat.BusinessLogicsContracts;
using TheTachkuNaProkachkuConctrat.DataModels;
using TheTachkuNaProkachkuConctrat.StoragesContracts;

namespace TheTachkuNaProkachkuBusinessLogic.Implementations;

internal class SalaryBusinessLogicContract(ISalaryStorageContract salaryStorageContract,
    ISaleStorageContract saleStorageContract, IPostStorageContract postStorageContract, IWorkerStorageContract workerStorageContract, ILogger logger) : ISalaryBusinessLogicContract
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
