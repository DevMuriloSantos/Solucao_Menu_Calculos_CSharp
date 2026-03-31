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
            this.KeyPreview = true;
        }
        
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            singleDisplayPanel.Left = (this.ClientSize.Width - singleDisplayPanel.Width) / 2;
            singleDisplayPanel.Top = (this.ClientSize.Height - singleDisplayPanel.Height) / 2;
        } // centraliza os componentes
        
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.ActiveControl = null;
        }
        
        double n1 = 0;
        double result = 0;
        string currentOperation = "";
        bool isNewNumber = true; // controla quando limpar visor

        public void MessageError(string msg)
        {
            MessageBox.Show(msg, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        
        double Calculate(double a, double b, string op)
        {
            switch (op)
            {
                case "+": return a + b;
                case "-": return a - b;
                case "x": return a * b;
                case "/":
                    if (b == 0)
                    {
                        MessageError("Não é possível fazer divisão por zero!");
                        return 0;
                    }
                    return a / b;
                case "^": return Math.Pow(a, b);
                default: return b;
            }
        }

        private void Botao_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            Button btn = (Button)sender;
            string[] operations = { "+", "-", "x", "/", "^" };
            double currentValue = double.Parse(lblVisor.Text);

            switch (btn.Text)
            {
                case "CE":
                    lblVisor.Text = "0";
                    isNewNumber = true;
                    return;
                
                case "C":
                    lblVisor.Text = "0";
                    lblResul.Text = "";
                    n1 = 0;
                    result = 0;

                    currentOperation = "";
                    isNewNumber = true;
                    return;
                
                case "<=":
                    if (lblVisor.Text == "0") return;
                    else if (lblVisor.Text.Length == 1)
                    {
                        lblVisor.Text = "0";
                        if (!operations.Contains(
                                lblResul.Text.Substring
                                    (lblResul.Text.Length - 1, 1)))
                        {
                            lblResul.Text = lblResul.Text.Substring(0, lblResul.Text.Length - 1);
                        }
                        isNewNumber = true;
                        return;
                    } else if (operations.Contains(lblResul.Text.Substring
                                   (lblResul.Text.Length - 1, 1)))
                    {
                        lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
                        return;
                    }
                
                    lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
                    lblResul.Text = lblResul.Text.Substring(0, lblResul.Text.Length - 1);
                    return;
                
                case "=":
                    if (currentOperation.Trim() == "")
                    {
                        MessageError("(Error) - Selecione uma operação para fazer o calculo!");
                    }
                    
                    result = Calculate(n1, currentValue, currentOperation);
                    lblVisor.Text = result.ToString();
                    lblResul.Text = result.ToString();

                    n1 = result;
                    currentOperation = "";
                    isNewNumber = true;
                    return;
                
                case ",":
                    if (!lblVisor.Text.Contains(","))
                    {
                        lblVisor.Text += ",";
                        if (lblResul.Text.Length == 0) lblResul.Text = "0";
                            
                        lblResul.Text += ",";

                        isNewNumber = false;
                    }

                    return;
            }
            

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

        private void frmCalculadoraVisorUnico_KeyDown(object sender, KeyEventArgs e)
        {
            Button btn = new Button();
            // MessageBox.Show(e.KeyCode.ToString());

            switch (e.KeyCode.ToString())
            {
                case "Back":
                    btn.Text = "<=";
                    Botao_Click(btn, EventArgs.Empty);
                    return;
            }
            
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                int numero = e.KeyCode - Keys.NumPad0;
                btn.Text = numero.ToString();

                Botao_Click(btn, EventArgs.Empty);
            } else if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                int numero = e.KeyCode - Keys.D0;
                btn.Text = numero.ToString();

                Botao_Click(btn, EventArgs.Empty);
            }
        }
        private void singleDisplayPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
