using System;
using UIPractice.Models;
using Xamarin.Forms;

namespace UIPractice.ViewModel
{
    public class DetailViewModel
    {
        public Items Wedding { get; set; } = new Items();
        public ImageSource Back => "back1";
        public ImageSource Portada { get; set; } = "foto1.jpg";
        public ImageSource Image2 { get; set; } = "share";
        public ImageSource Image3 { get; set; } = "calendar";
        public ImageSource Image4 { get; set; } = "love";

        public string Title { get; } = "Article Title" +
            "Small batch banjo Cosby sweater, pug polaroid Neutra asymmetrical" +
            " chambray. Bespoke Etsy wolf, Caries PBR Odd Future ethical keytar " +
            "fashion axe. Polaroid artisan wayfarers fap. Plaid salvia gluten-free," +
            " Intelligentsia irony tote bag raw denim selfies organic McSweeney's " +
            "jean shorts ethical. ";
        
        public DetailViewModel()
        {
            Wedding.Image = "Wedding.jpg";
        }
    }
}
