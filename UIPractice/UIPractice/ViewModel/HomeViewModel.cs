using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Prism.Navigation;
using UIPractice.Models;
using Xamarin.Forms;

namespace UIPractice.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<Music> MusicList { get; }
        public ICommand Navigate { get; }
        public Items Breathe { get; set; } = new Items();
        public Items Sleep { get; set; } = new Items();
        public Items Anxiety { get; set; } = new Items();
        public Items Stress { get; set; } = new Items();
        public Items Glass { get; set; } = new Items();
        public Items Wedding { get; set; } = new Items();
        public Items Clock { get; set; } = new Items();

        public string QuickHelp => "Quick Help";
        public string DailyMeditation => "Daily Meditation";
        public string Breathe_ => "Breathe";
        public string Sleep_ => "Sleep";
        public string Anxiety_ => "Anxiety";
        public string Stress_ => "Stress";
        public string RestRelax => "Rest & Relax";
        public string Min => "30 Min";
        public string NewMusic => "New Music";
        public string ViewAll => "View All";

        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
            Navigate = new Command(NavigateTo);

            Breathe.Title = "Breathe";
            Sleep.Title = "Sleep";
            Anxiety.Title = "Anxiety";
            Stress.Title = "Stress";

            Breathe.Image = "Air";
            Sleep.Image = "Moon";
            Anxiety.Image = "Sick";
            Stress.Image = "Stress";
            Glass.Image = "Glass";
            Wedding.Image = "Wedding.jpg";
            Clock.Image = "Clock";

            MusicList = new ObservableCollection<Music>
            {
                new Music("Wedding","Foto1.jpg","5 Min","BlackClock"),
                new Music("Engagement","Foto2.jpg","8 Min","BlackClock"),
                new Music("About Us","Foto3.jpg","10 Min","BlackClock"),
                new Music("Destination","Foto4.jpg","14 Min","BlackClock"),
                new Music("Booking","Foto5.jpg","18 Min","BlackClock")
            };

        }

        private async void NavigateTo()
        {

        }
    }
    }
