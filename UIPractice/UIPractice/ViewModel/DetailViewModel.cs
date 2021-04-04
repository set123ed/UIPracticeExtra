using System;
using Prism.Commands;
using UIPractice.Models;
using Xamarin.Forms;
using Prism.Navigation;
using System.ComponentModel;
using Prism.Services;
using Prism.Common;

namespace UIPractice.ViewModel
{
    public class DetailViewModel :BaseViewModel, IInitialize
    {
        public ImageSource Back => "back1";
        public Command BackCommand { get; }
        private Music _music;


        public Music Music { get;set; }

        public void Initialize(INavigationParameters parameters)
        {
            if(parameters.TryGetValue("Music",out Music music))
            {
                Music = music;
            }
        }

        public ImageSource Image2 => "share";
        public ImageSource Image3 => "calendar";
        public ImageSource Image4 => "love";


        public string Text { get; } =  
            "Small batch banjo Cosby sweater, pug polaroid Neutra asymmetrical" +
            " chambray. Bespoke Etsy wolf, Caries PBR Odd Future ethical keytar " +
            "fashion axe. Polaroid artisan wayfarers fap. Plaid salvia gluten-free," +
            " Intelligentsia irony tote bag raw denim selfies organic McSweeney's " +
            "jean shorts ethical. ";

        public DetailViewModel(INavigationService navigationService) : base(navigationService)
        {
            BackCommand = new Command(async () =>
                await NavigationService.GoBackAsync(null)
        ); 
        }
    }
}
