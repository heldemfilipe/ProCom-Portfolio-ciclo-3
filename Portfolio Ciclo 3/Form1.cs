using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Portfolio_Ciclo_3
{
    public partial class Portfolio : Form
    {
        public Portfolio()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btCalcular_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0;
            Regex somente_num = new Regex("[0-9]");

            if (String.IsNullOrEmpty(tbEntradaDadosA.Text) || String.IsNullOrEmpty(tbEntradaDadosB.Text) || String.IsNullOrEmpty(tbEntradaDadosC.Text))
            {
                tbResultadoDelta.Text = "Faltando valores!";
                tbResultadoX1.Text = "Faltando valores!";
                tbResultadoX2.Text = "Faltando valores!";
            }
            else
            {
                if (somente_num.IsMatch(tbEntradaDadosA.Text) && somente_num.IsMatch(tbEntradaDadosB.Text) && somente_num.IsMatch(tbEntradaDadosC.Text))
                { 
                    a = Convert.ToInt32(tbEntradaDadosA.Text);
                    b = Convert.ToInt32(tbEntradaDadosB.Text);
                    c = Convert.ToInt32(tbEntradaDadosC.Text);

                    CalcularDelta(a, b, c);
                    CalcularX1(a, b, c);
                    CalcularX2(a, b, c);
                }
                else
                { 
                    tbResultadoDelta.Text = "Caracter errado!"; 
                    tbResultadoX1.Text = "Caracter errado!";
                    tbResultadoX2.Text = "Caracter errado!";
                }

                
            }
        }
        private void CalcularDelta(int a, int b, int c)
        {
            double delta = (b * b) - (4 * (a * c));
            tbResultadoDelta.Text = delta.ToString();
        }
        private void CalcularX1(int a, int b, int c)
        {
            double delta = (b * b) - (4 * (a * c));
            double x1 = (-b + (Math.Sqrt(delta))) / (2 * a);

            if (delta > 0)
            {
                tbResultadoX1.Text = x1.ToString();
            }
            else if (delta == 0)
            {
                tbResultadoX1.Text = x1.ToString();
            }
            else
            {
                tbResultadoX1.Text = "Não possui raízes reais!";
            }
        }
        private void CalcularX2(int a, int b, int c)
        {
            double delta = (b * b) - (4 * (a * c));
            double x2 = (-b - (Math.Sqrt(delta))) / (2 * a);

            if (delta > 0)
            {
                tbResultadoX2.Text = x2.ToString();
            }
            else if (delta == 0)
            {
                tbResultadoX2.Text = x2.ToString();
            }
            else
            {
                tbResultadoX2.Text = "Não possui raízes reais!";
            }
        }
        private void valorEntradaA_TextChanged(object sender, EventArgs e)
        {

        }

        private void indicadorResultadoDelta_Click(object sender, EventArgs e)
        {

        }

        private void Portfolio_Load(object sender, EventArgs e)
        {

        }

    }
}