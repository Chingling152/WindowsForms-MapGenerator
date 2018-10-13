using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MapGenerator.Scripts
{
    public class Tile : Button
    {
        public readonly Dictionary<int,Color> colors = new Dictionary<int, Color>(){
            {0,Color.Black},//Hole
            {1,Color.Green},//Grass
            {2,Color.Khaki},//Sand
            {3,Color.DarkGreen},//Grass
            {4,Color.SandyBrown},//Dirt
            {5,Color.LightGray},//Gravel
            {6,Color.DimGray},//Concrete
            {7,Color.Silver}//Road
        };
        private int value = 0;

        public int Value {
            get {
                return value;
            }
            set {
                if(value > colors.Count - 1) value = 0;
                
                this.value = value;
            }
        }
        public Tile(int x, int y)
        {
            Name = $"btn_{x}_{y}";
            Text = "";
            Width = 23;
            Height = 23;
            Margin = new Padding(0, 0, 0, 0);
            Location = new Point(48 + (x * 30), 156 + (y * 30));

            Click += new System.EventHandler(ClickTileEvent);

            BackColor = colors[Value];
        }

        private void ClickTileEvent(object sender, EventArgs e)
        {
            Value ++;
            this.BackColor = colors[value];
        }
    }
}
