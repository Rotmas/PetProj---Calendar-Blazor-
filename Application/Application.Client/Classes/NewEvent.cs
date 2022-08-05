using System;

namespace Application.Client.Classes;

public class NewEvent
{
    public DateOnly Day { get; init; }
    public Event Event { get; init; }
}