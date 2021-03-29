using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluraWF {
    public partial class frm_Teste : Form {
        public frm_Teste() {
            InitializeComponent();
        }

        private void Teste_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void button1_Click_1(object sender, EventArgs e) {

        }

        private void btn_sair_Click(object sender, EventArgs e) {
            Application.Exit();
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
            frmMontarPalavra montar = new frmMontarPalavra();
            montar.Show();
        }

        private void btnGerador_Click(object sender, EventArgs e) {
            frmGeradorPalavras gerador = new frmGeradorPalavras();
            gerador.Show();
        }
    }
}
