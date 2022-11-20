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
        /// Returns a list of all kindergartens in the given inhabited area
        /// </summary>
        /// <param name="inhabitedAreaId">Id of the inhabited area</param>
        /// <returns></returns>
        Task<IEnumerable<InstitutionListViewModel>> GetAllKindergartensByInhabitedArea(string inhabitedAreaId);

        /// <summary>
        /// Returns a list of all kindergartens in the given region
        /// </summary>
        /// <param name="regionId">Id of the region</param>
        /// <returns></returns>
        Task<IEnumerable<InstitutionListViewModel>> GetAllKindergartensByRegion(string regionId);

        /// <summary>
        /// Returns a list of all kindergartens from the given financial type
        /// </summary>
        /// <param name="financialTypeId">Id of the financial type</param>
        /// <returns></returns>
        Task<IEnumerable<InstitutionListViewModel>> GetAllKindergartensByFinancialType(string financialTypeId);

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
        /// Returns the desired financial type according to the given id
        /// </summary>
        /// <param name="id">Id of the financial type</param>
        /// <returns></returns>
        Task<NamedCharacteristicListViewModel> GetFinancialTypeById(string id);
    }
}
