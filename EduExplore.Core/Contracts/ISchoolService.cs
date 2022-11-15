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
        /// Returns the number of all schools
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllSchools();

        /// <summary>
        /// Returns a list of all schools in the given inhabited area
        /// </summary>
        /// <param name="inhabitedAreaId">Id of the inhabited area</param>
        /// <returns></returns>
        Task<IEnumerable<InstitutionListViewModel>> GetAllSchoolsByInhabitedArea(string inhabitedAreaId);

        /// <summary>
        /// Returns the number of schools in a given inhabited area
        /// </summary>
        /// <param name="inhabitedAreaId">Id of the inhabited area</param>
        /// <returns></returns>
        Task<int> GetNumberOfAllSchoolsInInhabitedArea(string inhabitedAreaId);

        /// <summary>
        /// Returns a list of schools in the given region
        /// </summary>
        /// <param name="regionId">Id of the region</param>
        /// <returns></returns>
        Task<IEnumerable<InstitutionListViewModel>> GetAllSchoolsByRegion(string regionId);

        /// <summary>
        /// Returns the number of all schools in the given region
        /// </summary>
        /// <param name="regionId">Id of the region</param>
        /// <returns></returns>
        Task<int> GetNumberOfAllSchoolsInRegion(string regionId);


        /// <summary>
        /// Returns a list of all schools from the given institution type
        /// </summary>
        /// <param name="institutionTypeId">Id of the institution type</param>
        /// <returns></returns>
        Task<IEnumerable<InstitutionListViewModel>> GetAllSchoolsByInstitutionType(string institutionTypeId);

        /// <summary>
        /// Returns the number of all schools from the given institution type
        /// </summary>
        /// <param name="institutionTypeId">Id of the institution type</param>
        /// <returns></returns>
        Task<int> GetNumberOfAllSchoolsOfInstitutionType(string institutionTypeId);


        /// <summary>
        /// Returns a list of all schools from the given detailed institution type
        /// </summary>
        /// <param name="detailedInstitutionTypeId">Id of the detailed institution type</param>
        /// <returns></returns>
        Task<IEnumerable<InstitutionListViewModel>> GetAllSchoolsByDetailedInstitutionType(string detailedInstitutionTypeId);

        /// <summary>
        /// Returns the number of all schools from the given detailed institution type
        /// </summary>
        /// <param name="detailedInstitutionTypeId">Id of the detailed institution type</param>
        /// <returns></returns>
        Task<int> GetNumberOfAllSchoolsOfDetailedInstitutionType(string detailedInstitutionTypeId);

        /// <summary>
        /// Returns a list of all schools from the given financial type
        /// </summary>
        /// <param name="financialTypeId">Id of the financial type</param>
        /// <returns></returns>
        Task<IEnumerable<InstitutionListViewModel>> GetAllSchoolsByFinancialType(string financialTypeId);

        /// <summary>
        /// Returns the number of all schools from the given financial type
        /// </summary>
        /// <param name="financialTypeId">Id of the financial type</param>
        /// <returns></returns>
        Task<int> GetNumberOfAllSchoolsOfFinancialType(string financialTypeId);
    }
}
