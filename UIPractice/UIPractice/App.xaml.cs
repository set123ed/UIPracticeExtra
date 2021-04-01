using System;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using UIPractice.ViewModel;
using UIPractice.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UIPractice
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer = null) : base(platformInitializer) { }
        public Config constant = new Config();

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync($"{Config.HomePage}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>(Config.HomePage);
            containerRegistry.RegisterForNavigation<NavigationPage>(Config.NavigationPage);


        }

    }
}
