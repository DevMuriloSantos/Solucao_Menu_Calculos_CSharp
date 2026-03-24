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
    public partial class frmVisorUnico : Form
    {
        public frmVisorUnico()
        {
            InitializeComponent();
        }
        
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            singleDisplayPanel.Left = (this.ClientSize.Width - singleDisplayPanel.Width) / 2;
            singleDisplayPanel.Top = (this.ClientSize.Height - singleDisplayPanel.Height) / 2;
        } // centraliza os componentes

        private void Botao_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int operationCount = 0;
            int result = 0;
            string[] operations = new string [5]
            {
                "+",
                "-",
                "x",
                "/",
                "^"
            };

            if (!operations.Contains(btn.Text))
            {
                lblVisor.Text += btn.Text;
                lblResul.Text += btn.Text;
                return;
            }

            do
            {
                lblResul.Text += btn.Text;
            } while (true);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }
    }
}
