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
            this.EixoX = new System.Windows.Forms.TextBox();
            this.EixoY = new System.Windows.Forms.TextBox();
            this.btn_exp = new System.Windows.Forms.Button();
            this.btn_imp = new System.Windows.Forms.Button();
            this.cbo_bioma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.Mapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Mapa.Location = new System.Drawing.Point(12, 224);
            this.Mapa.Name = "Mapa";
            this.Mapa.Size = new System.Drawing.Size(372, 344);
            this.Mapa.TabIndex = 3;
            this.Mapa.TabStop = false;
            // 
            // BtnGerar
            // 
            this.BtnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnGerar.Location = new System.Drawing.Point(19, 143);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(174, 37);
            this.BtnGerar.TabIndex = 4;
            this.BtnGerar.Text = "Gerar Mapa";
            this.BtnGerar.UseVisualStyleBackColor = true;
            this.BtnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(210, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Limpar Mapa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
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
            // EixoY
            // 
            this.EixoY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EixoY.Location = new System.Drawing.Point(308, 60);
            this.EixoY.MaxLength = 2;
            this.EixoY.Name = "EixoY";
            this.EixoY.Size = new System.Drawing.Size(76, 33);
            this.EixoY.TabIndex = 1;
            // 
            // btn_exp
            // 
            this.btn_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_exp.Location = new System.Drawing.Point(19, 186);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new System.Drawing.Size(174, 37);
            this.btn_exp.TabIndex = 6;
            this.btn_exp.Text = "Exportar";
            this.btn_exp.UseVisualStyleBackColor = true;
            this.btn_exp.Click += new System.EventHandler(this.Btn_exp_Click);
            // 
            // btn_imp
            // 
            this.btn_imp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_imp.Location = new System.Drawing.Point(211, 186);
            this.btn_imp.Name = "btn_imp";
            this.btn_imp.Size = new System.Drawing.Size(174, 37);
            this.btn_imp.TabIndex = 7;
            this.btn_imp.Text = "Importar";
            this.btn_imp.UseVisualStyleBackColor = true;
            this.btn_imp.Click += new System.EventHandler(this.Btn_imp_Click);
            // 
            // cbo_bioma
            // 
            this.cbo_bioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_bioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.88235F);
            this.cbo_bioma.FormattingEnabled = true;
            this.cbo_bioma.Items.AddRange(new object[] {
            "Nenhum",
            "Floresta",
            "Deserto",
            "Selva",
            "Pantano"});
            this.cbo_bioma.Location = new System.Drawing.Point(102, 100);
            this.cbo_bioma.Name = "cbo_bioma";
            this.cbo_bioma.Size = new System.Drawing.Size(283, 37);
            this.cbo_bioma.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(14, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bioma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_bioma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_imp);
            this.Controls.Add(this.btn_exp);
            this.Controls.Add(this.EixoY);
            this.Controls.Add(this.EixoX);
            this.Controls.Add(this.BtnGerar);
            this.Controls.Add(this.Mapa);
            this.Controls.Add(this.Label_Y);
            this.Controls.Add(this.Label_x);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gerar Mapa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_x;
        private System.Windows.Forms.Label Label_Y;
        private System.Windows.Forms.GroupBox Mapa;
        private System.Windows.Forms.Button BtnGerar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox EixoX;
        private System.Windows.Forms.TextBox EixoY;
        private System.Windows.Forms.Button btn_exp;
        private System.Windows.Forms.Button btn_imp;
        private System.Windows.Forms.ComboBox cbo_bioma;
        private System.Windows.Forms.Label label1;
    }
}

