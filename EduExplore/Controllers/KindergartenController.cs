using EduExplore.Core.Constants;
using EduExplore.Core.Contracts;
using EduExplore.Models;
using EduExplore.Models.Kindergarten;
using Microsoft.AspNetCore.Mvc;

namespace EduExplore.Controllers
{
    public class KindergartenController : Controller
    {
        private readonly IKindergartenService kindergartenService;
        private readonly IInstitutionService institutionService;

        public KindergartenController(IKindergartenService kindergartenService, IInstitutionService institutionService)
        {
            this.kindergartenService = kindergartenService;
            this.institutionService = institutionService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllKindergartens(int page = 1, int pageSize = PageConstants.PageSize20)
        {
            var kindergartens = await kindergartenService.GetAllKindergartens();
            int kindergartensPerPage = pageSize;
            int kindergartensToSkip = page == 1 ? 0 : ((page - 1) * kindergartensPerPage);


            return View(new AllKindergartensViewModel
            {
                Kindergartens = kindergartens.Skip(kindergartensToSkip).Take(kindergartensPerPage),
                Paging = new PagingViewModel
                {
                    CurrentPage = page,
                    TotalItems = kindergartens.Count(),
                    PageSize = kindergartensPerPage
                }
            });
        }

        public async Task<IActionResult> AllKindergartensByInhabitedArea(string inhabitedAreaId, int page = 1, int pageSize = PageConstants.PageSize20)
        {
            var kindergartens = await kindergartenService.GetAllKindergartensByInhabitedArea(inhabitedAreaId);
            int kindergartensPerPage = pageSize;
            int kindergartensToSkip = page == 1 ? 0 : ((page - 1) * kindergartensPerPage);
            var inhabitedArea = await institutionService.GetInhabitedAreaById(inhabitedAreaId);

            return View(new AllKindergartensViewModel
            {
                Kindergartens = kindergartens.Skip(kindergartensToSkip).Take(kindergartensPerPage),
                Paging = new PagingViewModel
                {
                    CurrentPage = page,
                    TotalItems = kindergartens.Count(),
                    PageSize = kindergartensPerPage
                },
                CriteriaId = inhabitedAreaId,
                CriteriaName = inhabitedArea.Name
            });
        }

        public async Task<IActionResult> AllKindergartensByRegion(string regionId, int page = 1, int pageSize = PageConstants.PageSize20)
        {
            var kindergartens = await kindergartenService.GetAllKindergartensByRegion(regionId);
            int kindergartensPerPage = pageSize;
            int kindergartensToSkip = page == 1 ? 0 : ((page - 1) * kindergartensPerPage);
            var region = await institutionService.GetRegionById(regionId);

            return View(new AllKindergartensViewModel
            {
                Kindergartens = kindergartens.Skip(kindergartensToSkip).Take(kindergartensPerPage),
                Paging = new PagingViewModel
                {
                    CurrentPage = page,
                    TotalItems = kindergartens.Count(),
                    PageSize = kindergartensPerPage
                },
                CriteriaId = regionId,
                CriteriaName = region.Name
            });
        }

        public async Task<IActionResult> AllKindergartensByFinancialType(string financialTypeId, int page = 1, int pageSize = PageConstants.PageSize20)
        {
            var kindergartens = await kindergartenService.GetAllKindergartensByFinancialType(financialTypeId);
            int kindergartensPerPage = pageSize;
            int kindergartensToSkip = page == 1 ? 0 : ((page - 1) * kindergartensPerPage);
            var financialType = await institutionService.GetFinancialTypeById(financialTypeId);


            return View(new AllKindergartensViewModel
            {
                Kindergartens = kindergartens.Skip(kindergartensToSkip).Take(kindergartensPerPage),
                Paging = new PagingViewModel
                {
                    CurrentPage = page,
                    TotalItems = kindergartens.Count(),
                    PageSize = kindergartensPerPage
                },
                CriteriaId = financialTypeId,
                CriteriaName = financialType.Name
            });
        }
    }
}
