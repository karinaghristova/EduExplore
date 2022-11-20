using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduExplore.Core.Contracts
{
    public interface IStatisticsService
    {
        /// <summary>
        /// Returns the number of all inhabited areas
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllInhabitedAreas();

        /// <summary>
        /// Returns the number of all regions
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllRegions();

        /// <summary>
        /// Returns the number of all institution types
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllInstitutionTypes();

        /// <summary>
        /// Returns the number of all detailed institution types
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllDetailedInstitutionTypes();

        /// <summary>
        /// Returns the number of all financial types
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllFinancialTypes();

        //Schools
        /// <summary>
        /// Returns the number of all inhabited areas where schools are present
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllInhabitedAreasForSchools();

        /// <summary>
        /// Returns the number of all regions where schools are present
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllRegionsForSchools();

        /// <summary>
        /// Returns the number of all institution types related to school
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllInstitutionTypesForSchools();

        /// <summary>
        /// Returns the number of all detailed institution types related to schools
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllDetailedInstitutionTypesForSchools();

        /// <summary>
        /// Returns the number of all financial types that schools have
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllFinancialTypesForSchools();

        /// <summary>
        /// Returns the number of all schools
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllSchools();

        /// <summary>
        /// Returns the number of schools in a given inhabited area
        /// </summary>
        /// <param name="inhabitedAreaId">Id of the inhabited area</param>
        /// <returns></returns>
        Task<int> GetNumberOfAllSchoolsInInhabitedArea(string inhabitedAreaId);

        /// <summary>
        /// Returns the number of all schools in the given region
        /// </summary>
        /// <param name="regionId">Id of the region</param>
        /// <returns></returns>
        Task<int> GetNumberOfAllSchoolsInRegion(string regionId);

        /// <summary>
        /// Returns the number of all schools from the given institution type
        /// </summary>
        /// <param name="institutionTypeId">Id of the institution type</param>
        /// <returns></returns>
        Task<int> GetNumberOfAllSchoolsOfInstitutionType(string institutionTypeId);

        /// <summary>
        /// Returns the number of all schools from the given detailed institution type
        /// </summary>
        /// <param name="detailedInstitutionTypeId">Id of the detailed institution type</param>
        /// <returns></returns>
        Task<int> GetNumberOfAllSchoolsOfDetailedInstitutionType(string detailedInstitutionTypeId);

        /// <summary>
        /// Returns the number of all schools from the given financial type
        /// </summary>
        /// <param name="financialTypeId">Id of the financial type</param>
        /// <returns></returns>
        Task<int> GetNumberOfAllSchoolsOfFinancialType(string financialTypeId);



        //Kindergartens
        /// <summary>
        /// Returns the number of all inhabited areas where kindergartens are present
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllInhabitedAreasForKindergartens();

        /// <summary>
        /// Returns the number of all regions where kinergartens are present
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllRegionsForKindergartens();

        /// <summary>
        /// Returns the number of all financial types that kindergartens have 
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllFinancialTypesForKindergartens();

        /// <summary>
        /// Returns the number of all kindergartens
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllKindergartens();

        /// <summary>
        /// Returns the number of kindergartens in the inhabited area
        /// </summary>
        /// <param name="inhabitedAreaId">Id of the inhabited area</param>
        /// <returns></returns>
        Task<int> GetNumberOfAllKindergartensInInhabitedArea(string inhabitedAreaId);

        /// <summary>
        /// Returns the number of all kindergartens in the given region
        /// </summary>
        /// <param name="regionId">Id of the region</param>
        /// <returns></returns>
        Task<int> GetNumberOfAllKindergartensInRegion(string regionId);

        /// <summary>
        /// Returns the number of all kindergartens from the givven financial type
        /// </summary>
        /// <param name="financialTypeId">id of the financial type</param>
        /// <returns></returns>
        Task<int> GetNumberOfAllKindergartensOfFinancialType(string financialTypeId);
    }
}
