using EduExplore.Core.Constants;
using EduExplore.Core.Contracts;
using EduExplore.Core.Models;
using EduExplore.Infrastructure.Data.DbModels;
using EduExplore.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EduExplore.Core.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly IApplicationDbRepository repo;

        public SchoolService(IApplicationDbRepository repo)
        {
            this.repo = repo;
        }

        public async Task<IEnumerable<InstitutionListViewModel>> GetAllSchools()
        {
            return await repo.All<Institution>()
                .Where(i => i.InstitutionType.Name != InstitutionTypesConstants.Kindergarten)
                .Include(d => d.District)
                .Include(m => m.Municipality)
                .Include(i => i.InhabitedArea)
                .Include(r => r.Region)
                .Include(it => it.InstitutionType)
                .Include(dit => dit.DetailedInstitutionType)
                .Include(f => f.FinancialType)
                .Select(i => new InstitutionListViewModel
                {
                    Id = i.Id.ToString(),
                    Name = i .Name.ToString(),
                    District = i.District.Name.ToString(),
                    Municipality = i.Municipality.Name.ToString(),
                    InhabitedArea = i.InhabitedArea.Name.ToString(),
                    Region = i.Region.Name.ToString(),
                    InstitutionType = i.InstitutionType.Name.ToString(),
                    DetailedInstitutionType = i.DetailedInstitutionType.Name.ToString(),
                    FinancialType = i.FinancialType.Name.ToString()
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<InstitutionListViewModel>> GetAllSchoolsByDetailedInstitutionType(string detailedInstitutionTypeId)
        {
            return await repo.All<Institution>()
              .Where(i => i.InstitutionType.Name != InstitutionTypesConstants.Kindergarten &&
               i.DetailedInstitutionTypeId == new Guid(detailedInstitutionTypeId))
              .Include(d => d.District)
              .Include(m => m.Municipality)
              .Include(i => i.InhabitedArea)
              .Include(r => r.Region)
              .Include(it => it.InstitutionType)
              .Include(dit => dit.DetailedInstitutionType)
              .Include(f => f.FinancialType)
              .Select(i => new InstitutionListViewModel
              {
                  Id = i.Id.ToString(),
                  Name = i.Name.ToString(),
                  District = i.District.Name.ToString(),
                  Municipality = i.Municipality.Name.ToString(),
                  InhabitedArea = i.InhabitedArea.Name.ToString(),
                  Region = i.Region.Name.ToString(),
                  InstitutionType = i.InstitutionType.Name.ToString(),
                  DetailedInstitutionType = i.DetailedInstitutionType.Name.ToString(),
                  FinancialType = i.FinancialType.Name.ToString()
              })
              .ToListAsync();
        }

        public async Task<IEnumerable<InstitutionListViewModel>> GetAllSchoolsByFinancialType(string financialTypeId)
        {
            return await repo.All<Institution>()
              .Where(i => i.InstitutionType.Name != InstitutionTypesConstants.Kindergarten &&
               i.FinancialTypeId == new Guid(financialTypeId))
              .Include(d => d.District)
              .Include(m => m.Municipality)
              .Include(i => i.InhabitedArea)
              .Include(r => r.Region)
              .Include(it => it.InstitutionType)
              .Include(dit => dit.DetailedInstitutionType)
              .Include(f => f.FinancialType)
              .Select(i => new InstitutionListViewModel
              {
                  Id = i.Id.ToString(),
                  Name = i.Name.ToString(),
                  District = i.District.Name.ToString(),
                  Municipality = i.Municipality.Name.ToString(),
                  InhabitedArea = i.InhabitedArea.Name.ToString(),
                  Region = i.Region.Name.ToString(),
                  InstitutionType = i.InstitutionType.Name.ToString(),
                  DetailedInstitutionType = i.DetailedInstitutionType.Name.ToString(),
                  FinancialType = i.FinancialType.Name.ToString()
              })
              .ToListAsync();
        }

        public async Task<IEnumerable<InstitutionListViewModel>> GetAllSchoolsByInhabitedArea(string inhabitedAreaId)
        {
            return await repo.All<Institution>()
              .Where(i => i.InstitutionType.Name != InstitutionTypesConstants.Kindergarten &&
               i.InhabitedAreaId == new Guid(inhabitedAreaId))
              .Include(d => d.District)
              .Include(m => m.Municipality)
              .Include(i => i.InhabitedArea)
              .Include(r => r.Region)
              .Include(it => it.InstitutionType)
              .Include(dit => dit.DetailedInstitutionType)
              .Include(f => f.FinancialType)
              .Select(i => new InstitutionListViewModel
              {
                  Id = i.Id.ToString(),
                  Name = i.Name.ToString(),
                  District = i.District.Name.ToString(),
                  Municipality = i.Municipality.Name.ToString(),
                  InhabitedArea = i.InhabitedArea.Name.ToString(),
                  Region = i.Region.Name.ToString(),
                  InstitutionType = i.InstitutionType.Name.ToString(),
                  DetailedInstitutionType = i.DetailedInstitutionType.Name.ToString(),
                  FinancialType = i.FinancialType.Name.ToString()
              })
              .ToListAsync();
        }

        public async Task<IEnumerable<InstitutionListViewModel>> GetAllSchoolsByInstitutionType(string institutionTypeId)
        {
            return await repo.All<Institution>()
              .Where(i => i.InstitutionType.Name != InstitutionTypesConstants.Kindergarten &&
               i.InstitutionTypeId == new Guid(institutionTypeId))
              .Include(d => d.District)
              .Include(m => m.Municipality)
              .Include(i => i.InhabitedArea)
              .Include(r => r.Region)
              .Include(it => it.InstitutionType)
              .Include(dit => dit.DetailedInstitutionType)
              .Include(f => f.FinancialType)
              .Select(i => new InstitutionListViewModel
              {
                  Id = i.Id.ToString(),
                  Name = i.Name.ToString(),
                  District = i.District.Name.ToString(),
                  Municipality = i.Municipality.Name.ToString(),
                  InhabitedArea = i.InhabitedArea.Name.ToString(),
                  Region = i.Region.Name.ToString(),
                  InstitutionType = i.InstitutionType.Name.ToString(),
                  DetailedInstitutionType = i.DetailedInstitutionType.Name.ToString(),
                  FinancialType = i.FinancialType.Name.ToString()
              })
              .ToListAsync();
        }

        public async Task<IEnumerable<InstitutionListViewModel>> GetAllSchoolsByRegion(string regionId)
        {
            return await repo.All<Institution>()
              .Where(i => i.InstitutionType.Name != InstitutionTypesConstants.Kindergarten &&
               i.RegionId == new Guid(regionId))
              .Include(d => d.District)
              .Include(m => m.Municipality)
              .Include(i => i.InhabitedArea)
              .Include(r => r.Region)
              .Include(it => it.InstitutionType)
              .Include(dit => dit.DetailedInstitutionType)
              .Include(f => f.FinancialType)
              .Select(i => new InstitutionListViewModel
              {
                  Id = i.Id.ToString(),
                  Name = i.Name.ToString(),
                  District = i.District.Name.ToString(),
                  Municipality = i.Municipality.Name.ToString(),
                  InhabitedArea = i.InhabitedArea.Name.ToString(),
                  Region = i.Region.Name.ToString(),
                  InstitutionType = i.InstitutionType.Name.ToString(),
                  DetailedInstitutionType = i.DetailedInstitutionType.Name.ToString(),
                  FinancialType = i.FinancialType.Name.ToString()
              })
              .ToListAsync();
        }

        public async Task<int> GetNumberOfAllSchools()
        {
            var schools = await GetAllSchools();
            return schools.Count();
        }

        public async Task<int> GetNumberOfAllSchoolsInInhabitedArea(string inhabitedAreaId)
        {
            var schools = await GetAllSchoolsByInhabitedArea(inhabitedAreaId);
            return schools.Count();
        }

        public async Task<int> GetNumberOfAllSchoolsInRegion(string regionId)
        {
            var schools = await GetAllSchoolsByRegion(regionId);
            return schools.Count();
        }

        public async Task<int> GetNumberOfAllSchoolsOfDetailedInstitutionType(string detailedInstitutionTypeId)
        {
            var schools = await GetAllSchoolsByDetailedInstitutionType(detailedInstitutionTypeId);
            return schools.Count();
        }

        public async Task<int> GetNumberOfAllSchoolsOfFinancialType(string financialTypeId)
        {
            var schools = await GetAllSchoolsByFinancialType(financialTypeId);
            return schools.Count();
        }

        public async Task<int> GetNumberOfAllSchoolsOfInstitutionType(string institutionTypeId)
        {
            var schools = await GetAllSchoolsByInstitutionType(institutionTypeId);
            return schools.Count();
        }
    }
}
