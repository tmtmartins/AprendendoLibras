namespace AluraWF {
    partial class frm_Teste {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Teste));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btn_descricao = new System.Windows.Forms.Button();
            this.btn_Alfabeto = new System.Windows.Forms.Button();
            this.btnGerador = new System.Windows.Forms.Button();
            this.btnMontarPalavra = new System.Windows.Forms.Button();
            this.btnHistoria = new System.Windows.Forms.Button();
            this.btnJogoMemoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTitulo.Location = new System.Drawing.Point(359, 187);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(632, 70);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "APRENDENDO LIBRAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Khaki;
            this.btnSair.BackgroundImage = global::AluraWF.Properties.Resources.exit12;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(1234, 596);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 90);
            this.btnSair.TabIndex = 1;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_descricao
            // 
            this.btn_descricao.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_descricao.FlatAppearance.BorderSize = 0;
            this.btn_descricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_descricao.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descricao.ForeColor = System.Drawing.Color.White;
            this.btn_descricao.Location = new System.Drawing.Point(252, 323);
            this.btn_descricao.Name = "btn_descricao";
            this.btn_descricao.Size = new System.Drawing.Size(264, 92);
            this.btn_descricao.TabIndex = 2;
            this.btn_descricao.Text = "O que é";
            this.btn_descricao.UseVisualStyleBackColor = false;
            this.btn_descricao.Click += new System.EventHandler(this.btn_descricao_Click);
            // 
            // btn_Alfabeto
            // 
            this.btn_Alfabeto.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Alfabeto.FlatAppearance.BorderSize = 0;
            this.btn_Alfabeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alfabeto.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alfabeto.ForeColor = System.Drawing.Color.White;
            this.btn_Alfabeto.Location = new System.Drawing.Point(252, 474);
            this.btn_Alfabeto.Name = "btn_Alfabeto";
            this.btn_Alfabeto.Size = new System.Drawing.Size(264, 92);
            this.btn_Alfabeto.TabIndex = 3;
            this.btn_Alfabeto.Text = "Alfabeto";
            this.btn_Alfabeto.UseVisualStyleBackColor = false;
            this.btn_Alfabeto.Click += new System.EventHandler(this.btn_Alfabeto_Click);
            // 
            // btnGerador
            // 
            this.btnGerador.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGerador.FlatAppearance.BorderSize = 0;
            this.btnGerador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerador.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerador.ForeColor = System.Drawing.Color.White;
            this.btnGerador.Location = new System.Drawing.Point(539, 474);
            this.btnGerador.Name = "btnGerador";
            this.btnGerador.Size = new System.Drawing.Size(264, 92);
            this.btnGerador.TabIndex = 4;
            this.btnGerador.Text = "Gerador de Palavras";
            this.btnGerador.UseVisualStyleBackColor = false;
            this.btnGerador.Click += new System.EventHandler(this.btnGerador_Click);
            // 
            // btnMontarPalavra
            // 
            this.btnMontarPalavra.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMontarPalavra.FlatAppearance.BorderSize = 0;
            this.btnMontarPalavra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMontarPalavra.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMontarPalavra.ForeColor = System.Drawing.Color.White;
            this.btnMontarPalavra.Location = new System.Drawing.Point(829, 474);
            this.btnMontarPalavra.Name = "btnMontarPalavra";
            this.btnMontarPalavra.Size = new System.Drawing.Size(264, 92);
            this.btnMontarPalavra.TabIndex = 5;
            this.btnMontarPalavra.Text = "Jogo da Forca";
            this.btnMontarPalavra.UseVisualStyleBackColor = false;
            this.btnMontarPalavra.Click += new System.EventHandler(this.btnMontarPalavra_Click);
            // 
            // btnHistoria
            // 
            this.btnHistoria.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnHistoria.FlatAppearance.BorderSize = 0;
            this.btnHistoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoria.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoria.ForeColor = System.Drawing.Color.White;
            this.btnHistoria.Location = new System.Drawing.Point(539, 323);
            this.btnHistoria.Name = "btnHistoria";
            this.btnHistoria.Size = new System.Drawing.Size(264, 92);
            this.btnHistoria.TabIndex = 6;
            this.btnHistoria.Text = "História";
            this.btnHistoria.UseVisualStyleBackColor = false;
            // 
            // btnJogoMemoria
            // 
            this.btnJogoMemoria.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnJogoMemoria.FlatAppearance.BorderSize = 0;
            this.btnJogoMemoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogoMemoria.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogoMemoria.ForeColor = System.Drawing.Color.White;
            this.btnJogoMemoria.Location = new System.Drawing.Point(829, 323);
            this.btnJogoMemoria.Name = "btnJogoMemoria";
            this.btnJogoMemoria.Size = new System.Drawing.Size(264, 92);
            this.btnJogoMemoria.TabIndex = 7;
            this.btnJogoMemoria.Text = "Jogo da Memória";
            this.btnJogoMemoria.UseVisualStyleBackColor = false;
            // 
            // frm_Teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 711);
            this.Controls.Add(this.btnJogoMemoria);
            this.Controls.Add(this.btnHistoria);
            this.Controls.Add(this.btnMontarPalavra);
            this.Controls.Add(this.btnGerador);
            this.Controls.Add(this.btn_Alfabeto);
            this.Controls.Add(this.btn_descricao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frm_Teste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APRENDENDO LIBRAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Teste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btn_descricao;
        private System.Windows.Forms.Button btn_Alfabeto;
        private System.Windows.Forms.Button btnGerador;
        private System.Windows.Forms.Button btnMontarPalavra;
        private System.Windows.Forms.Button btnHistoria;
        private System.Windows.Forms.Button btnJogoMemoria;
    }
}

