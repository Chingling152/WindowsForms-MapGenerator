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
using MapGenerator.Scripts.Interfaces;

namespace MapGenerator
{
    public partial class Form1 : Form
    {
        private IMapEditor MapEditor;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a new map with the 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGerar_Click(object sender, EventArgs e)
        {
            int.TryParse(EixoX.Text,out int x);
            int.TryParse(EixoY.Text, out int y);
            sbyte value = (sbyte)cbo_bioma.SelectedValue;

            x = x <= 0 ? 1 : x;
            y = y <= 0 ? 1 : y;

            EixoX.Text = $"{x}";
            EixoY.Text = $"{y}";

            if (x < 11 && y < 11){
                MapEditor = new MapController(x,y,value);
                CreateTileControls();
            }
            else { 
                MessageBox.Show("Insert a value between 1 and 11");
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

        /// <summary>
        /// Clear Button Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            if(MapEditor != null) {
                ClearMap();
            }
            else
            {
                MessageBox.Show("There is no map to be removed");
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
        /// Import Button Event
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
        /// <summary>
        /// Remove all the tiles in the form and resets the IMapEditor class
        /// </summary>
        private void ClearMap() {
            List<Tile> RemovedTiles = MapEditor.GetMap();

            foreach(Tile item in RemovedTiles) {
                Controls.Remove(item);
            }

            MapEditor = null;
        }
        /// <summary>
        /// Add tiles array as buttons in form
        /// </summary>
        private void CreateTileControls()
        {
            List<Tile> tiles = MapEditor.GetMap();
            int count = 0;
            foreach (Tile item in tiles)
            {
                Controls.Add(item);
                item.BringToFront();
                item.TabIndex = count++;
            }
        }
    }
}
