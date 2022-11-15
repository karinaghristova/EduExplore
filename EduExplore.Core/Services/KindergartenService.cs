using EduExplore.Core.Constants;
using EduExplore.Core.Contracts;
using EduExplore.Core.Models;
using EduExplore.Infrastructure.Data.DbModels;
using EduExplore.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EduExplore.Core.Services
{
    public class KindergartenService : IKindergartenService
    {
        private readonly IApplicationDbRepository repo;

        public KindergartenService(IApplicationDbRepository repo)
        {
            this.repo = repo;
        }

        public async Task<IEnumerable<InstitutionListViewModel>> GetAllKindergartens()
        {
            return await repo.All<Institution>()
               .Where(i => i.InstitutionType.Name == InstitutionTypesConstants.Kindergarten)
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
                   InstitutionType = i.InstitutionType.ToString(),
                   DetailedInstitutionType = i.DetailedInstitutionType.ToString(),
                   FinancialType = i.FinancialType.ToString()
               })
               .ToListAsync();
        }

        public async Task<IEnumerable<InstitutionListViewModel>> GetAllKindergartensByFinancialType(string financialTypeId)
        {
            return await repo.All<Institution>()
               .Where(i => i.InstitutionType.Name == InstitutionTypesConstants.Kindergarten &&
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
                   InstitutionType = i.InstitutionType.ToString(),
                   DetailedInstitutionType = i.DetailedInstitutionType.ToString(),
                   FinancialType = i.FinancialType.ToString()
               })
               .ToListAsync();
        }

        public async Task<IEnumerable<InstitutionListViewModel>> GetAllKindergartensByInhabitedArea(string inhabitedAreaId)
        {
            return await repo.All<Institution>()
              .Where(i => i.InstitutionType.Name == InstitutionTypesConstants.Kindergarten &&
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
                  InstitutionType = i.InstitutionType.ToString(),
                  DetailedInstitutionType = i.DetailedInstitutionType.ToString(),
                  FinancialType = i.FinancialType.ToString()
              })
              .ToListAsync();
        }

        public async Task<IEnumerable<InstitutionListViewModel>> GetAllKindergartensByRegion(string regionId)
        {
            return await repo.All<Institution>()
              .Where(i => i.InstitutionType.Name == InstitutionTypesConstants.Kindergarten &&
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
                  InstitutionType = i.InstitutionType.ToString(),
                  DetailedInstitutionType = i.DetailedInstitutionType.ToString(),
                  FinancialType = i.FinancialType.ToString()
              })
              .ToListAsync();
        }

        public async Task<int> GetNumberOfAllKindergartens()
        {
            var kindergartens = await GetAllKindergartens();
            return kindergartens.Count();
        }

        public async Task<int> GetNumberOfAllKindergartensInInhabitedArea(string inhabitedAreaId)
        {
            var kindergartens = await GetAllKindergartensByInhabitedArea(inhabitedAreaId);
            return kindergartens.Count();
        }

        public async Task<int> GetNumberOfAllKindergartensInRegion(string regionId)
        {
            var kindergartens = await GetAllKindergartensByRegion(regionId);
            return kindergartens.Count();
        }

        public async Task<int> GetNumberOfAllKindergartensOfFinancialType(string financialTypeId)
        {
            var kindergartens = await GetAllKindergartensByFinancialType(financialTypeId);
            return kindergartens.Count();
        }
    }
}
