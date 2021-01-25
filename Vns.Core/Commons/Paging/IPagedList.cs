using System;
using System.Collections.Generic;

namespace Vns.Core.Commons.Paging
{
    public interface IPagedList<T> : IList<T>
    {
        int PageIndex { get; }
        int PageSize { get; }
        int TotalCount { get; }
        int TotalPages { get; }
        bool HasPreviousPage { get; }
        bool HasNextPage { get; }

        Paging Paging { get; }
    }
}
