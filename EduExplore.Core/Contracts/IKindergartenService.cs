using EduExplore.Core.Models;

namespace EduExplore.Core.Contracts
{
    public interface IKindergartenService
    {
        /// <summary>
        /// Returns a list of all kindergartens
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<InstitutionListViewModel>> GetAllKindergartens();

        /// <summary>
        /// Returns the number of all kindergartens
        /// </summary>
        /// <returns></returns>
        Task<int> GetNumberOfAllKindergartens();


        /// <summary>
        /// Returns a list of all kindergartens in the given inhabited area
        /// </summary>
        /// <param name="inhabitedAreaId">Id of the inhabited area</param>
        /// <returns></returns>
        Task<IEnumerable<InstitutionListViewModel>> GetAllKindergartensByInhabitedArea(string inhabitedAreaId);

        /// <summary>
        /// Returns the number of kindergartens in the inhabited area
        /// </summary>
        /// <param name="inhabitedAreaId">Id of the inhabited area</param>
        /// <returns></returns>
        Task<int> GetNumberOfAllKindergartensInInhabitedArea(string inhabitedAreaId);

        /// <summary>
        /// Returns a list of all kindergartens in the given region
        /// </summary>
        /// <param name="regionId">Id of the region</param>
        /// <returns></returns>
        Task<IEnumerable<InstitutionListViewModel>> GetAllKindergartensByRegion(string regionId);

        /// <summary>
        /// Returns the number of all kindergartens in the given region
        /// </summary>
        /// <param name="regionId">Id of the region</param>
        /// <returns></returns>
        Task<int> GetNumberOfAllKindergartensInRegion(string regionId);

        /// <summary>
        /// Returns a list of all kindergartens from the given financial type
        /// </summary>
        /// <param name="financialTypeId">Id of the financial type</param>
        /// <returns></returns>
        Task<IEnumerable<InstitutionListViewModel>> GetAllKindergartensByFinancialType(string financialTypeId);

        /// <summary>
        /// Returns the number of all kindergartens from the givven financial type
        /// </summary>
        /// <param name="financialTypeId">id of the financial type</param>
        /// <returns></returns>
        Task<int> GetNumberOfAllKindergartensOfFinancialType(string financialTypeId);
    }
}
