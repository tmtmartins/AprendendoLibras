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
    public partial class frm_Teste : Form {
        public frm_Teste() {
            InitializeComponent();
            lblTitulo.Left = (Width - lblTitulo.Width) / 2;
        }

        protected override void OnPaint(PaintEventArgs e) {
            /* Cria um objeto do tipo GraphicsPath que modifica a forma
            do botão em questão*/

            GraphicsPath forma = new GraphicsPath();
            /* Define como uma elipse o formato do objeto criado
                atribuindo valores para os parâmetros de posição e tamanho*/
            forma.AddEllipse(0, 0, btnSair.Width, btnSair.Height);
            /* Define a região do botão a ser arredondado, ou seja,
            o botão em si*/
            btnSair.Region = new Region(forma);
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
