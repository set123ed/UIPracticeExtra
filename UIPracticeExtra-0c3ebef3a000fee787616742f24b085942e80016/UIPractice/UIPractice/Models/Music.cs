using System;
using Xamarin.Forms;

namespace UIPractice.Models
{
    public class Music
    {
        

        public Music(string name, string image,string minutes, string image2)
        {
            Name = name;
            Image = image;
            Minutes = minutes;
            Image2 = image2;

        }

        public string Name { get; set; }
        public ImageSource Image { get; set; }
        public string Minutes { get; set; }
        public ImageSource Image2 { get; set; }


    }
}
