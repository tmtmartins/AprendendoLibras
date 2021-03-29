﻿using System;
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
            MessageBox.Show(arquivos[0], arquivos[1]);

            imagensCombinadas = CombinarImagens(arquivos);
            string pathNewImage = "../../Imagens/Gerador/teste.jpg";
            imagensCombinadas.Save(pathNewImage, System.Drawing.Imaging.ImageFormat.Jpeg);
            pbGerador.Load(pathNewImage);
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
              
            string palavra = tbPalavra.Text;
            SelecionarImagens(palavra);
            
        }
    }
}
