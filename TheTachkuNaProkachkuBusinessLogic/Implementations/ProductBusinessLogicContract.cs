using Microsoft.Extensions.Logging;
using TheTachkuNaProkachkuConctrat.BusinessLogicsContracts;
using TheTachkuNaProkachkuConctrat.DataModels;
using TheTachkuNaProkachkuConctrat.Enums;
using TheTachkuNaProkachkuConctrat.StoragesContracts;

namespace TheTachkuNaProkachkuBusinessLogic.Implementations;

internal class ProductBusinessLogicContract(IProductStorageContract productStorageContract, ILogger logger) : IProductBusinessLogicContract
{

    public List<ProductDataModel> GetAllProducts(bool onlyActive)
    {
        return [];
    }

    public List<ProductDataModel> GetAllProductsByManufacturer(string manufacturerId, bool onlyActive = true)
    {
        return [];
    }

    public List<ProductHistoryDataModel> GetProductHistoryByProduct(string productId)
    {
        return [];
    }

    public ProductDataModel GetProductByData(string data)
    {
        return new("", "", ProductType.None, "", 0, true);
    }

    public void InsertProduct(ProductDataModel productDataModel)
    {
    }

    public void UpdateProduct(ProductDataModel productDataModel)
    {
    }

    public void DeleteProduct(string id)
    {
    }
}
