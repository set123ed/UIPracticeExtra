using System;
using ExtraPoints.ViewModel;
using ExtraPoints.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExtraPoints
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer = null) : base(platformInitializer) { }
        public Config Contants = new Config();

        protected override async void OnInitialized()
        {
            InitializeComponent();

           await NavigationService.NavigateAsync($"{Config.NavigationPage}/{Config.HomePage}");
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>(Config.NavigationPage);
            containerRegistry.RegisterForNavigation<HomePage,HomeViewModel>(Config.HomePage);           
        }
       
    }
}
