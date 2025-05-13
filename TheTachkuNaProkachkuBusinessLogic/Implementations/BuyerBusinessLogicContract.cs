using TheTachkuNaProkachkuConctrat.BusinessLogicsContracts;
using TheTachkuNaProkachkuConctrat.DataModels;

namespace TheTachkuNaProkachkuBusinessLogic.Implementations;

internal class BuyerBusinessLogicContract : IBuyerBusinessLogicContract
{
    
    public List<BuyerDataModel> GetAllBuyers()
    {
        return [];
    }

    public BuyerDataModel GetBuyerByData(string data)
    {
        return new("", "", "", 0);
    }

    public void InsertBuyer(BuyerDataModel buyerDataModel)
    {
    }

    public void UpdateBuyer(BuyerDataModel buyerDataModel)
    {
    }

    public void DeleteBuyer(string id)
    {
    }
}
