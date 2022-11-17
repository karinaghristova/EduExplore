namespace EduExplore.Models
{
    public class PagingViewModel
    {
        public int TotalItems { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalPages => (int)Math.Ceiling((decimal)TotalItems / (decimal)PageSize);

        public int PreviousPage => this.CurrentPage == 1 ? 1 : this.CurrentPage - 1;
        public int NextPage => this.CurrentPage == this.TotalPages ? this.CurrentPage : this.CurrentPage + 1;

        public int FirstPage => 1;
    }
}
