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
            int.TryParse(EixoY.Text, out Y);
            GerarMapa();
        }
        /// <summary>
        /// Verifica o tamanho do mapa e gera um novo mapa em uma matriz de X e Y
        /// </summary>
        private void GerarMapa()
        {          
            X = X <= 0 ? 1 : X; 
            Y = Y <= 0 ? 1 : Y;

            EixoX.Text = $"{X}";
            EixoY.Text = $"{Y}";

            if (X < 11 && Y < 11)
            {
                int count = 0;
                btn = new Tile[X, Y];

                for (int x = 0; x < X; x++)
                {
                    for (int y = 0; y < Y; y++)
                    {
                        int value = cbo_bioma.SelectedIndex;
                        btn[x, y] = new Tile(x, y, value);
                        Controls.Add(btn[x, y]);
                        btn[x, y].BringToFront();
                        btn[x, y].TabIndex = count++;
                    }
                }
            }
            else
            {
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

        /// <summary>
        /// Exporta o mapa para um TXT com os valores numericos representando cada um deles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_exp_Click(object sender, EventArgs e)
        {
            if(X == 0 || Y == 0) {
                string[] lines = new string[Y];

                for (int x = 0; x < X; x++)
                {
                    for (int y = 0; y < Y; y++)
                    {
                        lines[y] += btn[x,y].Value.ToString();//adiciona o valor de cada tile para a linha (y)
                    }
               
                }

                StreamWriter arquivo = new StreamWriter($@"{Environment.CurrentDirectory}\Map.txt",false);
                //le cada linha do vetor de strings
                foreach (string item in lines) {
                    arquivo.WriteLine((item+ "-").ToCharArray(),0,X+1);//converte para um vetor de char
                }
                MessageBox.Show("Arquivo Exportado!");
                arquivo.Close();//fecha e salva o arquivo
            }
            else {
                MessageBox.Show("Não há mapa para ser exportado");
            }
        }
        /// <summary>
        /// Importa mapa de um arquivo .txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_imp_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader($@"{Environment.CurrentDirectory}\Map.txt");
            List<string> tempLinhas = new List<string>();

            //Pegando dados do arquivo txt
            while (!reader.EndOfStream) {
                string tempLinha = reader.ReadLine();//converte para uma lista
                tempLinha = tempLinha.Remove(tempLinha.Length-1);// remove o ultimo char da string
                tempLinhas.Add(tempLinha);//adiciona o item na lista
            }
            reader.Close();

            Clear();//limpar campos

            //convertento a string para array
            string[] linhas = tempLinhas.ToArray();          

            X = linhas[0].Length;//seta o eixo X igual
            Y = linhas.Length;
            btn = new Tile[X, Y];

            X = X <= 0 ? 1 : X;
            Y = Y <= 0 ? 1 : Y;

            EixoX.Text = $"{X}";
            EixoY.Text = $"{Y}";

            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {
                    int value = int.Parse(linhas[y][x].ToString());
                    btn[x, y] = new Tile(x, y, value);
                    Controls.Add(btn[x, y]);
                    btn[x, y].BringToFront();
                }
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
