namespace Menu_Calculos
{
    partial class CALCULOS
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
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.sinal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txt_min_n1 = new System.Windows.Forms.TextBox();
            this.txt_min_n2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sinal
            // 
            this.sinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinal.Location = new System.Drawing.Point(135, 130);
            this.sinal.Name = "sinal";
            this.sinal.Size = new System.Drawing.Size(43, 37);
            this.sinal.TabIndex = 0;
            this.sinal.Text = "?";
            this.sinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sinal.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "___________________________";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // resultado
            // 
            this.resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(211, 227);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(100, 43);
            this.resultado.TabIndex = 3;
            this.resultado.Text = "?";
            this.resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(67, 286);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 32);
            this.btnSomar.TabIndex = 5;
            this.btnSomar.Text = "&Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnnLimpar
            // 
            this.btnnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnLimpar.Location = new System.Drawing.Point(226, 286);
            this.btnnLimpar.Name = "btnnLimpar";
            this.btnnLimpar.Size = new System.Drawing.Size(75, 32);
            this.btnnLimpar.TabIndex = 6;
            this.btnnLimpar.Text = "&Limpar";
            this.btnnLimpar.UseVisualStyleBackColor = true;
            this.btnnLimpar.Click += new System.EventHandler(this.btnnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(387, 286);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 32);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txt_min_n1
            // 
            this.txt_min_n1.Location = new System.Drawing.Point(211, 73);
            this.txt_min_n1.Name = "txt_min_n1";
            this.txt_min_n1.Size = new System.Drawing.Size(100, 20);
            this.txt_min_n1.TabIndex = 8;
            this.txt_min_n1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_min_n2
            // 
            this.txt_min_n2.Location = new System.Drawing.Point(211, 147);
            this.txt_min_n2.Name = "txt_min_n2";
            this.txt_min_n2.Size = new System.Drawing.Size(100, 20);
            this.txt_min_n2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(211, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(211, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CALCULOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(535, 380);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_min_n2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_min_n1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnnLimpar);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sinal);
            this.Name = "CALCULOS";
            this.Text = "DogMello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txt_min_n1;
        private System.Windows.Forms.TextBox txt_min_n2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

