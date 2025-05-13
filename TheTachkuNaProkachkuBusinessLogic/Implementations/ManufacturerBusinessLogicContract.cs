using System.Text.Json;
using Microsoft.Extensions.Logging;
using TheTachkuNaProkachkuConctrat.BusinessLogicsContracts;
using TheTachkuNaProkachkuConctrat.DataModels;
using TheTachkuNaProkachkuConctrat.Exceptions;
using TheTachkuNaProkachkuConctrat.Extensions;
using TheTachkuNaProkachkuConctrat.StoragesContracts;

namespace TheTachkuNaProkachkuBusinessLogic.Implementations;

internal class ManufacturerBusinessLogicContract(IManufacturerStorageContract manufacturerStorageContract, ILogger logger) : IManufacturerBusinessLogicContract
{
    private readonly ILogger _logger = logger;
    private readonly IManufacturerStorageContract _manufacturerStorageContract = manufacturerStorageContract;

    public List<ManufacturerDataModel> GetAllManufacturers()
    {
        _logger.LogInformation("GetAllManufacturers");
        return _manufacturerStorageContract.GetList() ?? throw new NullListException();
    }

    public ManufacturerDataModel GetManufacturerByData(string data)
    {
        _logger.LogInformation("Get element by data: {data}", data);
        if (data.IsEmpty())
        {
            throw new ArgumentNullException(nameof(data));
        }
        if (data.IsGuid())
        {
            return _manufacturerStorageContract.GetElementById(data) ?? throw new ElementNotFoundException(data);
        }
        return _manufacturerStorageContract.GetElementByName(data) ?? _manufacturerStorageContract.GetElementByOldName(data) ??
            throw new ElementNotFoundException(data);
    }

    public void InsertManufacturer(ManufacturerDataModel manufacturerDataModel)
    {
        _logger.LogInformation("New data: {json}", JsonSerializer.Serialize(manufacturerDataModel));
        ArgumentNullException.ThrowIfNull(manufacturerDataModel);
        manufacturerDataModel.Validate();
        _manufacturerStorageContract.AddElement(manufacturerDataModel);
    }

    public void UpdateManufacturer(ManufacturerDataModel manufacturerDataModel)
    {
        _logger.LogInformation("Update data: {json}", JsonSerializer.Serialize(manufacturerDataModel));
        ArgumentNullException.ThrowIfNull(manufacturerDataModel);
        manufacturerDataModel.Validate();
        _manufacturerStorageContract.UpdElement(manufacturerDataModel);
    }

    public void DeleteManufacturer(string id)
    {
        _logger.LogInformation("Delete by id: {id}", id);
        if (id.IsEmpty())
        {
            throw new ArgumentNullException(nameof(id));
        }
        if (!id.IsGuid())
        {
            throw new ValidationException("Id is not a unique identifier");
        }
        _manufacturerStorageContract.DelElement(id);
    }
}
