using System.ComponentModel.DataAnnotations;

namespace EduExplore.Core.Models
{
    public class NamedCharacteristicListViewModel
    {
        public string Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }
    }
}
