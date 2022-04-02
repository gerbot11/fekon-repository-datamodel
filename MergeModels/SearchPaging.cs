using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fekon_repository_datamodel.MergeModels
{
    public class SearchPaging<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }
        public int TotalItem { get; private set; }
        public int PageSize { get; private set; }
        public int TotalItemDisplay { get; private set; }

        public SearchPaging(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            TotalItem = count;
            PageSize = pageIndex;
            TotalItemDisplay = items.Count;
            AddRange(items);
        }

        public bool HasPreviousPage => (PageIndex > 1);

        public bool HasNextPage => (PageIndex < TotalPages);

        public IEnumerable<int> PageNumber => SetPageNumberList(PageIndex, TotalPages, (int)Math.Ceiling(TotalPages / (double)3));

        public KeyValuePair<int, int> RangeData => SetRangeData(PageIndex, TotalItem, PageSize);

        public static async Task<SearchPaging<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            int count = await source.CountAsync();
            List<T> items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return new SearchPaging<T>(items, count, pageIndex, pageSize);
        }

        public static SearchPaging<T> CreateFromList(IQueryable<T> source, int pageIndex, int pageSize)
        {
            int count = source.Count();
            List<T> items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new SearchPaging<T>(items, count, pageIndex, pageSize);
        }

        private static List<int> SetPageNumberList(int index, int totalPage, int treshold)
        {
            List<int> pageNum = new();

            if (index <= totalPage)
            {
                for (int i = 0; i < treshold; i++)
                {
                    if (index == totalPage)
                    {
                        pageNum.Add(totalPage);
                        break;
                    }
                    pageNum.Add(index);
                    index++;
                }
            }

            return pageNum;
        }

        private static KeyValuePair<int, int> SetRangeData(int index, int totalItem,int size)
        {
            KeyValuePair<int, int> range;
            if (index == 1)
            {
                range = new(index, (index - 1) * size);
            }
            else
            {
                range = new(index + 1, (index - 1) * size);
            }
            return range;
        }
    }
}
