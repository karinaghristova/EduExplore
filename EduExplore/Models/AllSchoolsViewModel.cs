using EduExplore.Core.Models;

namespace EduExplore.Models
{
    public class AllSchoolsViewModel
    {
        public IEnumerable<InstitutionListViewModel> Schools { get; set; }

        public PagingViewModel Paging { get; set; }
    }
}
