using EduExplore.Core.Contracts;
using EduExplore.Core.Models;
using EduExplore.Infrastructure.Data.DbModels;
using EduExplore.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduExplore.Core.Services
{
    public class InstitutionService : IInstitutionService
    {
        private readonly IApplicationDbRepository repo;

        public InstitutionService(IApplicationDbRepository repo)
        {
            this.repo = repo;
        }

        public async Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllDetailedInstitutionTypes()
        {
            return await repo.All<DetailedInstitutionType>()
                .Select(dit => new NamedCharacteristicListViewModel
                {
                    Name = dit.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllFinancialTypes()
        {
            return await repo.All<FinancialType>()
                .Select(ft => new NamedCharacteristicListViewModel
                {
                    Name = ft.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllInhabitedAreas()
        {
            return await repo.All<InhabitedArea>()
                .Select(i => new NamedCharacteristicListViewModel
                {
                    Name = i.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllInstitutionTypes()
        {
            return await repo.All<InstitutionType>()
                .Select(it => new NamedCharacteristicListViewModel
                {
                    Name = it.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllRegions()
        {
            return await repo.All<Region>()
                .Select(r => new NamedCharacteristicListViewModel
                {
                    Name = r.Name
                })
                .ToListAsync();
        }

        public async Task<int> GetNumberOfAllDetailedInstitutionTypes()
        {
            var detailedInstitutionTypes = await GetAllDetailedInstitutionTypes();
            return detailedInstitutionTypes.Count();
        }

        public async Task<int> GetNumberOfAllFinancialTypes()
        {
            var financialTypes = await GetAllFinancialTypes();
            return financialTypes.Count();
        }

        public async Task<int> GetNumberOfAllInhabitedAreas()
        {
            var inhabitedAreas = await GetAllInhabitedAreas();
            return inhabitedAreas.Count();
        }

        public async Task<int> GetNumberOfAllInstitutionTypes()
        {
            var institutionTypes = await GetAllInstitutionTypes();
            return institutionTypes.Count();
        }

        public async Task<int> GetNumberOfAllRegions()
        {
            var regions = await GetAllRegions();
            return regions.Count();
        }
    }
}
