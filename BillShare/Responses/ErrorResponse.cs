﻿namespace BillShare.Responses;

public class ErrorResponse
{
    public int StatusCode { get; init; }
    public string Message { get; init; } = default!;
}