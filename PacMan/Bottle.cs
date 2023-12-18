using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacMan
{
    public class Bottle: AnObject
    {
        private bool isEaten;

        public Bottle(ImageView picture, double xPosition, double yPosition, double width, double height)
         : base(picture, xPosition, yPosition, width, height)
        {
            {
                picture.SetImageResource(Resource.Drawable.Bottle1); //sets picture to the bottle
                isEaten = false;
            }
        }
        public bool GetEaten()
        {
            return isEaten;
        }
    }
}