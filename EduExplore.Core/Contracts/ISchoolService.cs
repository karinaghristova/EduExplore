using EduExplore.Core.Models;

namespace EduExplore.Core.Contracts
{
    public interface ISchoolService
    {
        Task<IEnumerable<InstitutionListViewModel>> GetAllSchools();
        Task<int> GetNumberOfAllSchools();

        //By Inhabited area
        Task<IEnumerable<InstitutionListViewModel>> GetAllSchoolsByInhabitedArea(string inhabitedAreaId);
        Task<int> GetNumberOfAllSchoolsInInhabitedArea(string inhabitedAreaId);

        //By Region
        Task<IEnumerable<InstitutionListViewModel>> GetAllSchoolsByRegion(string regionId);
        Task<int> GetNumberOfAllSchoolsInRegion(string regionId);


        //By Institution type
        Task<IEnumerable<InstitutionListViewModel>> GetAllSchoolsByInstitutionType(string institutionTypeId);
        Task<int> GetNumberOfAllSchoolsOfInstitutionType(string institutionTypeId);


        //By Detailed institution type
        Task<IEnumerable<InstitutionListViewModel>> GetAllSchoolsByDetailedInstitutionType(string detailedInstitutionTypeId);
        Task<int> GetNumberOfAllSchoolsOfDetailedInstitutionType(string detailedInstitutionTypeId);

        //By Financial Type
        Task<IEnumerable<InstitutionListViewModel>> GetAllSchoolsByFinancialType(string financialTypeId);
        Task<int> GetNumberOfAllSchoolsOfFinancialType(string financialTypeId);
    }
}
