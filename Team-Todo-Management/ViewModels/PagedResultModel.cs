using System.Collections.Generic;

namespace Team_Todo_Management.ViewModels
{
    public class PagedResultModel<T>
    {
        public int TotalPage { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalRecord { get; set; }
        public List<T> Data { get; set; }
    }
}