using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PacMan
{
    public class ScoreManager
    {
        private int score;
        private Stopwatch time; // will keep track of time
        private const int powerPelletScore = 50; // score each Recycling pellet gives (not changing so its const)
        private const int bottleScore = 10; // score each bottle gives (not changing so its const)
        public ScoreManager(int score, Stopwatch time)
        {
            this.score = score;
            this.time = time;
            time.Start(); // starts counting when game starts meaning when ScoreManager is created
        }
        public void UpdateScore(PacMan Pac, Bottle botlle, PowerUp pU) // will update the score
        {
            
        }public void StopTime() // stops counting time when player loses

        {

        }
    }
}