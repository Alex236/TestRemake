using Prism;
using Prism.Ioc;
using TestRemake.Services.ClockDrawerService;
using TestRemake.Services.TimeGetterService;
using TestRemake.ViewModels;
using TestRemake.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TestRemake
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/ClockPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<ClockPage, ClockViewModel>();

            containerRegistry.Register<IClockDrawerService, ClockDrawerService>();
            containerRegistry.Register<ITimeGetterService, TimeGetterService>();
        }
    }
}
