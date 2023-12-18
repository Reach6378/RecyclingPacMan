using Android.App;
using Android.Content;
using Android.Media;
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
    public class MusicManager
    {
        private SoundEffect gameMusic { get; set; } // the music that is playing in loops
        private SoundEffect movmentMusic; // sound effect when pacman moves that is playing in loops as long as pacman is moving
        private SoundEffect eatenMusic; // sound effect when pacman eats a power pellet (recycling logo)
        public MusicManager(SoundEffect gameMusic, SoundEffect movmentMusic, SoundEffect eatenMusic)
        {
            this.gameMusic = gameMusic;
            this.movmentMusic = movmentMusic;
            this.eatenMusic = eatenMusic;

        }
        public void PlayEaten()
        {

        }
        public void PlayGameMusic()
        {

        }
        public void PlayMovmentMusic()
        {

        }
    }
}