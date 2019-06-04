using System;


namespace TestRemake.Services.TimeGetterService
{
    public class TimeGetterService : ITimeGetterService
    {
        public DateTime GetTimeByTimezone(string timezone)
        {
            TimeZoneInfo checkedTimezone = TimeZoneInfo.FindSystemTimeZoneById(timezone);
            return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, checkedTimezone);
        }
    }
}
