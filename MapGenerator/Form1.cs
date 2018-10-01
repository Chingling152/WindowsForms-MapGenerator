using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapGenerator.Scripts;

namespace MapGenerator
{
    public partial class Form1 : Form
    {
        Button[,] btn;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Aumenta o valor e muda a cor do botão
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickTileEvent(object sender, EventArgs e){
            
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            int.TryParse(EixoX.Text, out int X);
            int.TryParse(EixoX.Text, out int Y);

            btn = new Button[X,Y];

            for (int x = 0; x < X-1; x++) {
                for (int y = 0; x < Y-1; y++){
                    btn[x,y] = new Button
                    {
                        Name = $"btn_{x}_{y}",
                        Text = "",
                        Width = 23, 
                        Height = 23,
                        Top = 6 + (y + 23),//ajustar valores
                        Left = 15 + (x + 23)
                    };
                    MessageBox.Show(x.ToString() + " " + y.ToString());
                    /*btn[x,y].Click += new EventHandler(ClickTileEvent);*/
                }
            }
        }
    }
}
