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
            double a = double.Parse(txtN1.Text); // var numérica
            double b = double.Parse(txtN2.Text);
            lblSinal.Text = "+"; // muda o texto
            lblResultado.Text = (a + b).ToString(); // precisa converter pois é esperado um text
        }
    }
}
