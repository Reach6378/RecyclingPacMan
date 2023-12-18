using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.IO;
using static Android.Graphics.ImageDecoder;

namespace PacMan
{
    [Activity(Label = "PacManGame", MainLauncher = true)]

    public class MainActivity : Activity
    {
        const int TileSize = 16;  // size of tiles. 
        const int MazeWidth = 480;  // Width of the maze in pixels
        const int MazeHeight = 640;  // Height of the maze in pixels
        TextView explanation;
        

        
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            explanation = FindViewById<TextView>(Resource.Id.Explanation);
            


        }
        /*private void GameLoop() to add later!
        {
            while (gameIsRunning)
            {
                // Update game logic
                UpdateGame();

                // Control frame rate (optional)
                Thread.Sleep(16); // Aim for approximately 60 FPS
            }
        } */



    }
}