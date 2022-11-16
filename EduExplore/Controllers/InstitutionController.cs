using EduExplore.Core.Contracts;
using EduExplore.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduExplore.Controllers
{
    public class InstitutionController : Controller
    {
        private readonly IInstitutionService institutionService;

        public InstitutionController(IInstitutionService institutionService)
        {
            this.institutionService = institutionService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllInhabitedAreasSchool()
        {
            var inhabitedAreas = await institutionService.GetAllInhabitedAreas();

            return View(new AllNamedCharacteristicsViewModel
            {
                Characteristics = inhabitedAreas
            });
        }

        public async Task<IActionResult> AllRegionsSchool()
        {
            var inhabitedAreas = await institutionService.GetAllRegions();

            return View(new AllNamedCharacteristicsViewModel
            {
                Characteristics = inhabitedAreas
            });
        }

        public async Task<IActionResult> AllInhabitedAreasKindergarten()
        {
            var inhabitedAreas = await institutionService.GetAllInhabitedAreas();

            return View(new AllNamedCharacteristicsViewModel
            {
                Characteristics = inhabitedAreas
            });
        }

    }
}
