using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoffeeMugTask.API.Helpers
{
    public class PagedList<T> : List<T>
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalItemsCount { get; set; }
        public int TotalPagesCount { get; set; }

        public PagedList(List<T> items, int totalItemsCount, int pageNumber, int pageSize)
        {
            CurrentPage = pageNumber;
            PageSize = pageSize;
            TotalItemsCount = totalItemsCount;
            TotalPagesCount = (int)Math.Ceiling(TotalItemsCount/(double)pageSize);

            this.AddRange(items);
        }

        public static async Task<PagedList<T>> CreateListAsync(IQueryable<T> source, int pageSize, int pageNumber)
        {
            var totalItemsCount = await source.CountAsync();
            var items = await source.Skip((pageNumber-1) * pageSize).Take(pageSize).ToListAsync();

            return new PagedList<T>(items, totalItemsCount, pageNumber, pageSize);
        }
    }
}