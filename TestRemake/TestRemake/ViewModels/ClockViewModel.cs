using System;
using Prism.Navigation;
using TestRemake.Models;
using TestRemake.Services.ClockDrawerService;
using TestRemake.Services.TimeGetterService;


namespace TestRemake.ViewModels
{
    public class ClockViewModel : ViewModelBase
    {
        public readonly IClockDrawerService ClockDrawerService;
        readonly ITimeGetterService timeGetterService;
        ClockProfile currentProfile = new ClockProfile()
        {
            Name = "Mock",
            FaceColor = "Blue",
            HandsColor = "White",
            Timezone = "America/Managua"
        };

        public ClockViewModel(INavigationService navigationService,
            IClockDrawerService clockDrawerService,
            ITimeGetterService timeGetterService)
            :base(navigationService)
        {
            this.ClockDrawerService = clockDrawerService;
            this.timeGetterService = timeGetterService;
        }

        public ClockProfile CurrentProfile
        {
            get => currentProfile;
            set { SetProperty(ref currentProfile, value); }
        }

        public DateTime GetTime()
        {
            return timeGetterService.GetTimeByTimezone(currentProfile.Timezone);
        }
    }
}
