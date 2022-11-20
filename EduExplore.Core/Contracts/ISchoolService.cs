using EduExplore.Core.Models;

namespace EduExplore.Core.Contracts
{
    public interface ISchoolService
    {
        /// <summary>
        /// Returns a list of all schools
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<InstitutionListViewModel>> GetAllSchools();

        /// <summary>
        /// Returns a list of all schools in the given inhabited area
        /// </summary>
        /// <param name="inhabitedAreaId">Id of the inhabited area</param>
        /// <returns></returns>
        Task<IEnumerable<InstitutionListViewModel>> GetAllSchoolsByInhabitedArea(string inhabitedAreaId);

        /// <summary>
        /// Returns a list of schools in the given region
        /// </summary>
        /// <param name="regionId">Id of the region</param>
        /// <returns></returns>
        Task<IEnumerable<InstitutionListViewModel>> GetAllSchoolsByRegion(string regionId);

        /// <summary>
        /// Returns a list of all schools from the given institution type
        /// </summary>
        /// <param name="institutionTypeId">Id of the institution type</param>
        /// <returns></returns>
        Task<IEnumerable<InstitutionListViewModel>> GetAllSchoolsByInstitutionType(string institutionTypeId);

        /// <summary>
        /// Returns a list of all schools from the given detailed institution type
        /// </summary>
        /// <param name="detailedInstitutionTypeId">Id of the detailed institution type</param>
        /// <returns></returns>
        Task<IEnumerable<InstitutionListViewModel>> GetAllSchoolsByDetailedInstitutionType(string detailedInstitutionTypeId);

        /// <summary>
        /// Returns a list of all schools from the given financial type
        /// </summary>
        /// <param name="financialTypeId">Id of the financial type</param>
        /// <returns></returns>
        Task<IEnumerable<InstitutionListViewModel>> GetAllSchoolsByFinancialType(string financialTypeId);

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
