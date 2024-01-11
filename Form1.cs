using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double peso) && double.TryParse(textBox2.Text, out double altura))
            {
                // Calcular o IMC
                double imc = peso / (altura * altura);

                // Exibir o resultado em um MessageBox
                string mensagem = $"Seu Índice de Massa Corporal (IMC) é: {imc:F2}";

                // Verificar a faixa de IMC e fornecer uma mensagem correspondente
                string sobrePeso = "Procure ajuda médica";
                if (imc < 18.5)
                {
                    mensagem += "\nVocê está abaixo do peso.";
                }
                else if (imc >= 18.5 && imc <= 24.99)
                {
                    mensagem += "\nVocê está com o peso normal.";
                }
                else if (imc >= 25 && imc <= 29.99)
                {
                    mensagem += "\nVocê está com sobrepeso.";
                }
                else if (imc >= 30 && imc <= 34.99)
                {
                    mensagem += "\nVocê está com obesidade classe I\n" + sobrePeso;
                }
                else if (imc >= 35 && imc <= 39.99)
                {
                    mensagem += "\nVocê está com obesidade classe II\n" + sobrePeso;
                }
                else
                {
                    mensagem += "\nVocê está com obesidade classe III\n" + sobrePeso;
                }

                MessageBox.Show(mensagem, "Resultado do IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos para peso e altura.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
