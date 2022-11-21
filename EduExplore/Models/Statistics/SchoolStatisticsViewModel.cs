namespace EduExplore.Models.Statistics
{
    public class SchoolStatisticsViewModel
    {
        public int AllSchoolsCount { get; set; }
        public int SchoolsCountInSofiaCity { get; set; }
        public List<string> InhabitedAreasNames { get; set; }
        public List<int> SchoolsCountInInhabitedAreasList { get; set; }
        public List<string> RegionsNames { get; set; }
        public List<int> SchoolsCountInRegionsList { get; set; }
        public List<string> InstitutionTypesNames { get; set; }
        public List<int> SchoolsCountOfInstitutionTypesList { get; set; }
        public List<string> DetailedInstitutionTypesNames { get; set; }
        public List<int> SchoolsCountOfDetailedInstitutionTypesList { get; set; }
        public List<string> FinancialTypesNames { get; set; }
        public List<int> SchoolsCountOfFinancialTypesList { get; set; }
    }
}
