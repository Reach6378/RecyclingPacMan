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
    public class AnObject
    {
        private ImageView picture; //לכל אובג'קט יש תמונה שונה
        private double xPosition { get; set; } // פעולות גט וסט
        private double yPosition { get; set; } // פעולות גט וסט
        private double width { get; set; } // פעולות גט וסט
        private double height { get; set; } // פעולות גט וסט
        public AnObject(ImageView picture, double xPosition, double yPosition, double width, double height)// פעולה בונה
        {
            this.picture = picture;
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.width = width;
            this.height = height;
        }

        public bool IsCollision(AnObject object1, AnObject object2) // this function checks if 2 objects are colliding
        {

            if (object1.xPosition < object2.xPosition + object2.width &&
                object1.xPosition + object1.width > object2.xPosition)
            {
                
                if (object1.yPosition < object2.yPosition + object2.height &&
                    object1.yPosition + object1.height > object2.yPosition)
                {
                    return true; // there is collision
                }
            }           
            return false; // no collision
        }

    }
}