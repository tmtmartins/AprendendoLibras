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
    public partial class frmAlfabeto : Form {
        public frmAlfabeto() {
            InitializeComponent();
            ArrayLetras();
            ArrayNum();
        }

        public static void ArrayNum() {
            int[] num = null;
            int b = 0;
            num = new int[10];

            for (int i = 0; i <= 9; i++) {
                num[i] = i;
            }
        }
        
        public static void ArrayLetras() {
            string[] letras = null;
            letras = new string[31];
            letras[0] = "A";
            letras[1] = "B";
            letras[2] = "C1";
            letras[3] = "C2";
            letras[4] = "D";
            letras[5] = "E";
            letras[6] = "F";
            letras[7] = "G";
            letras[8] = "H";
            letras[9] = "I";
            letras[10] = "J";
            letras[11] = "K";
            letras[12] = "L";
            letras[13] = "M";
            letras[14] = "N";
            letras[15] = "O";
            letras[16] = "P";
            letras[17] = "Q";
            letras[18] = "R";
            letras[19] = "S";
            letras[20] = "T";
            letras[21] = "U";
            letras[22] = "V";
            letras[23] = "W";
            letras[24] = "X";
            letras[25] = "Y";
            letras[26] = "Z";
            letras[27] = "mais";
            letras[28] = "menos";
            letras[29] = "multi";
            letras[30] = "div";
        }

        public void LimpaCorButton(string letra) {

            if (letra == "C1") {
                letra = ("C");
            }

            else if (letra == "C2") {
                letra = ("Ç");
            }

            else if (letra == "mais") {
                letra = ("+");
            }

            else if (letra == "menos") {
                letra = ("-");
            }

            else if (letra == "multi") {
                letra = ("*");
            }

            else if (letra == "div") {
                letra = ("/");
            }

            string btn = ($"System.Windows.Forms.Button, Text: {letra}");

            var botoes = new[] { btnA, btnB, btnC1, btnC2, btnD, btnE,
            btnF, btnG, btnH, btnI, btnJ, btnK, btnL, btnM, btnN, btnO, btnP,
            btnQ, btnR, btnS, btnT, btnU, btnV, btnW, btnX, btnY, btnZ, btnMais,
            btnMenos, btnMulti, btnDiv, btn0, btn1, btn2, btn3, btn4, btn5, btn6,
            btn7, btn8, btn9};

            foreach (var botao in botoes) {
                if (btn.ToString() == botao.ToString()) {
                    botao.BackColor = Color.Gold;
                }
                else {
                    botao.BackColor = Color.Transparent;
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e) {
            this.Close();
        }

        public void onClick(string item) {
            LimpaCorButton(item);
            pbAlfabeto.Load($"../../Imagens/Alfabeto/{item}.png");
        }
        private void btnA_Click(object sender, EventArgs e) {
            onClick("A");
        }

        private void btnB_Click(object sender, EventArgs e) {
            onClick("B");
        }

        private void btnC1_Click(object sender, EventArgs e) {
            onClick("C1");
        }

        private void btnC2_Click(object sender, EventArgs e) {
            onClick("C2");
        }

        private void btnD_Click(object sender, EventArgs e) {
            onClick("D");
        }

        private void btnE_Click(object sender, EventArgs e) {
            onClick("E");
        }

        private void btnF_Click(object sender, EventArgs e) {
            onClick("F");
        }

        private void btnG_Click(object sender, EventArgs e) {
            onClick("G");
        }

        private void btnH_Click(object sender, EventArgs e) {
            onClick("H");
        }

        private void btnI_Click(object sender, EventArgs e) {
            onClick("I");
        }

        private void btnJ_Click(object sender, EventArgs e) {
            onClick("J");
        }

        private void btnK_Click(object sender, EventArgs e) {
            onClick("K");
        }

        private void btnL_Click(object sender, EventArgs e) {
            onClick("L");
        }

        private void btnM_Click(object sender, EventArgs e) {
            onClick("M");
        }

        private void btnN_Click(object sender, EventArgs e) {
            onClick("N");
        }

        private void btnO_Click(object sender, EventArgs e) {
            onClick("O");
        }

        private void btnP_Click(object sender, EventArgs e) {
            onClick("P");
        }

        private void btnQ_Click(object sender, EventArgs e) {
            onClick("Q");
        }

        private void btnR_Click(object sender, EventArgs e) {
            onClick("R");
        }

        private void btnS_Click(object sender, EventArgs e) {
            onClick("S");
        }

        private void btnT_Click(object sender, EventArgs e) {
            onClick("T");
        }

        private void btnU_Click(object sender, EventArgs e) {
            onClick("U");
        }

        private void btnV_Click(object sender, EventArgs e) {
            onClick("V");
        }

        private void btnW_Click(object sender, EventArgs e) {
            onClick("W");
        }

        private void btnX_Click(object sender, EventArgs e) {
            onClick("X");
        }

        private void Y_Click(object sender, EventArgs e) {
            onClick("Y");
        }

        private void btnZ_Click(object sender, EventArgs e) {
            onClick("Z");
        }

        private void btn0_Click(object sender, EventArgs e) {
            onClick("0");
        }

        private void btn1_Click(object sender, EventArgs e) {
            onClick("1");
        }

        private void btn2_Click(object sender, EventArgs e) {
            onClick("2");
        }

        private void btn3_Click(object sender, EventArgs e) {
            onClick("3");
        }

        private void btn4_Click(object sender, EventArgs e) {
            onClick("4");
        }

        private void btn5_Click(object sender, EventArgs e) {
            onClick("5");
        }

        private void btn6_Click(object sender, EventArgs e) {
            onClick("6");
        }

        private void btn7_Click(object sender, EventArgs e) {
            onClick("7");
        }

        private void btn8_Click(object sender, EventArgs e) {
            onClick("8");
        }

        private void btn9_Click(object sender, EventArgs e) {
            onClick("9");
        }

        private void btnMais_Click(object sender, EventArgs e) {
            onClick("mais");
        }

        private void btnMenos_Click(object sender, EventArgs e) {
            onClick("menos");
        }

        private void btnMulti_Click(object sender, EventArgs e) {
            onClick("multi");
        }

        private void btnDiv_Click(object sender, EventArgs e) {
            onClick("div");
        }
    }
}
