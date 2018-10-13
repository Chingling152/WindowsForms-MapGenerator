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
using System.IO;

namespace MapGenerator
{
    public partial class Form1 : Form
    {
        Tile[,] btn;
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
                int count = 0;
                btn = new Tile[X,Y];
                
                for (int x = 0; x < X; x++) {
                    for (int y = 0; y < Y; y++){
                        sbyte value = CboValue();
                        btn[x,y] = new Tile(x,y,value);
                        Controls.Add(btn[x,y]);
                        btn[x, y].BringToFront();
                        btn[x,y].TabIndex = count++;
                    }
                }
                btn_exp.Enabled = true;
                btn_imp.Enabled = true;
            }
            else {
                MessageBox.Show("Insira um valor menor ou igual à 10");
            }
        }

        private sbyte CboValue(){
            sbyte result = 0;
            switch (cbo_bioma.SelectedIndex)
            {
                case 1:
                    result = 1;
                    break;
                case 2:
                    result = 2;
                    break;
                case 3:
                    result = 3;
                    break;
                case 4:
                    result = 4;
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
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

        private void Btn_exp_Click(object sender, EventArgs e)
        {
            string[] lines = new string[Y];

            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {
                    lines[y] += btn[x,y].Value.ToString();//adciona o valor de cada tile para a linha (y)
                }
                
            }

            StreamWriter arquivo = new StreamWriter("Map.txt");
            //le cada linha do vetor de strings
            foreach (string item in lines) {
                arquivo.WriteLine(item.ToCharArray(),0,X);//converte para um vetor de char
            }
            MessageBox.Show("Arquivo Exportado!");
            arquivo.Close();//fecha e salva o arquivo
        }

        private void Btn_imp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção indisponivel");
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
            btn_exp.Enabled = false;
            btn_imp.Enabled = false;
            X = 0;
            Y = 0;
        }
    }
}
