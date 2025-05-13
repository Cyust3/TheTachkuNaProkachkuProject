using TheTachkuNaProkachkuConctrat.BusinessLogicsContracts;
using TheTachkuNaProkachkuConctrat.DataModels;
using TheTachkuNaProkachkuConctrat.Enums;

namespace TheTachkuNaProkachkuBusinessLogic.Implementations;

internal class SaleBusinessLogicContract : ISaleBusinessLogicContract
{

    public List<SaleDataModel> GetAllSalesByPeriod(DateTime fromDate, DateTime toDate)
    {
        return [];
    }

    public List<SaleDataModel> GetAllSalesByWorkerByPeriod(string workerId, DateTime fromDate, DateTime toDate)
    {
        return [];
    }

    public List<SaleDataModel> GetAllSalesByBuyerByPeriod(string buyerId, DateTime fromDate, DateTime toDate)
    {
        return [];
    }

    public List<SaleDataModel> GetAllSalesByProductByPeriod(string productId, DateTime fromDate, DateTime toDate)
    {
        return [];
    }

    public SaleDataModel GetSaleByData(string data)
    {
        return new("", "", "", 0, DiscountType.None, 0, true, []);
    }

    public void InsertSale(SaleDataModel saleDataModel)
    {
    }

    public void CancelSale(string id)
    {
    }
}
