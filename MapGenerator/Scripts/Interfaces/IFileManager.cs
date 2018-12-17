using System.Collections.Generic;

namespace MapGenerator.Scripts.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFileManager
    {
        /// <summary>
        /// Export the current TileMap
        /// </summary>
        /// <param name="map"></param>
        void ExportMap(Tile[,] map);
        /// <summary>
        /// Import the current TileMap
        /// </summary>
        /// <returns>A Matrix of tiles</returns>
        Tile[,] ImportMap();
    }
}
