using RecursiveWebApi.Interfaces;
using RecursiveWebApi.Models.Entity;
using RecursiveWebApi.Models.ViewModel;

namespace RecursiveWebApi.Services
{
    public class StandardService : IStandardService
    {
        private readonly IRepo _repo;
        public StandardService(IRepo repo) {
            _repo = repo;
        }

        public List<StandardViewModel>? GetStandardByParentId(int parentId)
        {
            //if(parentId <= -1)
            //    return null;
            //if (parentId == 0)
            //    return getStandardHierarchy(new StandardViewModel { Id = 0, Name = null });
            var parent = _repo.GetALLStandard().Where((standard)=>standard.ParentId == parentId);
            List<StandardViewModel> standards = new List<StandardViewModel>();
            foreach( var item in parent)
            {
                var standard = getStandardHierarchy( new StandardViewModel { Id = item.Id, Name = item.Name });
                if(standard != null)
                    standards.Add(standard);
            }
            return standards;


        }
        public StandardViewModel? getStandardHierarchy(StandardViewModel standard)
        {
            var standards = _repo.GetALLStandard();
            var parentChild = standards.Where(x => x.ParentId == standard.Id);
            if (parentChild.Count() == 0) return standard;
            standard.Child = new List<StandardViewModel>();
            foreach (var child in parentChild)
            {
                var childEx = getStandardHierarchy(new StandardViewModel { Id = child.Id, Name = child.Name });
                if (childEx != null) standard.Child.Add(childEx);
            }
            return standard;
        }
    }
}
