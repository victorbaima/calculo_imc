using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Declaração de variáveis
             * variável recebe o conteúdo do textbox*/
            double peso, altura, imc;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);
            /*textbox recebe o conteúdo da variável imc = resultado do cálculo
             * definição de utilização de 2 casas decimais*/
            txtImc.Text = imc.ToString("0.00");
            /*Condições de acordo com os resultados dos cálculos
             * Serão exibidas mensagens,
             * configuração das messagebox, (mensagens, botões, ícones)
             * como são várias condições temos um encadeamento de ifs*/
            if (imc < 18.49)
                MessageBox.Show("SITUAÇÃO: Você está abaixo do peso", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 24.99)
                MessageBox.Show("SITUAÇÃO: Você está com peso dentro da normalidade", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 29.99)
                MessageBox.Show("SITUAÇÃO: Você está acima do peso", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 34.99)
                MessageBox.Show("ATENÇÃO! Você está com obesidade grau I", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (imc < 39.99)
                MessageBox.Show("ATENÇÃO! Você está com obesidade grau II", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                MessageBox.Show("ATENÇÃO! Você está com obesidade grau III (mórbida)", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtImc.Text = "";
            txtPeso.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
