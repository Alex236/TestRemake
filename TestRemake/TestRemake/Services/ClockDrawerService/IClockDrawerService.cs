using System;
using SkiaSharp;


namespace TestRemake.Services.ClockDrawerService
{
    public interface IClockDrawerService
    {
        void DrawClock(SKCanvas canvas, SKColor handsColor,
            SKColor faceColor, DateTime time, int height, int width);
    }
}
