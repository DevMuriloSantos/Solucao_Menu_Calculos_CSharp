using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Calculos.Formularios
{
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }
        
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            radioCalculatorPanel.Left = (this.ClientSize.Width - radioCalculatorPanel.Width) / 2;
            radioCalculatorPanel.Top = (this.ClientSize.Height - radioCalculatorPanel.Height) / 2;
        } // centraliza os componentes

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            // valida entrada
            if (!double.TryParse(textBoxN1.Text, out double a) ||
                !double.TryParse(textBoxN2.Text, out double b))
            {
                MessageBox.Show("Digite apenas números válidos!");
                return;
            }
            
            /* out double a -> isso indica que se a conversão retornar True,
            o valor de sáida será atribuido à uma var "a" do tipo double. Caso retorne False, o sistema
            retornará uma mensagem de erro. */

            string operacao = null;
            
            foreach (Control ctrl in groupBoxRb.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    operacao = rb.Tag?.ToString();
                    break;
                }
            }
            
            //groupBoxRb.Controls -> retorna tudo o que estiver dentro do groupBoxRb
            
            if (operacao == null)
            {
                MessageBox.Show("Selecione uma operação!", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double resultado = 0;

            // executa operação
            switch (operacao)
            {
                case "+":
                    resultado = a + b;
                    break;

                case "-":
                    resultado = a - b;
                    break;

                case "*":
                    resultado = a * b;
                    break;

                case "/":
                    if (b == 0)
                    {
                        MessageBox.Show("Não é possível dividir por zero!", 
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    resultado = a / b;
                    break;
                
                case "^":
                    resultado = Math.Pow(a, b); //Math.Pow(base, expoente)
                    break;
            }

            // mostra resultado
            lblSinal.Text = operacao;
            lblResultado.Text = resultado.ToString();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            textBoxN1.Clear();
            textBoxN2.Clear();
            lblSinal.Text = "?";
            lblResultado.Text = "?";

            textBoxN1.Focus();
            radioButton1.Checked = true;
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}