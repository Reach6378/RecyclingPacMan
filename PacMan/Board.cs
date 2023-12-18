using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacMan
{
    public class Board // represents the maze
    {
        private int[,] mazeGrid; // 2d array representing the maze 
        // 0= empty space. 1=bottle. 2=PowerUp. 3=PacMan. 4-7= ghosts
        //8=Vertical wall. 9= Horizontal wall. 10= corner left down. 11= corner left up. 12= corner right down. 13= corner right up
        // 14= half circle left 15= half circle right
        public Board(int rows, int columns)
        {
            InitializeMaze(rows, columns);
        }

        private void InitializeMaze(int rows, int columns) // the first time the maze is generated
        {
            mazeGrid = new int[rows, columns]; // creates array with the ammount of rows and columns as values


            /*for (int i = 0; i < rows; i++) to add later!
            {
                for (int j = 0; j < columns; j++)
                {
                    
                }
            } */
        }
        private void PlaceBottle(int x, int y)
        {
            // Place a water bottle
            mazeGrid[x, y] = 1;
        }

        private void PlacePowerUp(int x, int y)
        {
            // Place a power up ("Recycling logo")
            mazeGrid[x, y] = 2;
        }

        private void PlacePacMan(int x, int y)
        {
            // Place Pac-Man ("Dedi")
            mazeGrid[x, y] = 3;
        }

        private void PlaceGhostRed(int x, int y)
        {
            //places ghost ("company")
            mazeGrid[x, y] = 4;
        }
        private void PlaceGhostPink(int x, int y)
        {
            //places ghost ("company")
            mazeGrid[x, y] = 5;
        }
        private void PlaceGhostBlue(int x, int y)
        {
            //places ghost ("company")
            mazeGrid[x, y] = 6;
        }
        private void PlaceGhostOrannge(int x, int y)
        {
            //places ghost ("company")
            mazeGrid[x, y] = 7;
        }
    }
}
