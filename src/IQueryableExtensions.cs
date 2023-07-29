namespace Microsoft.EntityFrameworkCore;

public static class IQueryableExtensions
{
    public static IQueryable<T> Page<T>(this IQueryable<T> query, int pageIndex, int pageSize)
        => query.Skip((pageIndex - 1) * pageSize).Take(pageSize);

    public static IQueryable<T> FirstPage<T>(this IQueryable<T> query, int pageSize)
        => query.Take(pageSize);

    public static IQueryable<T> LastPage<T>(this IQueryable<T> query, int pageSize)
        => query.TakeLast(pageSize);

    public static int CountOfPages<T>(this IQueryable<T> query, int pageSize)
    { 
        var total = query.Count();
        return (total / pageSize) + ((total % pageSize) > 0 ? 1 : 0);
    }
}