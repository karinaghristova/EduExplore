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
        /// Returns the number of all inhabited areas
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllInhabitedAreas();

        /// <summary>
        /// Returns a list of all regions
        /// </summary>
        /// <returns></returns>

        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllRegions();

       
        /// <summary>
        /// Returns the number of all regions
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllRegions();

        /// <summary>
        /// Returns a list of all institution types
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllInstitutionTypes();

       
        /// <summary>
        /// Returns the number of all institution types
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllInstitutionTypes();

        /// <summary>
        /// Returns a list of all detailed institution types
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllDetailedInstitutionTypes();

        /// <summary>
        /// Returns the number of all detailed institution types
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllDetailedInstitutionTypes();

       
        /// <summary>
        /// Returns a list of all financial types 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllFinancialTypes();


        /// <summary>
        /// Returns the number of all financial types
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllFinancialTypes();

        //For schools
        /// <summary>
        /// Returns a list of all inhabited areas where schools are present
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllInhabitedAreasForSchools();

        /// <summary>
        /// Returns the number of all inhabited areas where schools are present
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllInhabitedAreasForSchools();

        /// <summary>
        /// Returns a list of all regions where schools are present
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllRegionsForSchools();

        /// <summary>
        /// Returns the number of all regions where schools are present
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllRegionsForSchools();

        /// <summary>
        /// Returns a list of all institution types related to schools
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllInstitutionTypesForSchools();

        /// <summary>
        /// Returns the number of all institution types related to school
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllInstitutionTypesForSchools();

        /// <summary>
        /// Returns a list of all detailed institution types related to schools
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllDetailedInstitutionTypesForSchools();

        /// <summary>
        /// Returns the number of all detailed institution types related to schools
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllDetailedInstitutionTypesForSchools();

        /// <summary>
        /// Returns a list of all financial types that schools have
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllFinancialTypesForSchools();

        /// <summary>
        /// Returns the number of all financial types that schools have
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllFinancialTypesForSchools();

        //For kindergartens
        /// <summary>
        /// Returns a list of all inhabited areas where kindergartens are present
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllInhabitedAreasForKindergartens();

        /// <summary>
        /// Returns the number of all inhabited areas where kindergartens are present
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllInhabitedAreasForKindergartens();

        /// <summary>
        /// Returns a list of all regions where kindergartens are present
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllRegionsForKindergartens();

        /// <summary>
        /// Returns the number of all regions where kinergartens are present
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllRegionsForKindergartens();

        /// <summary>
        /// Returns a list of all financial types that kindergartens have
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<NamedCharacteristicListViewModel>> GetAllFinancialTypesForKindergartens();

        /// <summary>
        /// Returns the number of all financial types that kindergartens have 
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllFinancialTypesForKindergartens();

        //Mutual methods
        /// <summary>
        /// Returns the desired inahbited area according to the given id
        /// </summary>
        /// <param name="id">Id of the inhabited area</param>
        /// <returns></returns>
        Task<NamedCharacteristicListViewModel> GetInhabitedAreaById(string id);

        /// <summary>
        /// Returns the desired region according to the given id
        /// </summary>
        /// <param name="id">Id of the region</param>
        /// <returns></returns>
        Task<NamedCharacteristicListViewModel> GetRegionById(string id);

        /// <summary>
        /// Returns the desired institution type according to the given id
        /// </summary>
        /// <param name="id">Id of the institution type</param>
        /// <returns></returns>
        Task<NamedCharacteristicListViewModel> GetInstitutionTypeById(string id);

        /// <summary>
        /// Returns the desired detailed institution type according to the given id
        /// </summary>
        /// <param name="id">Id of the detailed institution type</param>
        /// <returns></returns>
        Task<NamedCharacteristicListViewModel> GetDetailedInstitutionTypeById(string id);

        /// <summary>
        /// Returns the desired financial type according to the given id
        /// </summary>
        /// <param name="id">Id of the financial type</param>
        /// <returns></returns>
        Task<NamedCharacteristicListViewModel> GetFinancialTypeById(string id);
    }
}
