using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.IO;

namespace AluraWF {
    public partial class frmGeradorPalavras : Form {
        public frmGeradorPalavras() {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e) {
            this.Close();
        }

        public void SelecionarImagens(string palavra) {
            char[] arr = null;
            arr = palavra.ToCharArray();
                        
            string file = "";

            foreach (char c in arr) {
                string letra = "";
                if (c.Equals('C') == true) {
                    letra = ("C1");
                }

                else if (c.Equals('Ç') == true) {
                    letra = ("C2");
                }

                else if (c.Equals('+')) {
                    letra = ("mais");
                }

                else if (c.Equals('-')) {
                    letra = ("menos");
                }

                else if (c.Equals('*')) {
                    letra = ("multi");
                }

                else if (c.Equals('/')) {
                    letra = ("div");
                }

                else {
                    MessageBox.Show(c.ToString());
                    letra = c.ToString();
                }

                file += ($"../../Imagens/Alfabeto/{letra}.png#");
            }

            System.Drawing.Bitmap imagensCombinadas;
            //obtem a posicao da ultima ocorrência do caractere #
            int posicao = file.LastIndexOf('#');

            //remove a última ocorrência do caractere #
            string arquivosSelecionados = file.Remove(posicao);
            string[] arquivos = arquivosSelecionados.Split('#');

            imagensCombinadas = CombinarImagens(arquivos);
            string pathNewImage = "../../Imagens/Gerador/teste.jpg";

            if (System.IO.File.Exists(pathNewImage)) {
                System.IO.File.Delete(pathNewImage);
            }

            imagensCombinadas.Save(pathNewImage, System.Drawing.Imaging.ImageFormat.Jpeg);
            
            using (FileStream fs = new FileStream(pathNewImage, FileMode.Open)) {
                pbGerador.Image = Image.FromStream(fs);
                fs.Close();
            }
        }

        public static System.Drawing.Bitmap CombinarImagens(string[] files) {
            //lê todas as imagens para a memória
            List<System.Drawing.Bitmap> images = new List<System.Drawing.Bitmap>();
            System.Drawing.Bitmap imagemFinal = null;

            try {
                int width = 0;
                int height = 0;

                foreach (string image in files) {
                    //cria um bitmap a partir do arquivo e o inclui na lista
                    System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(image);

                    //atualiza o tamanho da imagem bitmap final
                    width += bitmap.Width;
                    height = bitmap.Height > height ? bitmap.Height : height;

                    images.Add(bitmap);
                }

                //cria um bitmap para tratar a imagem combinada
                imagemFinal = new System.Drawing.Bitmap(width, height);

                //Obtem o objeto gráfico da imagem 
                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(imagemFinal)) {
                    //define a cor de fundo
                    g.Clear(System.Drawing.Color.Black);

                    //percorre imagem por imagem e gera uma unica imagem final
                    int offset = 0;
                    foreach (System.Drawing.Bitmap image in images) {
                        g.DrawImage(image,
                          new System.Drawing.Rectangle(offset, 0, image.Width, image.Height));
                        offset += image.Width;
                    }
                }

                return imagemFinal;
            }
            catch (Exception ex) {
                if (imagemFinal != null)
                    imagemFinal.Dispose();

                throw ex;
            }
        }

            private void btnBuscar_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbPalavra.Text)) {
                MessageBox.Show("Insira uma palavra ou número na caixa de texto para buscar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbPalavra.Text.Contains("|") ^
                    tbPalavra.Text.Contains("?") ^
                    tbPalavra.Text.Contains("'") ^
                    tbPalavra.Text.Contains('"') ^
                    tbPalavra.Text.Contains(">") ^
                    tbPalavra.Text.Contains("<") ^
                    tbPalavra.Text.Contains(",") ^
                    tbPalavra.Text.Contains(".") ^
                    tbPalavra.Text.Contains(";") ^
                    tbPalavra.Text.Contains("´") ^
                    tbPalavra.Text.Contains("`") ^
                    tbPalavra.Text.Contains("^") ^
                    tbPalavra.Text.Contains("~") ^
                    tbPalavra.Text.Contains("#") ^
                    tbPalavra.Text.Contains("@") ^
                    tbPalavra.Text.Contains("!") ^
                    tbPalavra.Text.Contains("$") ^
                    tbPalavra.Text.Contains("%") ^
                    tbPalavra.Text.Contains("¨") ^
                    tbPalavra.Text.Contains("&") ^
                    tbPalavra.Text.Contains("(") ^
                    tbPalavra.Text.Contains(")") ^
                    tbPalavra.Text.Contains("_") ^
                    tbPalavra.Text.Contains("=") ^
                    tbPalavra.Text.Contains("}") ^
                    tbPalavra.Text.Contains("{") ^
                    tbPalavra.Text.Contains("[") ^
                    tbPalavra.Text.Contains("]") ^
                    tbPalavra.Text.Contains("º") ^
                    tbPalavra.Text.Contains("Ä") ^
                    tbPalavra.Text.Contains("Å") ^
                    tbPalavra.Text.Contains("Á") ^
                    tbPalavra.Text.Contains("Â") ^
                    tbPalavra.Text.Contains("À") ^
                    tbPalavra.Text.Contains("Ã") ^
                    tbPalavra.Text.Contains("É") ^
                    tbPalavra.Text.Contains("é") ^
                    tbPalavra.Text.Contains("Ê") ^
                    tbPalavra.Text.Contains("Ë") ^
                    tbPalavra.Text.Contains("È") ^
                    tbPalavra.Text.Contains("Í") ^
                    tbPalavra.Text.Contains("Î") ^
                    tbPalavra.Text.Contains("Ï") ^
                    tbPalavra.Text.Contains("Ì") ^
                    tbPalavra.Text.Contains("Ö") ^
                    tbPalavra.Text.Contains("Ó") ^
                    tbPalavra.Text.Contains("Ô") ^
                    tbPalavra.Text.Contains("Ò") ^
                    tbPalavra.Text.Contains("Õ") ^
                    tbPalavra.Text.Contains("Ö") ^
                    tbPalavra.Text.Contains("Ü") ^
                    tbPalavra.Text.Contains("Ú") ^
                    tbPalavra.Text.Contains("Û")) {

                MessageBox.Show("Não podem ser digitadas letras com acentuação " +
                    "ou caracteres especiais além dos operadores matemáticos (+, -, /, *).",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPalavra.Clear();
            }

            else {
                string palavra = tbPalavra.Text;
                SelecionarImagens(palavra);
            }          
        }
    }
}
