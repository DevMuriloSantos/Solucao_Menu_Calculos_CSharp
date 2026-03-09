using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Calculos
{
    public partial class frmCalculosBot : Form
    {
        public frmCalculosBot()
        {
            InitializeComponent();
        }
        
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            calculatorPanel.Left = (this.ClientSize.Width - calculatorPanel.Width) / 2;
            calculatorPanel.Top = (this.ClientSize.Height - calculatorPanel.Height) / 2;
        } // centraliza os componentes
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            OnResize(EventArgs.Empty);
        } // essa função faz o programa iniciar centralizado

        private void button2_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "?";
            lblResultado.Text = "?";
            txtN1.Clear();
            txtN2.Clear();
            txtN1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFecharTetxo_Click(object sender, EventArgs e)
        {
            Close(); // fecha a janela
        }

        private void txtN2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtN1.Text); // var numérica
                double b = double.Parse(txtN2.Text);
                lblSinal.Text = "+"; // muda o texto
                lblResultado.Text = (a + b).ToString(); // precisa converter pois é esperado um text
            }
            catch (FormatException)
            {
                MessageBox.Show("Só é permitido números neste campo!");
                button2_Click(sender, e);
            }
        }

        private void btn_subtrair_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtN1.Text); // var numérica
                double b = double.Parse(txtN2.Text);
                lblSinal.Text = "-"; // muda o texto
                lblResultado.Text = (a - b).ToString(); // precisa converter pois é esperado um text
            }
            catch (FormatException)
            {
                MessageBox.Show("Só é permitido números neste campo!");
                button2_Click(sender, e);
            }
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtN1.Text); // var numérica
                double b = double.Parse(txtN2.Text);
                lblSinal.Text = "*"; // muda o texto
                lblResultado.Text = (a * b).ToString(); // precisa converter pois é esperado um text
            }
            catch (FormatException)
            {
                MessageBox.Show("Só é permitido números neste campo!");
                button2_Click(sender, e);
            }
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtN1.Text); // var numérica
                double b = double.Parse(txtN2.Text);
                lblSinal.Text = "/"; // muda o texto
                lblResultado.Text = (a / b).ToString(); // precisa converter pois é esperado um text
            }
            catch (FormatException)
            {
                MessageBox.Show("Só é permitido números neste campo!");
                button2_Click(sender, e);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Não é possivel fazer divisão por zero!");
            }
        }

        private void btnParImpar_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtN1.Text); // var numérica
                double b = double.Parse(txtN2.Text);

                string typeA = (a % 2 == 0) ? "par" : "ímpar";
                string typeB = (b % 2 == 0) ? "par" : "ímpar";
                
                lblSinal.Text = ""; // muda o texto
                lblResul2.Text = $"{a}: {typeA}; {b}: {typeB}.";
                lblResultado.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Só é permitido números neste campo!");
                button2_Click(sender, e);
            }
        }

        private void frmCalculosBot_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtN1.Text); // var numérica
                double b = double.Parse(txtN2.Text);

                if (a > b)
                {
                    lblResul2.Text = $"{a} > {b}";
                } else if (a < b)
                {
                    lblResul2.Text = $"{a} < {b}";
                }
                else
                {
                    lblResul2.Text = $"{a} == {b}";
                }
                
                lblSinal.Text = ""; // muda o texto
                lblResultado.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Só é permitido números neste campo!");
                button2_Click(sender, e);
            }
        }
    }
}
