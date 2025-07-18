namespace MoneyFlow.Core.Responses;

using System.Text.Json.Serialization;

public class Response<TData>
{
    private int _code = Configuration.DefaultStatusCode;

    [JsonConstructor]
    public Response() {
        _code = Configuration.DefaultStatusCode;
    }

    public Response(
        TData data, 
        int code = Configuration.DefaultStatusCode, 
        string? message = null)
    {
        Data = data;
        _code = code;
        Message = message;
    }

    public string? Message { get; set; }

    public TData? Data { get; set; }

    [JsonIgnore]
     public bool IsSuccess => _code >= 200 && _code <= 299;

}