using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduExplore.Infrastructure.Data.DbModels
{
    public class Institution
    {
        [Key]
        public Guid Id { get; set; } = new Guid();

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        public Guid DistrictId { get; set; }

        [ForeignKey(nameof(DistrictId))]
        public District District { get; set; }

        [Required]
        public Guid MunicipalityId { get; set; }

        [ForeignKey(nameof(MunicipalityId))]
        public Municipality Municipality { get; set; }

        [Required]
        public Guid InhabitedAreaId { get; set; }

        [ForeignKey(nameof(InhabitedAreaId))]
        public InhabitedArea InhabitedArea { get; set; }

        [Required]
        public Guid RegionId { get; set; }

        [ForeignKey(nameof(RegionId))]
        public Region Region { get; set; }

        [Required]
        public Guid InstitutionTypeId { get; set; }

        [ForeignKey(nameof(InstitutionTypeId))]
        public InstitutionType InstitutionType { get; set; }

        [Required]
        public Guid DetailedInstitutionTypeId { get; set; }

        [ForeignKey(nameof(DetailedInstitutionTypeId))]
        public DetailedInstitutionType DetailedInstitutionType { get; set; }

        [Required]
        public Guid FinancialTypeId { get; set; }

        [ForeignKey(nameof(FinancialTypeId))]
        public FinancialType FinancialType { get; set; }
    }

}
