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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.tbPalavra = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pbGerador = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGerador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(830, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira uma palavra e clique no botão \"buscar\" para ver a datilologia!";
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Khaki;
            this.btn_sair.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(1228, 648);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(100, 41);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // tbPalavra
            // 
            this.tbPalavra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPalavra.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPalavra.Location = new System.Drawing.Point(149, 113);
            this.tbPalavra.Name = "tbPalavra";
            this.tbPalavra.Size = new System.Drawing.Size(907, 37);
            this.tbPalavra.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Khaki;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1062, 113);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 37);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pbGerador
            // 
            this.pbGerador.Location = new System.Drawing.Point(39, 255);
            this.pbGerador.Name = "pbGerador";
            this.pbGerador.Size = new System.Drawing.Size(1260, 327);
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
            this.Controls.Add(this.label1);
            this.Name = "frmGeradorPalavras";
            this.Text = "frmGeradorPalavras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbGerador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.TextBox tbPalavra;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pbGerador;
    }
}