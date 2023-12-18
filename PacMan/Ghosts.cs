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
    public class Ghosts: AnObject
    {
        private double Speed { get; set; }// המהירות של הרוח אשר יכולה גם להשתנות
        private int ghostType; // 1= Red (Coca cola) 2=pink(pepsiCo) 3=Blue (Nestle) 4= orange (Uneliver)
        //Since every "company" (Ghost) has a different algorithem to catch the PacMan, we need to determine what ghost is created
        public Ghosts(int numGhost,double speed, ImageView picture, double xPosition, double yPosition, double width, double height)
            : base(picture, xPosition, yPosition, width, height) // פעולה בונה של הרוחות היורשת מהמחלקה anObject
        {
            Speed = speed;
            ghostType = numGhost;
            
        }
        
        public void ModeChase()
        {

        }
        public void ModeScatter() //When Pacman eats
        {

        }
        public void ModeScared()
        {

        }
        public void PinkGhost()
        {

        }
        public void BlueGhost()
        {

        }
        public void OrangeGhost()
        {

        }
        public void RedGhost()
        {

        }
    }
}
    
