using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MapGenerator.Scripts
{
    public class Tile : Button
    {
        /// <summary>
        /// Numeros representado cor e tipo de cada tile.
        /// </summary>
        public static readonly Dictionary<int, Color> colors = new Dictionary<int, Color>(){
            {0,Color.Black},//Hole
            {1,Color.Green},//Grass
            {2,Color.Khaki},//Sand
            {3,Color.DarkGreen},//Grass
            {4,Color.SaddleBrown},//Dirt
            {5,Color.LightGray},//Gravel
            {6,Color.DimGray},//Concrete
            {7,Color.Silver}//Road
        };
        private int value;

        /// <summary>
        /// Valor da tile , que é enviado para o arquivo txt
        /// </summary>
        public int Value {
            get {
                return value;
            }
            private set {
                if(value > colors.Count - 1) value = 0;
                
                this.value = value;
            }
        }
        /// <summary>
        /// Construtor vazio e unico do Tile.cs
        /// </summary>
        /// <param name="x">Numero da Coluna</param>
        /// <param name="y">Numero da Linha</param>
        /// <param name="value">Tipo padrão a ser instaciado</param>
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

            BackColor = colors[Value];
        }
        /// <summary>
        /// Evento de clique . Aumenta a variavel Value
        /// </summary>
        private void ClickTileEvent(object sender, EventArgs e)
        {
            Value ++;
            this.BackColor = colors[value];
        }
    }
}
