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
            var inhabitedAreas = await institutionService.GetAllInhabitedAreasForSchools();

            return View(new AllNamedCharacteristicsViewModel
            {
                Characteristics = inhabitedAreas
            });
        }

        public async Task<IActionResult> AllRegionsSchool()
        {
            var inhabitedAreas = await institutionService.GetAllRegionsForSchools();

            return View(new AllNamedCharacteristicsViewModel
            {
                Characteristics = inhabitedAreas
            });
        }

        public async Task<IActionResult> AllInstitutionTypesSchool()
        {
            var institutionTypes = await institutionService.GetAllInstitutionTypesForSchools();

            return View(new AllNamedCharacteristicsViewModel
            {
                Characteristics = institutionTypes
            });
        }

        public async Task<IActionResult> AllDetailedInstitutionTypesSchool()
        {
            var detailedInstitutionTypes = await institutionService.GetAllDetailedInstitutionTypesForSchools();

            return View(new AllNamedCharacteristicsViewModel
            {
                Characteristics = detailedInstitutionTypes
            });
        }

        public async Task<IActionResult> AllFinancialTypesSchool()
        {
            var financialTypes = await institutionService.GetAllFinancialTypesForSchools();

            return View(new AllNamedCharacteristicsViewModel
            {
                Characteristics = financialTypes
            });
        }


        //For kindergartens

        public async Task<IActionResult> AllInhabitedAreasKindergarten()
        {
            var inhabitedAreas = await institutionService.GetAllInhabitedAreasForKindergartens();

            return View(new AllNamedCharacteristicsViewModel
            {
                Characteristics = inhabitedAreas
            });
        }

    }
}
