using EduExplore.Core.Models;

namespace EduExplore.Core.Contracts
{
    public interface IInstitutionService
    {
        /// <summary>
        /// Returns a list of all inhabited areas
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllInhabitedAreas();

        /// <summary>
        /// Returns a list of all regions
        /// </summary>
        /// <returns></returns>

        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllRegions();

        /// <summary>
        /// Returns a list of all institution types
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllInstitutionTypes();

        /// <summary>
        /// Returns a list of all detailed institution types
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllDetailedInstitutionTypes();

        /// <summary>
        /// Returns a list of all financial types 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllFinancialTypes();

        //For schools
        /// <summary>
        /// Returns a list of all inhabited areas where schools are present
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllInhabitedAreasForSchools();

        /// <summary>
        /// Returns a list of all regions where schools are present
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllRegionsForSchools();

        /// <summary>
        /// Returns a list of all institution types related to schools
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllInstitutionTypesForSchools();

        /// <summary>
        /// Returns a list of all detailed institution types related to schools
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllDetailedInstitutionTypesForSchools();

        /// <summary>
        /// Returns a list of all financial types that schools have
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllFinancialTypesForSchools();

        //For kindergartens
        /// <summary>
        /// Returns a list of all inhabited areas where kindergartens are present
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllInhabitedAreasForKindergartens();

        /// <summary>
        /// Returns a list of all regions where kindergartens are present
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllRegionsForKindergartens();

        /// <summary>
        /// Returns a list of all financial types that kindergartens have
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllFinancialTypesForKindergartens();
    }
}
