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

namespace PacMan
{
    public class PacMan : AnObject
    {
        private bool canEatGhosts; // add function in collision manager class
        private int lives;
        private double Speed { get; set; }// המהירות של הרוח
        public PacMan(int lives,double speed, ImageView picture, double xPosition, double yPosition, double width, double height)
            : base(picture, xPosition, yPosition, width, height) // פעולה בונה של הרוחות היורשת מהמחלקה anObject
        {
            Speed = speed;
            picture.SetImageResource(Resource.Drawable.Dedi); 
            canEatGhosts = false;
            this.lives = 5;
        }
        public void PowerUpEaten(PowerUp recycling)
        {
            if (IsCollision(this, recycling))
            {
                canEatGhosts = true;
                recycling.GetEaten();
            }
        }

    }
}