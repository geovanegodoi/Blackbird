using System;
namespace Blackbird.Commom.ExtendedTypes
{
    public class PagingCriteria
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public PagingCriteria()
        {
            PageIndex = 1;
            PageSize = 5;
        }

        public PagingCriteria(int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
        }
    }
}
