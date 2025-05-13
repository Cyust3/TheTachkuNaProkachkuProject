using TheTachkuNaProkachkuConctrat.DataModels;

namespace TheTachkuNaProkachkuConctrat.StoragesContracts;

public interface ISalaryStorageContract
{
    List<SalaryDataModel> GetList(DateTime startDate, DateTime endDate, string? workerId = null);

    void AddElement(SalaryDataModel salaryDataModel);
}
