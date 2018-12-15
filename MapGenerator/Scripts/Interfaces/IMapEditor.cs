using System.Collections.Generic;

namespace MapGenerator.Scripts.Interfaces
{
    public interface IMapEditor
    {
        /// <summary>
        /// Generates a empty map
        /// </summary>
        void GenerateMap(int defaultValue);

        /// <summary>
        /// Generates a map based on a .txt file
        /// </summary>
        /// <param name="map"></param>
        void GenerateMap(string[] map);

        /// <summary>
        /// Conver the matrix of Tiles in a List of Tiles  
        /// Used to get the tiles outside the IMapEditor classes
        /// </summary>
        /// <returns>Return a matrix containing all the tiles</returns>
        List<Tile> GetMap();
    }
}
