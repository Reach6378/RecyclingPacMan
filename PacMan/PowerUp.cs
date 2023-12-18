using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Google.Android.Material.BottomSheet.BottomSheetBehavior;

namespace PacMan
{
    public class PowerUp: AnObject
    {
        private bool isEaten;
        public PowerUp(ImageView picture, double xPosition, double yPosition, double width, double height)
         : base(picture, xPosition, yPosition, width, height)
        {
            //picture.SetImageResource(Resource.Drawable.PowerUp); add an image for PowerUp
            isEaten = false;
        }
      
        public bool GetEaten()
        {
            return isEaten;
        }
    }
}