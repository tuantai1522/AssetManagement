using System.Net;
using AssetManagement.Domain.Exceptions.Base;

namespace AssetManagement.Domain.Exceptions;
public class UnauthorizedException : BaseException
{
    private const int _statusCode = (int)HttpStatusCode.NotFound;
    private const string? _title = "Unauthorized.";

    public UnauthorizedException()
    {
        StatusCode = _statusCode;
        Title = _title;
    }

    public UnauthorizedException(string? message) : base(message)
    {
        StatusCode = _statusCode;
        Title = _title;
    }
}