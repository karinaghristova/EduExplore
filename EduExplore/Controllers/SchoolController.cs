using EduExplore.Core.Constants;
using EduExplore.Core.Contracts;
using EduExplore.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduExplore.Controllers
{
    public class SchoolController : Controller
    {
        private readonly ISchoolService schoolService;
        private readonly IInstitutionService institutionService;

        public SchoolController(ISchoolService schoolService, IInstitutionService institutionService)
        {
            this.schoolService = schoolService;
            this.institutionService = institutionService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllSchools(int page = 1, int pageSize = PageConstants.PageSize20)
        {
            var schools = await schoolService.GetAllSchools();
            int schoolsPerPage = pageSize;
            int schoolsToSkip = page == 1 ? 0 : ((page - 1) * schoolsPerPage);


            return View(new AllSchoolsViewModel
            {
                Schools = schools.Skip(schoolsToSkip).Take(schoolsPerPage),
                Paging = new PagingViewModel
                {
                    CurrentPage = page,
                    TotalItems = schools.Count(),
                    PageSize = schoolsPerPage
                }
            });
        }

        public async Task<IActionResult> AllSchoolsByInhabitedArea(string inhabitedAreaId,int page = 1, int pageSize = PageConstants.PageSize20)
        {
            var schools = await schoolService.GetAllSchoolsByInhabitedArea(inhabitedAreaId);
            int schoolsPerPage = pageSize;
            int schoolsToSkip = page == 1 ? 0 : ((page - 1) * schoolsPerPage);
            var inhabitedArea = await institutionService.GetInhabitedAreaById(inhabitedAreaId);

            return View(new AllSchoolsViewModel
            {
                Schools = schools.Skip(schoolsToSkip).Take(schoolsPerPage),
                Paging = new PagingViewModel
                {
                    CurrentPage = page,
                    TotalItems = schools.Count(),
                    PageSize = schoolsPerPage
                },
                CriteriaId = inhabitedAreaId,
                CriteriaName = inhabitedArea.Name
            });
        }

        public async Task<IActionResult> AllSchoolsByRegion(string regionId, int page = 1, int pageSize = PageConstants.PageSize20)
        {
            var schools = await schoolService.GetAllSchoolsByRegion(regionId);
            int schoolsPerPage = pageSize;
            int schoolsToSkip = page == 1 ? 0 : ((page - 1) * schoolsPerPage);
            var region = await institutionService.GetRegionById(regionId);


            return View(new AllSchoolsViewModel
            {
                Schools = schools.Skip(schoolsToSkip).Take(schoolsPerPage),
                Paging = new PagingViewModel
                {
                    CurrentPage = page,
                    TotalItems = schools.Count(),
                    PageSize = schoolsPerPage
                },
                CriteriaId = regionId,
                CriteriaName = region.Name
            });
        }

        public async Task<IActionResult> AllSchoolsByInstitutionType(string institutionTypeId, int page = 1, int pageSize = PageConstants.PageSize20)
        {
            var schools = await schoolService.GetAllSchoolsByInstitutionType(institutionTypeId);
            int schoolsPerPage = pageSize;
            int schoolsToSkip = page == 1 ? 0 : ((page - 1) * schoolsPerPage);
            var institutionType = await institutionService.GetInstitutionTypeById(institutionTypeId);

            return View(new AllSchoolsViewModel
            {
                Schools = schools.Skip(schoolsToSkip).Take(schoolsPerPage),
                Paging = new PagingViewModel
                {
                    CurrentPage = page,
                    TotalItems = schools.Count(),
                    PageSize = schoolsPerPage
                },
                CriteriaId = institutionTypeId,
                CriteriaName = institutionType.Name
            });
        }

        public async Task<IActionResult> AllSchoolsByDetailedInstitutionType(string detailedInstitutionTypeId, int page = 1, int pageSize = PageConstants.PageSize20)
        {
            var schools = await schoolService.GetAllSchoolsByDetailedInstitutionType(detailedInstitutionTypeId);
            int schoolsPerPage = pageSize;
            int schoolsToSkip = page == 1 ? 0 : ((page - 1) * schoolsPerPage);
            var detailedInstitutionType = await institutionService.GetDetailedInstitutionTypeById(detailedInstitutionTypeId);

            return View(new AllSchoolsViewModel
            {
                Schools = schools.Skip(schoolsToSkip).Take(schoolsPerPage),
                Paging = new PagingViewModel
                {
                    CurrentPage = page,
                    TotalItems = schools.Count(),
                    PageSize = schoolsPerPage
                },
                CriteriaId = detailedInstitutionTypeId,
                CriteriaName = detailedInstitutionType.Name
            });
        }

        public async Task<IActionResult> AllSchoolsByFinancialType(string financialTypeId, int page = 1, int pageSize = PageConstants.PageSize20)
        {
            var schools = await schoolService.GetAllSchoolsByFinancialType(financialTypeId);
            int schoolsPerPage = pageSize;
            int schoolsToSkip = page == 1 ? 0 : ((page - 1) * schoolsPerPage);
            var financialType = await institutionService.GetFinancialTypeById(financialTypeId);

            return View(new AllSchoolsViewModel
            {
                Schools = schools.Skip(schoolsToSkip).Take(schoolsPerPage),
                Paging = new PagingViewModel
                {
                    CurrentPage = page,
                    TotalItems = schools.Count(),
                    PageSize = schoolsPerPage
                },
                CriteriaId = financialTypeId,
                CriteriaName = financialType.Name
            });
        }
    }
}
