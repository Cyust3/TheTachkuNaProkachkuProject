using Microsoft.Extensions.Logging;
using TheTachkuNaProkachkuConctrat.BusinessLogicsContracts;
using TheTachkuNaProkachkuConctrat.DataModels;
using TheTachkuNaProkachkuConctrat.StoragesContracts;

namespace TheTachkuNaProkachkuBusinessLogic.Implementations;

internal class ManufacturerBusinessLogicContract(IManufacturerStorageContract manufacturerStorageContract, ILogger logger) : IManufacturerBusinessLogicContract
{
    public List<ManufacturerDataModel> GetAllManufacturers()
    {
        return [];
    }

    public ManufacturerDataModel GetManufacturerByData(string data)
    {
        return new("", "", null, null);

    }

    public void InsertManufacturer(ManufacturerDataModel manufacturerDataModel)
    {
    }

    public void UpdateManufacturer(ManufacturerDataModel manufacturerDataModel)
    {
    }

    public void DeleteManufacturer(string id)
    {
    }
}
