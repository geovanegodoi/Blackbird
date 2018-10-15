using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Blackbird.Commom.ExtendedTypes
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex  { get; private set; }

        public int TotalPages { get; private set; }

        public int TotalCount { get; private set; }

        public PaginatedList()
        {

        }

        public PaginatedList(List<T> items, int count, PagingCriteria criteria)
        {
            PageIndex  = criteria.PageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)criteria.PageSize);
            TotalCount = count;
            this.AddRange(items);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }

        public static async Task<PaginatedList<T>> Create(IQueryable<T> source, PagingCriteria criteria)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((criteria.PageIndex - 1) * criteria.PageSize).Take(criteria.PageSize).ToListAsync();
            return new PaginatedList<T>(items, count, criteria);
        }
    }
}
