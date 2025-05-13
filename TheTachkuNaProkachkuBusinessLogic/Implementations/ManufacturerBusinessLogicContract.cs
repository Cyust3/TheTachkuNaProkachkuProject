using TheTachkuNaProkachkuConctrat.BusinessLogicsContracts;
using TheTachkuNaProkachkuConctrat.DataModels;

namespace TheTachkuNaProkachkuBusinessLogic.Implementations;

internal class ManufacturerBusinessLogicContract: IManufacturerBusinessLogicContract
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
