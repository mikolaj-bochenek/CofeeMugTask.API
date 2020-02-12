namespace CoffeeMugTask.API.Helpers
{
    public class ProductParams
    {
        public const int MaxPageSize = 10;
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 5;
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }
        
        public string OrderBy { get; set; }
    }
}