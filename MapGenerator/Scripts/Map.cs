using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapGenerator.Scripts
{
    public static class Map
    {
        private static int[,] map;

        public static int GetMap(int x,int y) {
            return map[x,y];
        }

        public static void SetMap(int[,] i) {
            map = i;
        }
        //https://social.msdn.microsoft.com/Forums/vstudio/en-US/f30735a6-3bf6-49ba-9034-f4087f4bd53f/create-buttons-dynamically? forum = csharpgeneral
    
    }
}
