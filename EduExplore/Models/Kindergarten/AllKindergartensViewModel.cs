using EduExplore.Core.Models;

namespace EduExplore.Models.Kindergarten
{
    public class AllKindergartensViewModel
    {
        public IEnumerable<InstitutionListViewModel> Kindergartens { get; set; }

        public PagingViewModel Paging { get; set; }

        public string CriteriaId { get; set; }

        public string CriteriaName { get; set; }
    }
}
