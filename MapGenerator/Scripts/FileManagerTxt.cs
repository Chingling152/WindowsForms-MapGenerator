using MapGenerator.Scripts.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MapGenerator.Scripts
{
    public class FileManagerTxt : IFileManager
    {
        private readonly string path;

        public FileManagerTxt(string path) {
            this.path = path;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="map"></param>
        public void ExportMap(Tile[,] map)
        {
            int X = map.GetLength(0);
            int Y = map.Length / X ;

            StreamWriter writer = new StreamWriter(path);

            for (int x = 0 ; x < X; x++) {
                string line = "";
                for (int y = 0 ; y < Y; y++)
                {
                    line += map[x,y].Value;
                }
                writer.WriteLine(line);
            }
            writer.Close();

        }

        /// <summary>
        /// Convert the char values in the .txt file in an matrix of Tiles
        /// </summary>
        /// <returns>The new Map</returns>
        public Tile[,] ImportMap()
        {
            int sizeX ,sizeY;
            Tile[,] Map;

            try {
                string[] values = File.ReadAllLines(path);
                sizeX = values[0].Length;
                sizeY = values.Length;
                System.Windows.Forms.MessageBox.Show($"{sizeX},{sizeY}");

                Map = new Tile[sizeX,sizeY];

                for (int x = 0; x < sizeX; x++)
                {
                    for (int y = 0; y < sizeY; y++)
                    {
                        int value = int.Parse(values[y][x].ToString());
                        Map[x,y] = new Tile(x,y,value);
                    }
                }
            }catch(Exception exc) {
                Map = new Tile[1,1]{
                    { new Tile(0,0,1)}
                };
                System.Windows.Forms.MessageBox.Show(exc.ToString());
                System.Windows.Forms.MessageBox.Show("There is no map to be loaded");
            }

            return Map;
        }

    }
}
