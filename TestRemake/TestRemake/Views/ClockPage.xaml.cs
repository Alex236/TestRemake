using Xamarin.Forms;
using TestRemake.ViewModels;
using SkiaSharp.Views.Forms;
using SkiaSharp;
using System.Collections.Generic;
using System;

namespace TestRemake.Views
{
    public partial class ClockPage : ContentPage
    {
        public ClockPage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromMilliseconds(500), () =>
            {
                clockCanvas.InvalidateSurface();
                return true;
            });
        }

        private void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            if (!(BindingContext is ClockViewModel clockViewModel)) return;
            if (SKColor.TryParse(ColorsAndHex[clockViewModel.CurrentProfile.HandsColor], out SKColor handsColor)
                && SKColor.TryParse(ColorsAndHex[clockViewModel.CurrentProfile.FaceColor], out SKColor faceColor))
            {
                SKCanvas canvas = e.Surface.Canvas;
                clockViewModel.ClockDrawerService.DrawClock(canvas, handsColor,
                    faceColor, clockViewModel.GetTime(), e.Info.Height, e.Info.Width);
            }
        }

        void HandlePicker_SelectProfile(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void HandlePicker_DeleteProfile(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        Dictionary<string, string> ColorsAndHex = new Dictionary<string, string>
        {
            {"Yellow", "#f1f442"},
            {"Blue", "#5d9afc"},
            {"White", "#ffffff"},
            {"Green", "#6dff6d"}
        };
    }
}
