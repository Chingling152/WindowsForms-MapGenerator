﻿using MapGenerator.Scripts.Interfaces;
using System.Collections.Generic;
using System.Drawing;

namespace MapGenerator.Scripts
{
    public class MapController : IMapEditor
    {
        private Tile[,] Tiles;
        private int X , Y;

        public static Dictionary<int,Color> TileTypes = new Dictionary<int, Color>(){
            {0,Color.Black},//Hole
            {1,Color.Green},//Grass
            {2,Color.Khaki},//Sand
            {3,Color.DarkGreen},//Grass
            {4,Color.SaddleBrown},//Dirt
            {5,Color.LightGray},//Gravel
            {6,Color.DimGray},//Concrete
            {7,Color.Silver}//Road
        };

        /// <summary>
        /// Default constructor  
        /// Used when the user creates an empty map
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        public MapController(int X,int Y,int value) {
            this.X = X;
            this.Y = Y;

            GenerateMap(value);
        }

        public MapController(string[] map) {
            GenerateMap(map);
        }

        public void GenerateMap(int defaultValue)
        {
            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {
                    Tiles[x, y] = new Tile(x, y, defaultValue);
                }
            }
        }

        public void GenerateMap(string[] map)
        {
            throw new System.NotImplementedException();
        }

        public List<Tile> GetMap()
        {
            throw new System.NotImplementedException();
        }
    }
}