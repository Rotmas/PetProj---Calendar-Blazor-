using System;

namespace Application.Client.Classes;

public class MovedEvent
{
    public DateOnly PreviousDay { get; init; }
    public DateOnly NewDay { get; init; }
    public Event Event { get; init; }
}
