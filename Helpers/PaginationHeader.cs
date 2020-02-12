namespace CoffeeMugTask.API.Helpers
{
    public class PaginationHeader
    {
        public PaginationHeader(int currentPage, int pageSize, int totalItemsCount, int totalPagesCount)
        {
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalItemsCount = totalItemsCount;
            TotalPagesCount = totalPagesCount;
        }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalItemsCount { get; set; }
        public int TotalPagesCount { get; set; }
        
    }
}