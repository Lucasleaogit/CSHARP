using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialArduinoVS2022
{
    public partial class Form1 : Form
    {
        SerialPort serialPort1 = new SerialPort();

        public Form1()
        {
            InitializeComponent();

            serialPort1.DataReceived += serialPort1_DataReceived;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizaListaCOMs();
        }

        // Atualiza portas disponíveis
        private void AtualizaListaCOMs()
        {
            comboBoxCOM.Items.Clear();
            comboBoxCOM.Items.AddRange(SerialPort.GetPortNames());

            if (comboBoxCOM.Items.Count > 0)
                comboBoxCOM.SelectedIndex = 0;
        }

        // Botão Conectar / Desconectar
        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = comboBoxCOM.Text;
                    serialPort1.BaudRate = 9600;
                    serialPort1.Open();

                    btnConectar.Text = "Desconectar";
                }
                else
                {
                    serialPort1.Close();
                    btnConectar.Text = "Conectar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        // Enviar dados
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(textBoxEnviar.Text);
            }
        }

        // Receber dados do Arduino
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string dados = serialPort1.ReadExisting();

            this.Invoke(new Action(() =>
            {
                textBoxReceber.AppendText(dados);
            }));
        }

        // Fechar porta ao encerrar programa
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }
    }
}