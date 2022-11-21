using EduExplore.Core.Constants;
using EduExplore.Core.Contracts;
using EduExplore.Models.Statistics;
using Microsoft.AspNetCore.Mvc;

namespace EduExplore.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IStatisticsService statisticsService;
        private readonly IInstitutionService institutionService;

        public StatisticsController(IStatisticsService statisticsService, IInstitutionService institutionService)
        {
            this.statisticsService = statisticsService;
            this.institutionService = institutionService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllStatistics()
        {
            var allSchoolsCount = await statisticsService.GetNumberOfAllSchools();
            var allKindergartensCount = await statisticsService.GetNumberOfAllKindergartens();
            var numberOfInhabitedAreasWithSchools = await statisticsService.GetNumberOfAllInhabitedAreasForSchools();
            var numberOfInhabitedAreasWithKindergartens = await statisticsService.GetNumberOfAllInhabitedAreasForKindergartens();

            return View(new SchoolsVsKindergartensStatisticsViewModel()
            {
                AllSchoolsCount = allSchoolsCount,
                AllKindergartensCount = allKindergartensCount,
                NumberOfInhabitedAreasWithSchools = numberOfInhabitedAreasWithSchools,
                NumberOfInhabitedAreasWithKindergartens = numberOfInhabitedAreasWithKindergartens
            });
        }

        public async Task<IActionResult> SchoolStatistics()
        {
            var schoolsInSofiaCity = 0;
            var allSchoolsCount = await statisticsService.GetNumberOfAllSchools();
            var allInhabitedAreas = await institutionService.GetAllInhabitedAreasForSchools();
            var allRegions = await institutionService.GetAllRegionsForSchools();
            var allInstitutionTypes = await institutionService.GetAllInstitutionTypesForSchools();
            var allDetailedInstitutionTypes = await institutionService.GetAllDetailedInstitutionTypesForSchools();
            var allFinancialTypes = await institutionService.GetAllFinancialTypesForSchools();

            var inhabitedAreasNameList = new List<string>();
            var inhabitedAreasSchoolCount = new List<int>();
            var regionsNameList = new List<string>();
            var regionsSchoolCount = new List<int>();
            var institutionTypesNameList = new List<string>();
            var institutionTypesSchoolCount = new List<int>();
            var detailedInstitutionTypesNameList = new List<string>();
            var detailedInstitutionTypesSchoolCount = new List<int>();
            var financialTypesNameList = new List<string>();
            var financialTypesSchoolCount = new List<int>();

            foreach (var inhabitedArea in allInhabitedAreas)
            {
                if (inhabitedArea.Name != "София")
                {
                    inhabitedAreasNameList.Add(inhabitedArea.Name);
                    var schoolsCount = await statisticsService.GetNumberOfAllSchoolsInInhabitedArea(inhabitedArea.Id);
                    inhabitedAreasSchoolCount.Add(schoolsCount);
                }
                else
                {
                    schoolsInSofiaCity = await statisticsService.GetNumberOfAllSchoolsInInhabitedArea(inhabitedArea.Id);
                }
            }

            foreach (var region in allRegions)
            {
                regionsNameList.Add(region.Name);
                var schoolsCount = await statisticsService.GetNumberOfAllSchoolsInRegion(region.Id);
                regionsSchoolCount.Add(schoolsCount);
            }

            foreach (var institutionType in allInstitutionTypes)
            {
                institutionTypesNameList.Add(institutionType.Name);
                var schoolsCount = await statisticsService.GetNumberOfAllSchoolsOfInstitutionType(institutionType.Id);
                institutionTypesSchoolCount.Add(schoolsCount);
            }

            foreach (var detailedInstitutionType in allDetailedInstitutionTypes)
            {
                detailedInstitutionTypesNameList.Add(detailedInstitutionType.Name);
                var schoolsCount = await statisticsService.GetNumberOfAllSchoolsOfDetailedInstitutionType(detailedInstitutionType.Id);
                detailedInstitutionTypesSchoolCount.Add(schoolsCount);
            }

            foreach (var financialType in allFinancialTypes)
            {
                financialTypesNameList.Add(financialType.Name);
                var schoolsCount = await statisticsService.GetNumberOfAllSchoolsOfFinancialType(financialType.Id);
                financialTypesSchoolCount.Add(schoolsCount);
            }

            return View(new SchoolStatisticsViewModel()
            {
                AllSchoolsCount = allSchoolsCount,
                SchoolsCountInSofiaCity = schoolsInSofiaCity,
                InhabitedAreasNames = inhabitedAreasNameList,
                SchoolsCountInInhabitedAreasList = inhabitedAreasSchoolCount,
                RegionsNames = regionsNameList,
                SchoolsCountInRegionsList = regionsSchoolCount,
                InstitutionTypesNames = institutionTypesNameList,
                SchoolsCountOfInstitutionTypesList = institutionTypesSchoolCount,
                DetailedInstitutionTypesNames = detailedInstitutionTypesNameList,
                SchoolsCountOfDetailedInstitutionTypesList = detailedInstitutionTypesSchoolCount,
                FinancialTypesNames = financialTypesNameList,
                SchoolsCountOfFinancialTypesList = financialTypesSchoolCount
            });
        }

        public async Task<IActionResult> KindergartenStatistics()
        {
            var kindergartensInSofiaCity = 0;
            var allKindergartensCount = await statisticsService.GetNumberOfAllKindergartens();
            var allInhabitedAreas = await institutionService.GetAllInhabitedAreasForKindergartens();
            var allRegions = await institutionService.GetAllRegionsForKindergartens();
            var allFinancialTypes = await institutionService.GetAllFinancialTypesForKindergartens();

            var inhabitedAreasNameList = new List<string>();
            var inhabitedAreasKindergartensCount = new List<int>();
            var regionsNameList = new List<string>();
            var regionsKindergartensCount = new List<int>();
            var financialTypesNameList = new List<string>();
            var financialTypesKindergartensCount = new List<int>();

            foreach (var inhabitedArea in allInhabitedAreas)
            {
                if (inhabitedArea.Name != "София")
                {
                    inhabitedAreasNameList.Add(inhabitedArea.Name);
                    var schoolsCount = await statisticsService.GetNumberOfAllKindergartensInInhabitedArea(inhabitedArea.Id);
                    inhabitedAreasKindergartensCount.Add(schoolsCount);
                }
                else
                {
                    kindergartensInSofiaCity = await statisticsService.GetNumberOfAllKindergartensInInhabitedArea(inhabitedArea.Id);
                }
            }

            foreach (var region in allRegions)
            {
                regionsNameList.Add(region.Name);
                var kindergarttensCount = await statisticsService.GetNumberOfAllKindergartensInRegion(region.Id);
                regionsKindergartensCount.Add(kindergarttensCount);
            }

            foreach (var financialType in allFinancialTypes)
            {
                financialTypesNameList.Add(financialType.Name);
                var kindergartensCount = await statisticsService.GetNumberOfAllKindergartensOfFinancialType(financialType.Id);
                financialTypesKindergartensCount.Add(kindergartensCount);
            }


            return View(new KindergartenStatisticsViewModel()
            {
                AllKindergartensCount = allKindergartensCount,
                KindergartensCountInSofiaCity = kindergartensInSofiaCity,
                InhabitedAreasNames = inhabitedAreasNameList,
                KindergartensCountInInhabitedAreasList = inhabitedAreasKindergartensCount,
                RegionsNames = regionsNameList,
                KindergartensCountInRegionsList = regionsKindergartensCount,
                FinancialTypesNames = financialTypesNameList,
                KindergartensCountOfFinancialTypesList = financialTypesKindergartensCount
            });
        }
    }
}
