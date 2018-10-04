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
        int X , Y;

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
            Color col = BackColor;
            switch (col)
            {
                default:
                    break;
            }
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            int.TryParse(EixoX.Text, out X);
            int.TryParse(EixoX.Text, out Y);

            if(X <11 && Y < 11) {
            
                btn = new Button[X,Y];

                for (int x = 0; x < X; x++) {
                    for (int y = 0; y < Y; y++){
                        btn[x,y] = new Button
                        {
                            Name = $"btn_{x}_{y}",
                            Text = "",
                            Width = 23, 
                            Height = 23,
                            Margin = new Padding(0,0,0,0),
                            Location = new Point(48 + (x * 30),156 + (y * 30))
                        };
                        btn[x,y].Click += new EventHandler(ClickTileEvent);
                        Controls.Add(btn[x,y]);
                        btn[x, y].BringToFront();
                    }
                }
            }
            else {
                MessageBox.Show("Insira um valor menor ou igual à 10");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(btn != null) {
                for (int x = 0; x < X; x++){
                    for (int y = 0; y < Y; y++){
                        Controls.Remove(btn[x, y]);                  
                    }
                }
                btn =null;
                X = 0;
                Y = 0;
            }
            else
            {
                MessageBox.Show("Não há mapa para ser removido");
            }
        }
    }
}
