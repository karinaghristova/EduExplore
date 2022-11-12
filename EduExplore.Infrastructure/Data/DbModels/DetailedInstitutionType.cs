using System.ComponentModel.DataAnnotations;

namespace EduExplore.Infrastructure.Data.DbModels
{
    public class DetailedInstitutionType
    {
        [Key]
        public Guid Id { get; set; } = new Guid();

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        public ICollection<Institution> Institutions { get; set; } = new List<Institution>();
    }

}
