using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapGenerator.Scripts.Interfaces
{
    public interface IFileManager
    {
        /// <summary>
        /// Export the current tilemap as a .txt of strings 
        /// </summary>
        void ExportFiles();
        /// <summary>
        /// Convert the strings on the selected .txt file in an array of strings
        /// </summary>
        /// <returns>an array of string representing the map</returns>
        string[] ImportFiles();
    }
}
