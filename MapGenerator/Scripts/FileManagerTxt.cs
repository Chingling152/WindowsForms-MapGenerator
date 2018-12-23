using MapGenerator.Scripts.Interfaces;
using System.IO;

namespace MapGenerator.Scripts
{
    public class FileManagerTxt : IFileManager
    {
        private readonly string path;

        public FileManagerTxt(string path) {
            this.path = path;
        }

        /// <summary>
        /// Creates a .txt file just with the values of each tile
        /// </summary>
        /// <param name="map">The map that will be saved</param>
        public void ExportMap(Tile[,] map)
        {
            int X = map.GetLength(0);
            int Y = map.Length / X ;

            StreamWriter writer = new StreamWriter(path);

            for (int y = 0; y < Y; y++)
            {
               string line = "";
                for (int x = 0; x < X; x++)
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

                string[] values = File.ReadAllLines(path);
                sizeX = values[0].Length;
                sizeY = values.Length;

                Map = new Tile[sizeX,sizeY];

                for (int x = 0; x < sizeX; x++)
                {
                    for (int y = 0; y < sizeY; y++)
                    {
                        int value = int.Parse(values[y][x].ToString());
                        Map[x,y] = new Tile(x,y,value);
                    }
                }

            return Map;
        }

    }
}
