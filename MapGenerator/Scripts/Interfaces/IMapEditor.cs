using System.Collections.Generic;

namespace MapGenerator.Scripts.Interfaces
{
    public interface IMapEditor
    {
        /// <summary>
        /// Generates a empty map basedon the int value  
        /// Exemple  :
        /// 1 - A full map of grass
        /// 2 - A full map of sand
        /// </summary>
        void GenerateMap(int defaultValue);

        /// <summary>
        /// Conver the matrix of Tiles in a List of Tiles  
        /// Used to get the tiles outside the IMapEditor classes
        /// </summary>
        /// <returns>Return a matrix containing all the tiles</returns>
        Tile[,] GetMap();
    }
}
