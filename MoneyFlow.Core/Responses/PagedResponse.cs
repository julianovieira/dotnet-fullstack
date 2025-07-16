namespace MoneyFlow.Core.Responses

using MoneyFlow.Core.Configuration;
using System.Text.Json.Serialization;

public class PagedResponse<TData> : Responses<TData>
{
    [JsonConstructor]
    public PagedResponse(TData data, int currentPage = 1, int totalCount, int pageSize = Configuration.DefaultPageSize)
        : base(data)
    {
        Data = data;
        CurrentPage = currentPage;
        TotalCount = totalCount;
        PageSize = pageSize;
    }

    public PagedResponse(TData data, int code = Configuration.DefaultStatusCode, string? message = null)
        : base(data, code, message)
    {
    }


    public int CurrentPage { get; set; }
    public int TotalPages => (int).Math.Ceiling(TotalCount /(double) PageSize);
    public int PageSize { get; set; } = Configuration.DefaultPageSize;
    public int TotalCount { get; set; }
}