using System;
using UIPractice.Models;
namespace UIPractice.ViewModel
{
    public class HomeViewModel
    {
        public Items Breathe { get; set; }  = new Items();
        public Items Sleep { get; set; } = new Items();
        public Items Anxiety { get; set; } = new Items();
        public Items Stress { get; set; } = new Items();
        public Items Glass { get; set; } =  new Items();

        public string QuickHelp => "Quick Help";
        public string DailyMeditation => "Daily Meditation";
        public string Breathe_ => "Breathe";
        public string Sleep_ => "Sleep";
        public string Anxiety_ => "Anxiety";
        public string Stress_ => "Stress";


        public HomeViewModel()
        {
            Breathe.Title = "Breathe";
            Sleep.Title = "Sleep";
            Anxiety.Title = "Anxiety";
            Stress.Title = "Stress";

            Breathe.Image = "Air";
            Sleep.Image = "Moon";
            Anxiety.Image = "Sick";
            Stress.Image = "Stress";
            Glass.Image = "Glass";
        }

    }
}
