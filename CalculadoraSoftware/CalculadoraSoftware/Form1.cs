using System;
using System.Windows.Forms;

namespace CalculadoraSoftware
{
    public partial class Form1 : Form
    {
        double valor1 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; 
        }


        private void Numero_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            TxtDisplay.Text += botao.Text;
        }

 
        private void Operador_Click(object sender, EventArgs e)
        {
            Button botão = (Button)sender;
            if (botão.Text == "-" && TxtDisplay.Text == "")
            {
                TxtDisplay.Text = "-";
                return;
            }
            if (TxtDisplay.Text == "" || TxtDisplay.Text == "-")
                return;
            valor1 = Convert.ToDouble(TxtDisplay.Text);
            operacao = botão.Text;
            TxtDisplay.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Calcular();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();
            valor1 = 0;
            operacao = "";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            AdicionarVirgula();
        }


        private void Calcular()
        {
            if (TxtDisplay.Text == "") return;

            double valor2 = Convert.ToDouble(TxtDisplay.Text);
            double resultado = 0;

            if (operacao == "+")
                resultado = valor1 + valor2;

            else if (operacao == "-")
                resultado = valor1 - valor2;

            else if (operacao == "*")
                resultado = valor1 * valor2;

            else if (operacao == "/")
            {
                if (valor2 == 0)
                {
                    MessageBox.Show("Não é possível dividir por zero.");
                    return;
                }
                resultado = valor1 / valor2;
            }

            TxtDisplay.Text = resultado.ToString();
        }

        private void AdicionarVirgula()
        {
            if (!TxtDisplay.Text.Contains(","))
            {
                if (TxtDisplay.Text == "")
                    TxtDisplay.Text = "0,";
                else
                    TxtDisplay.Text += ",";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
                TxtDisplay.Text += (e.KeyCode - Keys.D0).ToString();

            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
                TxtDisplay.Text += (e.KeyCode - Keys.NumPad0).ToString();

            if (e.KeyCode == Keys.Add)
                DefinirOperacao("+");

            if (e.KeyCode == Keys.Subtract)
                DefinirOperacao("-");

            if (e.KeyCode == Keys.Multiply)
                DefinirOperacao("*");

            if (e.KeyCode == Keys.Divide)
                DefinirOperacao("/");

            if (e.KeyCode == Keys.Enter)
                Calcular();

            if (e.KeyCode == Keys.Back && TxtDisplay.Text.Length > 0)
                TxtDisplay.Text = TxtDisplay.Text.Substring(0, TxtDisplay.Text.Length - 1);

       
            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal)
                AdicionarVirgula();

            if (e.KeyCode == Keys.OemMinus)
            {
                if (TxtDisplay.Text == "")
                    TxtDisplay.Text = "-";
                else
                    DefinirOperacao("-");
            }
        }

        private void DefinirOperacao(string op)
        {
           if (op == "-" && TxtDisplay.Text == "")
            { 
                TxtDisplay.Text = "-";
                return;
            }
            if (TxtDisplay.Text == "" || TxtDisplay.Text == "-")
                return;
            valor1 = Convert.ToDouble(TxtDisplay.Text);
            operacao = op;
            TxtDisplay.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}