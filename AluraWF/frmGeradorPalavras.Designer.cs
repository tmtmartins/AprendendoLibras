namespace AluraWF {
    partial class frmGeradorPalavras {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.tbPalavra = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pbGerador = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGerador)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(275, 120);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(830, 30);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Insira uma palavra e clique no botão \"buscar\" para ver a datilologia!";
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Gold;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(1185, 641);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(120, 41);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "VOLTAR";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // tbPalavra
            // 
            this.tbPalavra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPalavra.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPalavra.Location = new System.Drawing.Point(144, 182);
            this.tbPalavra.Name = "tbPalavra";
            this.tbPalavra.Size = new System.Drawing.Size(907, 37);
            this.tbPalavra.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gold;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1073, 182);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 37);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pbGerador
            // 
            this.pbGerador.BackColor = System.Drawing.Color.Orange;
            this.pbGerador.Location = new System.Drawing.Point(45, 299);
            this.pbGerador.Name = "pbGerador";
            this.pbGerador.Size = new System.Drawing.Size(1260, 327);
            this.pbGerador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGerador.TabIndex = 5;
            this.pbGerador.TabStop = false;
            // 
            // frmGeradorPalavras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 711);
            this.Controls.Add(this.pbGerador);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbPalavra);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lblDescricao);
            this.Name = "frmGeradorPalavras";
            this.Text = "frmGeradorPalavras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbGerador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.TextBox tbPalavra;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pbGerador;
    }
}