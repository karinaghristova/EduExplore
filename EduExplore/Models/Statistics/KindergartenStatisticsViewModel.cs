namespace EduExplore.Models.Statistics
{
    public class KindergartenStatisticsViewModel
    {
        public int AllKindergartensCount { get; set; }
        public int KindergartensCountInSofiaCity { get; set; }
        public int KindergartensCountOutsideSofiaCity => AllKindergartensCount - KindergartensCountInSofiaCity;
        public List<string> InhabitedAreasNames { get; set; }
        public List<int> KindergartensCountInInhabitedAreasList { get; set; }
        public List<string> RegionsNames { get; set; }
        public List<int> KindergartensCountInRegionsList { get; set; }
        public List<string> FinancialTypesNames { get; set; }
        public List<int> KindergartensCountOfFinancialTypesList { get; set; }
    }
}
