using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWPF
{
    public partial class Form1 : Form
    {
        int punCorr = 0;
        int punIncorr = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + "0";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + "5";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + "7";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (btnPantalla.Text.Length == 1)
                btnPantalla.Text = "";
            else
                btnPantalla.Text = btnPantalla.Text.Substring(0, btnPantalla.Text.Length - 1);
        }

        private void btnRandom_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            double n = 0;
            Random random = new Random();
            n = random.Next(1, 100);
            btnRandom.Text = n.ToString();

            btnPantalla.Text = "";
        }


        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (double.TryParse(btnRandom.Text, out double numeroRandom) &&
                   double.TryParse(btnPantalla.Text, out double numeroIngresado))
            {
                double raizCuadrada = Math.Sqrt(numeroRandom);

                double tolerancia = 0.01;

                if (Math.Abs(raizCuadrada - numeroIngresado) < tolerancia)
                {
                    punCorr++; 
                }
                else
                {
                    punIncorr++; 
                }
            }
            btnCorrecto.Text = "Correcto: " + punCorr;
            btnIncorrecto.Text = "Incorrecto: " + punIncorr;
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            btnPantalla.Text = btnPantalla.Text + ",";
        }
    }
}