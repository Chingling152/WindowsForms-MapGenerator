using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MapGenerator.Scripts;
using MapGenerator.Scripts.Interfaces;

namespace MapGenerator
{
    public partial class Form1 : Form
    {
        private IMapEditor MapEditor;
        private IFileManager FileManager;

        public Form1()
        {
            InitializeComponent();
            FileManager = new FileManagerTxt("Map.txt");
        }

        /// <summary>
        /// Creates a new map with the selected value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGerar_Click(object sender, EventArgs e)
        {
            int.TryParse(EixoX.Text,out int x);
            int.TryParse(EixoY.Text, out int y);
            int value = cbo_bioma.SelectedIndex;

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

        /// <summary>
        /// ClearMap Click Event
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
        /// Export Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_exp_Click(object sender, EventArgs e)
        {
            FileManager.ExportMap(MapEditor.GetMap());
        }
        /// <summary>
        /// Import Click Event  
        /// Remove all tiles and set to null the MapEditor  
        /// After that, creates a new MapEditor with the default map in a .txt file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_imp_Click(object sender, EventArgs e)
        {
            ClearMap();
            MapEditor = new MapController(FileManager.ImportMap());
            CreateTileControls();
        }
        /// <summary>
        /// Remove all the tiles in the form and resets the IMapEditor class
        /// </summary>
        private void ClearMap() {
            if(MapEditor != null) { 
                List<Tile> RemovedTiles = MapEditor.GetMap();

                foreach(Tile item in RemovedTiles) {
                    Controls.Remove(item);
                }

                MapEditor = null;
            }
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
