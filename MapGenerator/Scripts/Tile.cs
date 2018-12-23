using System;
using System.Drawing;
using System.Windows.Forms;

namespace MapGenerator.Scripts
{
    public class Tile : Button
    {
        /// <summary>
        /// The value of the current Tile
        /// </summary>
        private int value;

        /// <summary>
        /// Value that will be sent to the .txt file
        /// </summary>
        public int Value {
            get {
                return value;
            }
            private set {
                if(value > MapController.TileTypes.Count - 1)
                    value = 0;
                
                this.value = value;
            }
        }
        /// <summary>
        /// Constructor of the Tile  
        /// Creates a Tile with name based on X and Y and color based on the value number  
        /// Size : 23x23  
        /// Position : Based on the X and Y values
        /// </summary>
        /// <param name="x">Defines the name of the tile , the position on matrix</param>
        /// <param name="y">Defines the name of the tile , the position on matrix</param>
        /// <param name="value">Defines the color of the tile</param>
        public Tile(int x, int y, int value)
        {
            Name = $"btn_{x}_{y}";
            Text = "";
            Width = 23;
            Height = 23;
            Margin = new Padding(0, 0, 0, 0);
            Location = new Point(48 + (x * 30), 250 + (y * 30));

            Click += new EventHandler(ClickTileEvent);

            this.value = value;

            BackColor = MapController.TileTypes[Value];
        }
        /// <summary>
        /// Click event increases the value variable (making the tile change its color)
        /// </summary>
        private void ClickTileEvent(object sender, EventArgs e)
        {
            Value ++;
            this.BackColor = MapController.TileTypes[value];
        }
    }
}
