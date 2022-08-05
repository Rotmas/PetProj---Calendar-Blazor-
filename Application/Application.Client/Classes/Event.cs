using System;

namespace Application.Client.Classes;
public record Event
{
    public string Message { get; init; }
    public TimeOnly Time { get; init; }
}