namespace MapGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_x = new System.Windows.Forms.Label();
            this.Label_Y = new System.Windows.Forms.Label();
            this.Mapa = new System.Windows.Forms.GroupBox();
            this.BtnGerar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.EixoX = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Mapa.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_x
            // 
            this.Label_x.AutoSize = true;
            this.Label_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label_x.Location = new System.Drawing.Point(12, 21);
            this.Label_x.Name = "Label_x";
            this.Label_x.Size = new System.Drawing.Size(289, 29);
            this.Label_x.TabIndex = 0;
            this.Label_x.Text = "Insira Tamanho do Eixo X";
            // 
            // Label_Y
            // 
            this.Label_Y.AutoSize = true;
            this.Label_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label_Y.Location = new System.Drawing.Point(12, 64);
            this.Label_Y.Name = "Label_Y";
            this.Label_Y.Size = new System.Drawing.Size(288, 29);
            this.Label_Y.TabIndex = 1;
            this.Label_Y.Text = "Insira Tamanho do Eixo Y";
            // 
            // Mapa
            // 
            this.Mapa.Controls.Add(this.button2);
            this.Mapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Mapa.Location = new System.Drawing.Point(12, 124);
            this.Mapa.Name = "Mapa";
            this.Mapa.Size = new System.Drawing.Size(372, 344);
            this.Mapa.TabIndex = 3;
            this.Mapa.TabStop = false;
            // 
            // BtnGerar
            // 
            this.BtnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnGerar.Location = new System.Drawing.Point(23, 96);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(153, 37);
            this.BtnGerar.TabIndex = 4;
            this.BtnGerar.Text = "Gerar Mapa";
            this.BtnGerar.UseVisualStyleBackColor = true;
            this.BtnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(204, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Limpar Mapa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EixoX
            // 
            this.EixoX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EixoX.Location = new System.Drawing.Point(308, 21);
            this.EixoX.MaxLength = 2;
            this.EixoX.Name = "EixoX";
            this.EixoX.Size = new System.Drawing.Size(76, 33);
            this.EixoX.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(308, 60);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 33);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 480);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EixoX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnGerar);
            this.Controls.Add(this.Mapa);
            this.Controls.Add(this.Label_Y);
            this.Controls.Add(this.Label_x);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Mapa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_x;
        private System.Windows.Forms.Label Label_Y;
        private System.Windows.Forms.GroupBox Mapa;
        private System.Windows.Forms.Button BtnGerar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox EixoX;
        private System.Windows.Forms.TextBox textBox1;
    }
}

