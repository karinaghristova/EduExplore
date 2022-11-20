using EduExplore.Core.Constants;
using EduExplore.Core.Contracts;
using EduExplore.Infrastructure.Data.DbModels;
using EduExplore.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EduExplore.Core.Services
{
    public class StatisticsService : IStatisticsService
    {
        private readonly IApplicationDbRepository repo;

        public StatisticsService(IApplicationDbRepository repo)
        {
            this.repo = repo;
        }

        //Educational institutions overall
        public async Task<int> GetNumberOfAllInhabitedAreas()
        {
            var inhabitedAreas = await repo.All<InhabitedArea>().ToListAsync();
            return inhabitedAreas.Count();
        }

        public async Task<int> GetNumberOfAllRegions()
        {
            var regions = await repo.All<Region>().ToListAsync();
            return regions.Count();
        }

        public async Task<int> GetNumberOfAllInstitutionTypes()
        {
            var institutionTypes = await repo.All<InstitutionType>().ToListAsync();
            return institutionTypes.Count();
        }

        public async Task<int> GetNumberOfAllDetailedInstitutionTypes()
        {
            var dit = await repo.All<DetailedInstitutionType>().ToListAsync();
            return dit.Count();
        }

        public async Task<int> GetNumberOfAllFinancialTypes()
        {
            var financialTypes = await repo.All<FinancialType>().ToListAsync();
            return financialTypes.Count();
        }

        //Schools
        public async Task<int> GetNumberOfAllInhabitedAreasForSchools()
        {
            var inhabitedAreas = await repo.All<InhabitedArea>()
                .Include(i => i.Institutions)
                .Where(x => x.Institutions.Any(i => i.InstitutionType.Name != InstitutionTypesConstants.Kindergarten))
                .ToListAsync();
            return inhabitedAreas.Count();
        }

        public async Task<int> GetNumberOfAllRegionsForSchools()
        {
            var regions = await repo.All<Region>()
                .Include(i => i.Institutions)
                .Where(x => x.Institutions.Any(i => i.InstitutionType.Name != InstitutionTypesConstants.Kindergarten))
                .ToListAsync();
            return regions.Count();
        }

        public async Task<int> GetNumberOfAllInstitutionTypesForSchools()
        {
            var institutionTypes = await repo.All<InstitutionType>()
                .Include(i => i.Institutions)
                .Where(x => x.Institutions.Any(i => i.InstitutionType.Name != InstitutionTypesConstants.Kindergarten))
                .ToListAsync();
            return institutionTypes.Count();
        }

        public async Task<int> GetNumberOfAllDetailedInstitutionTypesForSchools()
        {
            var ditSchools = await repo.All<DetailedInstitutionType>()
                .Include(i => i.Institutions)
                .Where(x => x.Institutions.Any(i => i.InstitutionType.Name != InstitutionTypesConstants.Kindergarten))
                .ToListAsync();
            return ditSchools.Count();
        }

        public async Task<int> GetNumberOfAllFinancialTypesForSchools()
        {
            var financialTypes = await repo.All<FinancialType>()
                .Include(i => i.Institutions)
                .Where(x => x.Institutions.Any(i => i.InstitutionType.Name != InstitutionTypesConstants.Kindergarten))
                .ToListAsync();
            return financialTypes.Count();
        }

        public async Task<int> GetNumberOfAllSchools()
        {
            var schools = await repo.All<Institution>()
                .Where(i => i.InstitutionType.Name != InstitutionTypesConstants.Kindergarten)
                .ToListAsync();
            return schools.Count();
        }

        public async Task<int> GetNumberOfAllSchoolsInInhabitedArea(string inhabitedAreaId)
        {
            var schools = await repo.All<Institution>()
              .Where(i => i.InstitutionType.Name != InstitutionTypesConstants.Kindergarten &&
               i.InhabitedAreaId == new Guid(inhabitedAreaId))
              .ToListAsync();
            return schools.Count();
        }

        public async Task<int> GetNumberOfAllSchoolsInRegion(string regionId)
        {
            var schools = await repo.All<Institution>()
              .Where(i => i.InstitutionType.Name != InstitutionTypesConstants.Kindergarten &&
               i.RegionId == new Guid(regionId))
              .ToListAsync();
            return schools.Count();
        }

        public async Task<int> GetNumberOfAllSchoolsOfInstitutionType(string institutionTypeId)
        {
            var schools = await repo.All<Institution>()
              .Where(i => i.InstitutionType.Name != InstitutionTypesConstants.Kindergarten &&
               i.InstitutionTypeId == new Guid(institutionTypeId))
              .ToListAsync();
            return schools.Count();
        }

        public async Task<int> GetNumberOfAllSchoolsOfDetailedInstitutionType(string detailedInstitutionTypeId)
        {
            var schools = await repo.All<Institution>()
              .Where(i => i.InstitutionType.Name != InstitutionTypesConstants.Kindergarten &&
               i.DetailedInstitutionTypeId == new Guid(detailedInstitutionTypeId))
              .ToListAsync();
            return schools.Count();
        }

        public async Task<int> GetNumberOfAllSchoolsOfFinancialType(string financialTypeId)
        {
            var schools = await repo.All<Institution>()
              .Where(i => i.InstitutionType.Name != InstitutionTypesConstants.Kindergarten &&
               i.FinancialTypeId == new Guid(financialTypeId))
              .ToListAsync();
            return schools.Count();
        }

        //Kindergartens
        public async Task<int> GetNumberOfAllInhabitedAreasForKindergartens()
        {
            var inhabitedAreas = await repo.All<InhabitedArea>()
                .Include(i => i.Institutions)
                .Where(x => x.Institutions.Any(i => i.InstitutionType.Name == InstitutionTypesConstants.Kindergarten))
                .ToListAsync();
            return inhabitedAreas.Count();
        }

        public async Task<int> GetNumberOfAllRegionsForKindergartens()
        {
            var regions = await repo.All<Region>()
                .Include(i => i.Institutions)
                .Where(x => x.Institutions.Any(i => i.InstitutionType.Name == InstitutionTypesConstants.Kindergarten))
                .ToListAsync();
            return regions.Count();
        }

        public async Task<int> GetNumberOfAllFinancialTypesForKindergartens()
        {
            var financialTypes = await repo.All<FinancialType>()
                .Include(i => i.Institutions)
                .Where(x => x.Institutions.Any(i => i.InstitutionType.Name == InstitutionTypesConstants.Kindergarten))
                .ToListAsync();
            return financialTypes.Count();
        }

        public async Task<int> GetNumberOfAllKindergartens()
        {
            var kindergartens = await repo.All<Institution>()
               .Where(i => i.InstitutionType.Name == InstitutionTypesConstants.Kindergarten)
               .ToListAsync();
            return kindergartens.Count();
        }

        public async Task<int> GetNumberOfAllKindergartensInInhabitedArea(string inhabitedAreaId)
        {
            var kindergartens = await repo.All<Institution>()
              .Where(i => i.InstitutionType.Name == InstitutionTypesConstants.Kindergarten &&
               i.InhabitedAreaId == new Guid(inhabitedAreaId))
              .ToListAsync();
            return kindergartens.Count();
        }

        public async Task<int> GetNumberOfAllKindergartensInRegion(string regionId)
        {
            var kindergartens = await repo.All<Institution>()
              .Where(i => i.InstitutionType.Name == InstitutionTypesConstants.Kindergarten &&
               i.RegionId == new Guid(regionId))
              .ToListAsync();
            return kindergartens.Count();
        }

        public async Task<int> GetNumberOfAllKindergartensOfFinancialType(string financialTypeId)
        {
            var kindergartens = await repo.All<Institution>()
               .Where(i => i.InstitutionType.Name == InstitutionTypesConstants.Kindergarten &&
                i.FinancialTypeId == new Guid(financialTypeId))
               .ToListAsync();
            return kindergartens.Count();
        }
    }
}
