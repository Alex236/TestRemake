using System;
namespace TestRemake.Services.TimeGetterService
{
    public interface ITimeGetterService
    {
        DateTime GetTimeByTimezone(string timezone);
    }
}
