namespace Menu_Calculos
{
    partial class frmCalculosBot
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculosBot));
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.lblSinal = new System.Windows.Forms.Label();
            this.lblResul2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnLimparTexto = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btn_subtrair = new System.Windows.Forms.Button();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.btnComparar = new System.Windows.Forms.Button();
            this.btnParImpar = new System.Windows.Forms.Button();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.calculatorPanel = new System.Windows.Forms.Panel();
            this.calculatorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtN2
            // 
            this.txtN2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN2.Location = new System.Drawing.Point(526, 212);
            this.txtN2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(148, 30);
            this.txtN2.TabIndex = 1;
            this.txtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtN2.TextChanged += new System.EventHandler(this.txtN2_TextChanged);
            // 
            // lblSinal
            // 
            this.lblSinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinal.Location = new System.Drawing.Point(324, 152);
            this.lblSinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(38, 48);
            this.lblSinal.TabIndex = 2;
            this.lblSinal.Text = "?";
            this.lblSinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResul2
            // 
            this.lblResul2.AutoSize = true;
            this.lblResul2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResul2.Location = new System.Drawing.Point(471, 271);
            this.lblResul2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResul2.Name = "lblResul2";
            this.lblResul2.Size = new System.Drawing.Size(252, 25);
            this.lblResul2.TabIndex = 3;
            this.lblResul2.Text = "____________________";
            this.lblResul2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResul2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(524, 323);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(149, 34);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "?";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Image = ((System.Drawing.Image)(resources.GetObject("btnSomar.Image")));
            this.btnSomar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSomar.Location = new System.Drawing.Point(898, 94);
            this.btnSomar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(146, 62);
            this.btnSomar.TabIndex = 5;
            this.btnSomar.Text = "&Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnLimparTexto
            // 
            this.btnLimparTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparTexto.Location = new System.Drawing.Point(75, 588);
            this.btnLimparTexto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimparTexto.Name = "btnLimparTexto";
            this.btnLimparTexto.Size = new System.Drawing.Size(112, 54);
            this.btnLimparTexto.TabIndex = 6;
            this.btnLimparTexto.Text = "&Limpar";
            this.btnLimparTexto.UseVisualStyleBackColor = true;
            this.btnLimparTexto.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(1006, 588);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(112, 54);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFecharTetxo_Click);
            // 
            // btn_subtrair
            // 
            this.btn_subtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subtrair.Location = new System.Drawing.Point(898, 165);
            this.btn_subtrair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_subtrair.Name = "btn_subtrair";
            this.btn_subtrair.Size = new System.Drawing.Size(146, 62);
            this.btn_subtrair.TabIndex = 8;
            this.btn_subtrair.Text = "Sub&trair";
            this.btn_subtrair.UseVisualStyleBackColor = true;
            this.btn_subtrair.Click += new System.EventHandler(this.btn_subtrair_Click);
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplicar.Location = new System.Drawing.Point(898, 235);
            this.btn_multiplicar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(146, 62);
            this.btn_multiplicar.TabIndex = 9;
            this.btn_multiplicar.Text = "&Multiplicar";
            this.btn_multiplicar.UseVisualStyleBackColor = true;
            this.btn_multiplicar.Click += new System.EventHandler(this.btn_multiplicar_Click);
            // 
            // btn_dividir
            // 
            this.btn_dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dividir.Location = new System.Drawing.Point(898, 306);
            this.btn_dividir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(146, 62);
            this.btn_dividir.TabIndex = 10;
            this.btn_dividir.Text = "&Dividir";
            this.btn_dividir.UseVisualStyleBackColor = true;
            this.btn_dividir.Click += new System.EventHandler(this.btn_dividir_Click);
            // 
            // btnComparar
            // 
            this.btnComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar.Location = new System.Drawing.Point(324, 383);
            this.btnComparar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(146, 62);
            this.btnComparar.TabIndex = 11;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // btnParImpar
            // 
            this.btnParImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParImpar.Location = new System.Drawing.Point(742, 383);
            this.btnParImpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParImpar.Name = "btnParImpar";
            this.btnParImpar.Size = new System.Drawing.Size(146, 62);
            this.btnParImpar.TabIndex = 12;
            this.btnParImpar.Text = "Par Ímpar";
            this.btnParImpar.UseVisualStyleBackColor = true;
            this.btnParImpar.Click += new System.EventHandler(this.btnParImpar_Click);
            // 
            // txtN1
            // 
            this.txtN1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtN1.Location = new System.Drawing.Point(524, 122);
            this.txtN1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(148, 30);
            this.txtN1.TabIndex = 0;
            this.txtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculatorPanel
            // 
            this.calculatorPanel.Controls.Add(this.txtN1);
            this.calculatorPanel.Controls.Add(this.lblSinal);
            this.calculatorPanel.Controls.Add(this.btnFechar);
            this.calculatorPanel.Controls.Add(this.btn_dividir);
            this.calculatorPanel.Controls.Add(this.btnLimparTexto);
            this.calculatorPanel.Controls.Add(this.btnParImpar);
            this.calculatorPanel.Controls.Add(this.btn_multiplicar);
            this.calculatorPanel.Controls.Add(this.txtN2);
            this.calculatorPanel.Controls.Add(this.btn_subtrair);
            this.calculatorPanel.Controls.Add(this.btnComparar);
            this.calculatorPanel.Controls.Add(this.lblResul2);
            this.calculatorPanel.Controls.Add(this.lblResultado);
            this.calculatorPanel.Controls.Add(this.btnSomar);
            this.calculatorPanel.Location = new System.Drawing.Point(-2, 0);
            this.calculatorPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculatorPanel.Name = "calculatorPanel";
            this.calculatorPanel.Size = new System.Drawing.Size(1164, 686);
            this.calculatorPanel.TabIndex = 13;
            this.calculatorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmCalculosBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1194, 655);
            this.Controls.Add(this.calculatorPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCalculosBot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculos com botões";
            this.Load += new System.EventHandler(this.frmCalculosBot_Load);
            this.calculatorPanel.ResumeLayout(false);
            this.calculatorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel calculatorPanel;

        private System.Windows.Forms.TextBox txtN1;

        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.Button btnComparar;

        private System.Windows.Forms.Button btnParImpar;

        private System.Windows.Forms.Button btn_subtrair;
        private System.Windows.Forms.Button btn_multiplicar;

        #endregion

        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.Label lblResul2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnLimparTexto;
        private System.Windows.Forms.Button btnFechar;
    }
}

