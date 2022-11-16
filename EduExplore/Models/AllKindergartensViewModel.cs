using EduExplore.Core.Models;

namespace EduExplore.Models
{
    public class AllKindergartensViewModel
    {
        public IEnumerable<InstitutionListViewModel> Kindergartens { get; set; }

        public PagingViewModel Paging { get; set; }
    }
}
