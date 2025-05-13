using TheTachkuNaProkachkuConctrat.BusinessLogicsContracts;
using TheTachkuNaProkachkuConctrat.DataModels;
using TheTachkuNaProkachkuConctrat.Enums;

namespace TheTachkuNaProkachkuBusinessLogic.Implementations;

internal class PostBusinessLogicContract : IPostBusinessLogicContract
{

    public List<PostDataModel> GetAllPosts(bool onlyActive = true)
    {
        return [];
    }

    public List<PostDataModel> GetAllDataOfPost(string postId)
    {
        return [];
    }

    public PostDataModel GetPostByData(string data)
    {
        return new("", "", "", PostType.None, 0, true, DateTime.Now);
    }

    public void InsertPost(PostDataModel postDataModel)
    {
    }

    public void UpdatePost(PostDataModel postDataModel)
    {
    }

    public void DeletePost(string id)
    {
    }

    public void RestorePost(string id)
    {
    }
}
