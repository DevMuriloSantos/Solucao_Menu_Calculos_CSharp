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
        
        double n1 = 0;
        double n2 = 0;
        double result = 0;
        string currentOperation = "";
        bool isNewNumber = true; // controla quando limpar visor
        
        private double Calculate(double a, double b, string op)
        {
            switch (op)
            {
                case "+": return a + b;
                case "-": return a - b;
                case "x": return a * b;
                case "/": return b != 0 ? a / b : 0;
                case "^": return Math.Pow(a, b);
                default: return b;
            }
        }

        private void Botao_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string[] operations = { "+", "-", "x", "/", "^" };

            if (!operations.Contains(btn.Text))
            {
                if (isNewNumber)
                {
                    lblVisor.Text = "";
                    isNewNumber = false;
                }

                lblVisor.Text += btn.Text;
                lblResul.Text += btn.Text;

                return;
            }
            
            // lblResul.Text += btn.Text;
            double currentValue = double.Parse(lblVisor.Text);

            if (!string.IsNullOrEmpty(currentOperation))
            {
                result = Calculate(n1, currentValue, currentOperation);
                lblVisor.Text = result.ToString();
                lblResul.Text = result.ToString();
                n1 = result;
            }
            else
            {
                n1 = currentValue;
            }
            
            currentOperation = btn.Text;
            lblResul.Text += currentOperation;
            isNewNumber = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void singleDisplayPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
