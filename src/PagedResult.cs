using System.Collections.Immutable;
namespace Microsoft.EntityFrameworkCore.Pagination;

public class PagedResult<T>
{
    public PagedResult(IQueryable<T> query, int pageIndex, int pageSize, long totalItemsCount)
    {
        if (query == null)
            throw new ArgumentNullException(nameof(query));
        Items = query.Page(pageIndex, pageSize).ToImmutableArray();
        PageIndex = pageIndex;
        PageSize = pageSize;
        TotalItemsCount = totalItemsCount;
        TotalPagesCount = pageSize != 0L ? (long)Math.Ceiling(totalItemsCount / (Decimal)pageSize) : 0L;
    }

    public long PageIndex { get; }

    public long PageSize { get; }

    public long TotalPagesCount { get; }

    public long TotalItemsCount { get; }

    public IReadOnlyCollection<T> Items { get; }

}

public static class PagedResultExtensions
{
    public static PagedResult<T> ToPageResult<T>(this IQueryable<T> query, int pageIndex, int pageSize)
        => new PagedResult<T>(query, pageIndex, pageSize, query.Count());
}

