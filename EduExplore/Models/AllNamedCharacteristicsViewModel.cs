using EduExplore.Core.Models;

namespace EduExplore.Models
{
    public class AllNamedCharacteristicsViewModel
    {
        public IEnumerable<NamedCharacteristicListViewModel> Characteristics { get; set; }
        public int CountOfCharacteristics => Characteristics.Count();
    }
}
