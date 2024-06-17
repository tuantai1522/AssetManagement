using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.Application.Common;

public class BaseResult<T>
{
    public bool IsSuccess { get; set; } = true;

    public T? Result { get; set; }

    public ProblemDetails? Error { get; set; }
}
