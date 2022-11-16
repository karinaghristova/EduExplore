using EduExplore.Core.Models;

namespace EduExplore.Core.Contracts
{
    public interface IInstitutionService
    {
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllInhabitedAreas();

        Task<int> GetNumberOfAllInhabitedAreas();

        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllRegions();

        Task<int> GetNumberOfAllRegions();

        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllInstitutionTypes();

        Task<int> GetNumberOfAllInstitutionTypes();

        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllDetailedInstitutionTypes();

        Task<int> GetNumberOfAllDetailedInstitutionTypes();

        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllFinancialTypes();

        Task<int> GetNumberOfAllFinancialTypes();
    }
}
