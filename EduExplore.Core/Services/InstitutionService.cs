using EduExplore.Core.Constants;
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

        public async Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllInhabitedAreas()
        {
            return await repo.All<InhabitedArea>()
                .Select(i => new NamedCharacteristicListViewModel
                {
                    Id = i.Id.ToString(),
                    Name = i.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllRegions()
        {
            return await repo.All<Region>()
                .Select(r => new NamedCharacteristicListViewModel
                {
                    Id = r.Id.ToString(),
                    Name = r.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllInstitutionTypes()
        {
            return await repo.All<InstitutionType>()
                .Select(it => new NamedCharacteristicListViewModel
                {
                    Id = it.Id.ToString(),
                    Name = it.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllDetailedInstitutionTypes()
        {
            return await repo.All<DetailedInstitutionType>()
                .Select(dit => new NamedCharacteristicListViewModel
                {
                    Id = dit.Id.ToString(),
                    Name = dit.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllFinancialTypes()
        {
            return await repo.All<FinancialType>()
                .Select(ft => new NamedCharacteristicListViewModel
                {
                    Id = ft.Id.ToString(),
                    Name = ft.Name
                })
                .ToListAsync();
        }

        //Schools
        public async Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllInhabitedAreasForSchools()
        {
            return await repo.All<InhabitedArea>()
                .Include(i => i.Institutions)
                .Where(x => x.Institutions.Any(i => i.InstitutionType.Name != InstitutionTypesConstants.Kindergarten))
                .Select(i => new NamedCharacteristicListViewModel
                {
                    Id = i.Id.ToString(),
                    Name = i.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllRegionsForSchools()
        {
            return await repo.All<Region>()
               .Include(i => i.Institutions)
               .Where(x => x.Institutions.Any(i => i.InstitutionType.Name != InstitutionTypesConstants.Kindergarten))
               .Select(r => new NamedCharacteristicListViewModel
               {
                   Id = r.Id.ToString(),
                   Name = r.Name
               })
               .ToListAsync();
        }

        public async Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllInstitutionTypesForSchools()
        {
            return await repo.All<InstitutionType>()
                .Where(x => x.Name != InstitutionTypesConstants.Kindergarten)
                .Select(it => new NamedCharacteristicListViewModel
                {
                    Id = it.Id.ToString(),
                    Name = it.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllDetailedInstitutionTypesForSchools()
        {
            return await repo.All<DetailedInstitutionType>()
                .Where(dit => dit.Name != InstitutionTypesConstants.Kindergarten)
                .Select(dit => new NamedCharacteristicListViewModel
                {
                    Id = dit.Id.ToString(),
                    Name = dit.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllFinancialTypesForSchools()
        {
            return await repo.All<FinancialType>()
               .Include(i => i.Institutions)
               .Where(x => x.Institutions.Any(i => i.InstitutionType.Name != InstitutionTypesConstants.Kindergarten))
               .Select(ft => new NamedCharacteristicListViewModel
               {
                   Id = ft.Id.ToString(),
                   Name = ft.Name
               })
               .ToListAsync();
        }

        //Kindergartens
        public async Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllInhabitedAreasForKindergartens()
        {
            return await repo.All<InhabitedArea>()
                .Include(i => i.Institutions)
                .Where(x => x.Institutions.Any(i => i.InstitutionType.Name == InstitutionTypesConstants.Kindergarten))
                .Select(i => new NamedCharacteristicListViewModel
                {
                    Id = i.Id.ToString(),
                    Name = i.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllRegionsForKindergartens()
        {
            return await repo.All<Region>()
               .Include(i => i.Institutions)
               .Where(x => x.Institutions.Any(i => i.InstitutionType.Name == InstitutionTypesConstants.Kindergarten))
               .Select(r => new NamedCharacteristicListViewModel
               {
                   Id = r.Id.ToString(),
                   Name = r.Name
               })
               .ToListAsync();
        }

        public async Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllFinancialTypesForKindergartens()
        {
            return await repo.All<FinancialType>()
               .Include(i => i.Institutions)
               .Where(x => x.Institutions.Any(i => i.InstitutionType.Name == InstitutionTypesConstants.Kindergarten))
               .Select(ft => new NamedCharacteristicListViewModel
               {
                   Id = ft.Id.ToString(),
                   Name = ft.Name
               })
               .ToListAsync();
        }
    }
}
