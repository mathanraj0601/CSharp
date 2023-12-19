using RecursiveWebApi.Models.ViewModel;

namespace RecursiveWebApi.Interfaces
{
    public interface IStandardService
    {
        public List<StandardViewModel>? GetStandardByParentId(int parentId);
    }
}
