using System.ComponentModel.DataAnnotations;

namespace EduExplore.DataSeeder.InputModels
{
    public class InstitutionInputModel
    {
        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]

        public string District { get; set; }

        [Required]
        [StringLength(250)]

        public string Municipality { get; set; }

        [Required]
        [StringLength(250)]

        public string InhabitedArea { get; set; }

        [Required]
        [StringLength(250)]

        public string Region { get; set; }

        [Required]
        [StringLength(250)]

        public string InstitutionType { get; set; }

        [Required]
        [StringLength(250)]

        public string DetailedInstitutionType { get; set; }

        [Required]
        [StringLength(250)]

        public string FinancialType { get; set; }
    }
}

