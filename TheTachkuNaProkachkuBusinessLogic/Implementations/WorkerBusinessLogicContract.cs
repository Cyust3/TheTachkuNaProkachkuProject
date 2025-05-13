using Microsoft.Extensions.Logging;
using TheTachkuNaProkachkuConctrat.BusinessLogicsContracts;
using TheTachkuNaProkachkuConctrat.DataModels;
using TheTachkuNaProkachkuConctrat.StoragesContracts;

namespace TheTachkuNaProkachkuBusinessLogic.Implementations;

internal class WorkerBusinessLogicContract(IWorkerStorageContract workerStorageContract, ILogger logger) : IWorkerBusinessLogicContract
{

    public List<WorkerDataModel> GetAllWorkers(bool onlyActive = true)
    {
        return [];
    }

    public List<WorkerDataModel> GetAllWorkersByPost(string postId, bool onlyActive = true)
    {
        return [];
    }

    public List<WorkerDataModel> GetAllWorkersByBirthDate(DateTime fromDate, DateTime toDate, bool onlyActive = true)
    {
        return [];
    }

    public List<WorkerDataModel> GetAllWorkersByEmploymentDate(DateTime fromDate, DateTime toDate, bool onlyActive = true)
    {
        return [];
    }

    public WorkerDataModel GetWorkerByData(string data)
    {
        return new("", "", "", DateTime.Now, DateTime.Now, true);
    }

    public void InsertWorker(WorkerDataModel workerDataModel)
    {
    }

    public void UpdateWorker(WorkerDataModel workerDataModel)
    {
    }

    public void DeleteWorker(string id)
    {
    }
}
