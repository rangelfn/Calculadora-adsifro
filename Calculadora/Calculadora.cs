using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora
{
    public partial class Calculadora : Form
    {

        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void Calculadora_Load(object sender, EventArgs e)
        {
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe os valores");
            }
        }
        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUBTRAIR";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe os valores");
            }
        }
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULTIPLICAR";
                lblOperacao.Text = "x";
            }
            else
            {
                MessageBox.Show("Informe os valores");
            }
        }
        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIVIDIR";
                lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe os valores");
            }

        }
        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUBTRAIR")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULTIPLICAR")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIVIDIR")
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }
        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }
        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }
        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }
        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }
        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }
        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }
        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }
        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

    }
}
