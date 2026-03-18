namespace Menu_Calculos.Formularios
{
    partial class frmRadio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxRb = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioCalculatorPanel = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSinal = new System.Windows.Forms.Label();
            this.textBoxN2 = new System.Windows.Forms.TextBox();
            this.textBoxN1 = new System.Windows.Forms.TextBox();
            this.groupBoxRb.SuspendLayout();
            this.radioCalculatorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRb
            // 
            this.groupBoxRb.Controls.Add(this.radioButton5);
            this.groupBoxRb.Controls.Add(this.radioButton4);
            this.groupBoxRb.Controls.Add(this.radioButton3);
            this.groupBoxRb.Controls.Add(this.radioButton2);
            this.groupBoxRb.Controls.Add(this.radioButton1);
            this.groupBoxRb.Location = new System.Drawing.Point(32, 36);
            this.groupBoxRb.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxRb.Name = "groupBoxRb";
            this.groupBoxRb.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxRb.Size = new System.Drawing.Size(133, 151);
            this.groupBoxRb.TabIndex = 1;
            this.groupBoxRb.TabStop = false;
            this.groupBoxRb.Text = "Operações";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(22, 112);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Tag = "^";
            this.radioButton5.Text = "Potenciação";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(22, 93);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(54, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Tag = "/";
            this.radioButton4.Text = "Dividir";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(22, 73);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Tag = "*";
            this.radioButton3.Text = "Multiplicar";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 54);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Tag = "-";
            this.radioButton2.Text = "Subtrair";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 34);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "+";
            this.radioButton1.Text = "Somar";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioCalculatorPanel
            // 
            this.radioCalculatorPanel.Controls.Add(this.btnFechar);
            this.radioCalculatorPanel.Controls.Add(this.btnLimpar);
            this.radioCalculatorPanel.Controls.Add(this.btnCalcular);
            this.radioCalculatorPanel.Controls.Add(this.lblResultado);
            this.radioCalculatorPanel.Controls.Add(this.label2);
            this.radioCalculatorPanel.Controls.Add(this.lblSinal);
            this.radioCalculatorPanel.Controls.Add(this.textBoxN2);
            this.radioCalculatorPanel.Controls.Add(this.textBoxN1);
            this.radioCalculatorPanel.Controls.Add(this.groupBoxRb);
            this.radioCalculatorPanel.Location = new System.Drawing.Point(1, -2);
            this.radioCalculatorPanel.Name = "radioCalculatorPanel";
            this.radioCalculatorPanel.Size = new System.Drawing.Size(556, 320);
            this.radioCalculatorPanel.TabIndex = 2;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(427, 264);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(97, 40);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(233, 264);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 40);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(32, 264);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(97, 40);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Location = new System.Drawing.Point(329, 150);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(100, 23);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "?";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(291, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "_____________________________________________________________";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSinal
            // 
            this.lblSinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSinal.Location = new System.Drawing.Point(300, 101);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(23, 23);
            this.lblSinal.TabIndex = 4;
            this.lblSinal.Text = "?";
            this.lblSinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxN2
            // 
            this.textBoxN2.Location = new System.Drawing.Point(329, 104);
            this.textBoxN2.Name = "textBoxN2";
            this.textBoxN2.Size = new System.Drawing.Size(100, 20);
            this.textBoxN2.TabIndex = 3;
            // 
            // textBoxN1
            // 
            this.textBoxN1.Location = new System.Drawing.Point(329, 65);
            this.textBoxN1.Name = "textBoxN1";
            this.textBoxN1.Size = new System.Drawing.Size(100, 20);
            this.textBoxN1.TabIndex = 2;
            // 
            // frmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(543, 348);
            this.Controls.Add(this.radioCalculatorPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRadio";
            this.Text = "Cálculos com RadioButton";
            this.groupBoxRb.ResumeLayout(false);
            this.groupBoxRb.PerformLayout();
            this.radioCalculatorPanel.ResumeLayout(false);
            this.radioCalculatorPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel radioCalculatorPanel;
        private System.Windows.Forms.TextBox textBoxN1;
        private System.Windows.Forms.TextBox textBoxN2;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRb;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}