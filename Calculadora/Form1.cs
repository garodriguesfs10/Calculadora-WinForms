using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button20_Click(object sender, EventArgs e)
        {          
            txtResultado.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var texto = txtResultado.Text;
            if (texto.Contains("."))
            {
                MessageBox.Show("Não é possível adicionar vírgula duas vezes");
            }
            else
            {
                txtResultado.Text += ".";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //soma
            valor1 = decimal.Parse(txtResultado.Text,CultureInfo.InvariantCulture);
            lblvalor1.Text = valor1.ToString();
            configOperacao("SOMA","+");           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // igual
            if (txtResultado.Text == "")
            {
                MessageBox.Show("Digite um número para o segundo valor.");
                return;
            }
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            lblvalor2.Text = valor2.ToString();
            switch (operacao)
            {
                case ("SOMA"):
                    var soma = Math.Round(valor1 + valor2,2);
                    txtResultado.Text = soma.ToString();
                    break;
                case ("MULTIPLICACAO"):
                    var multiplicao = Math.Round(valor1 * valor2,2);
                    txtResultado.Text = multiplicao.ToString();
                    break;
                case ("MENOS"):
                    var menos = Math.Round(valor1 - valor2,2);
                    txtResultado.Text = menos.ToString();
                    break;
                case ("DIVISAO"):
                    var divisao = Math.Round(valor1/valor2,2);
                    txtResultado.Text = divisao.ToString();
                    break;
                default:
                    MessageBox.Show("Erro");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //MULTIPLICAÇÃO
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            lblvalor1.Text = valor1.ToString();
            configOperacao("MULTIPLICACAO", "x");       
        }

        private void configOperacao(string operacaoTipo, string labelOperacao)
        {
            txtResultado.Text = "";
            lblvalor2.Text = "";
            operacao = operacaoTipo;
            lbloperacao2.Text = labelOperacao;
            lblOperacao.Text = labelOperacao;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //menos
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            lblvalor1.Text = valor1.ToString();
            configOperacao("MENOS", "-");            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //DIVISAO
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            lblvalor1.Text = valor1.ToString();
            configOperacao("DIVISAO", "/");            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //BOTAO CE
            CleanAll();
        }

        private void CleanAll()
        {
            valor1 = 0;
            valor2 = 0;
            txtResultado.Text = "";
            operacao = "";
            lbloperacao2.Text = "";
            lblOperacao.Text = "";
            lblvalor1.Text = "";
            lblvalor2.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblvalor1_Click(object sender, EventArgs e)
        {

        }

        private void txtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Botão C
            CleanAll();
        }
    }
}
