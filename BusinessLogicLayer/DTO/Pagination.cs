using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTO
{
    public class Pagination<T>
    {
        public int TotalItemsCount { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public int TotalPagesCount
        {
            get
            {
                var temp = TotalItemsCount / PageSize;
                if (TotalItemsCount % PageSize == 0)
                {
                    return temp;
                }
                return temp + 1;
            }
        }
        /// <summary>
        /// page number start from 1
        /// </summary>
        public bool Next => PageIndex < TotalPagesCount;
        public bool Previous => PageIndex > 1;
        public ICollection<T> Items { get; set; }

        public Pagination(ICollection<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            Items = items;
            TotalItemsCount = count;
        }


    }
}
