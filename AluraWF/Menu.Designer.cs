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
            this.lb_title = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_descricao = new System.Windows.Forms.Button();
            this.btn_Alfabeto = new System.Windows.Forms.Button();
            this.btnGerador = new System.Windows.Forms.Button();
            this.btnMontarPalavra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_title.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(461, 63);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(509, 56);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "APRENDENDO LIBRAS";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Khaki;
            this.btn_sair.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(1227, 626);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(100, 41);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_descricao
            // 
            this.btn_descricao.BackColor = System.Drawing.Color.LightGray;
            this.btn_descricao.FlatAppearance.BorderSize = 4;
            this.btn_descricao.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descricao.ForeColor = System.Drawing.Color.Black;
            this.btn_descricao.Location = new System.Drawing.Point(375, 193);
            this.btn_descricao.Name = "btn_descricao";
            this.btn_descricao.Size = new System.Drawing.Size(264, 92);
            this.btn_descricao.TabIndex = 2;
            this.btn_descricao.Text = "O que é?";
            this.btn_descricao.UseVisualStyleBackColor = false;
            this.btn_descricao.Click += new System.EventHandler(this.btn_descricao_Click);
            // 
            // btn_Alfabeto
            // 
            this.btn_Alfabeto.BackColor = System.Drawing.Color.LightGray;
            this.btn_Alfabeto.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alfabeto.ForeColor = System.Drawing.Color.Black;
            this.btn_Alfabeto.Location = new System.Drawing.Point(776, 192);
            this.btn_Alfabeto.Name = "btn_Alfabeto";
            this.btn_Alfabeto.Size = new System.Drawing.Size(264, 92);
            this.btn_Alfabeto.TabIndex = 3;
            this.btn_Alfabeto.Text = "Alfabeto";
            this.btn_Alfabeto.UseVisualStyleBackColor = false;
            this.btn_Alfabeto.Click += new System.EventHandler(this.btn_Alfabeto_Click);
            // 
            // btnGerador
            // 
            this.btnGerador.BackColor = System.Drawing.Color.LightGray;
            this.btnGerador.FlatAppearance.BorderSize = 4;
            this.btnGerador.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerador.ForeColor = System.Drawing.Color.Black;
            this.btnGerador.Location = new System.Drawing.Point(375, 332);
            this.btnGerador.Name = "btnGerador";
            this.btnGerador.Size = new System.Drawing.Size(264, 92);
            this.btnGerador.TabIndex = 4;
            this.btnGerador.Text = "Gerador de Palavras";
            this.btnGerador.UseVisualStyleBackColor = false;
            this.btnGerador.Click += new System.EventHandler(this.btnGerador_Click);
            // 
            // btnMontarPalavra
            // 
            this.btnMontarPalavra.BackColor = System.Drawing.Color.LightGray;
            this.btnMontarPalavra.FlatAppearance.BorderSize = 4;
            this.btnMontarPalavra.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMontarPalavra.ForeColor = System.Drawing.Color.Black;
            this.btnMontarPalavra.Location = new System.Drawing.Point(776, 332);
            this.btnMontarPalavra.Name = "btnMontarPalavra";
            this.btnMontarPalavra.Size = new System.Drawing.Size(264, 92);
            this.btnMontarPalavra.TabIndex = 5;
            this.btnMontarPalavra.Text = "Monte a Palavra";
            this.btnMontarPalavra.UseVisualStyleBackColor = false;
            this.btnMontarPalavra.Click += new System.EventHandler(this.btnMontarPalavra_Click);
            // 
            // frm_Teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 711);
            this.Controls.Add(this.btnMontarPalavra);
            this.Controls.Add(this.btnGerador);
            this.Controls.Add(this.btn_Alfabeto);
            this.Controls.Add(this.btn_descricao);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lb_title);
            this.Name = "frm_Teste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APRENDENDO LIBRAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Teste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_descricao;
        private System.Windows.Forms.Button btn_Alfabeto;
        private System.Windows.Forms.Button btnGerador;
        private System.Windows.Forms.Button btnMontarPalavra;
    }
}

