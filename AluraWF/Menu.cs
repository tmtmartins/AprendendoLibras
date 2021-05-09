using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluraWF {
    public partial class frmMenu : Form {
        public frmMenu() {
            InitializeComponent();
            lblTitulo.Left = (Width - lblTitulo.Width) / 2;
            Transform.ArredondaButton(btnSair);
        }

        private void Teste_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void button1_Click_1(object sender, EventArgs e) {

        }

        private void btn_sair_Click(object sender, EventArgs e) {
            DialogResult result;
            result = MessageBox.Show("Deseja sair e encerrar a aplicação?",
                "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == System.Windows.Forms.DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void btn_descricao_Click(object sender, EventArgs e) {
            frmDescricao desc = new frmDescricao();
            desc.Show();
        }

        private void btn_Alfabeto_Click(object sender, EventArgs e) {
            frmAlfabeto alfabeto = new frmAlfabeto();
            alfabeto.Show();
        }

        private void btnMontarPalavra_Click(object sender, EventArgs e) {
            frmForca forca = new frmForca();
            forca.Show();
        }

        private void btnGerador_Click(object sender, EventArgs e) {
            frmGeradorPalavras gerador = new frmGeradorPalavras();
            gerador.Show();
        }
    }
}
