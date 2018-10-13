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

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            Clear();

            int.TryParse(EixoX.Text, out X);
            int.TryParse(EixoX.Text, out Y);

            if(X < 11 && Y < 11) {
            
                btn = new Tile[X,Y];

                for (int x = 0; x < X; x++) {
                    for (int y = 0; y < Y; y++){
                        btn[x,y] = new Tile(x,y);
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
                Clear();
            }
            else
            {
                MessageBox.Show("Não há mapa para ser removido");
            }
        }

        private void Clear() {
            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {
                    Controls.Remove(btn[x, y]);
                }
            }
            btn = null;
            X = 0;
            Y = 0;
        }
    }
}
