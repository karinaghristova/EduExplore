using EduExplore.Core.Constants;
using EduExplore.Core.Contracts;
using EduExplore.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduExplore.Controllers
{
    public class KindergartenController : Controller
    {
        private readonly IKindergartenService kindergartenService;

        public KindergartenController(IKindergartenService kindergartenService)
        {
            this.kindergartenService = kindergartenService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllKindergartens(int page = 1)
        {
            var kindergartens = await kindergartenService.GetAllKindergartens();
            int kindergartensPerPage = PageConstants.PageSize20;
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
    }
}
