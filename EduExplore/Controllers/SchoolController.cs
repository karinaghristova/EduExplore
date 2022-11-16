using EduExplore.Core.Constants;
using EduExplore.Core.Contracts;
using EduExplore.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduExplore.Controllers
{
    public class SchoolController : Controller
    {
        private readonly ISchoolService schoolService;

        public SchoolController(ISchoolService schoolService)
        {
            this.schoolService = schoolService;
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
    }
}
