namespace Ex1
{
    partial class Form1
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
            this.valor1 = new System.Windows.Forms.TextBox();
            this.enunciado = new System.Windows.Forms.Label();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.baze = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.valor3 = new System.Windows.Forms.TextBox();
            this.lado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // valor1
            // 
            this.valor1.Location = new System.Drawing.Point(221, 203);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(151, 20);
            this.valor1.TabIndex = 0;
            this.valor1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // enunciado
            // 
            this.enunciado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enunciado.AutoSize = true;
            this.enunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enunciado.Location = new System.Drawing.Point(452, 67);
            this.enunciado.Name = "enunciado";
            this.enunciado.Size = new System.Drawing.Size(16, 24);
            this.enunciado.TabIndex = 1;
            this.enunciado.Text = ".";
            this.enunciado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.enunciado.Click += new System.EventHandler(this.label1_Click);
            // 
            // valor2
            // 
            this.valor2.Location = new System.Drawing.Point(803, 198);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(141, 20);
            this.valor2.TabIndex = 2;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(522, 481);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(16, 24);
            this.resultado.TabIndex = 3;
            this.resultado.Text = ".";
            this.resultado.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(511, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // baze
            // 
            this.baze.AutoSize = true;
            this.baze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baze.Location = new System.Drawing.Point(264, 168);
            this.baze.Name = "baze";
            this.baze.Size = new System.Drawing.Size(50, 20);
            this.baze.TabIndex = 5;
            this.baze.Text = "Base";
            this.baze.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altura.Location = new System.Drawing.Point(841, 164);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(57, 20);
            this.altura.TabIndex = 7;
            this.altura.Text = "Altura";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(25, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // valor3
            // 
            this.valor3.Location = new System.Drawing.Point(511, 203);
            this.valor3.Name = "valor3";
            this.valor3.Size = new System.Drawing.Size(136, 20);
            this.valor3.TabIndex = 10;
            // 
            // lado
            // 
            this.lado.AutoSize = true;
            this.lado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lado.Location = new System.Drawing.Point(559, 169);
            this.lado.Name = "lado";
            this.lado.Size = new System.Drawing.Size(15, 24);
            this.lado.TabIndex = 11;
            this.lado.Text = ".";
            this.lado.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 623);
            this.Controls.Add(this.lado);
            this.Controls.Add(this.valor3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.baze);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.enunciado);
            this.Controls.Add(this.valor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valor1;
        private System.Windows.Forms.Label enunciado;
        private System.Windows.Forms.TextBox valor2;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label baze;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox valor3;
        private System.Windows.Forms.Label lado;
    }
}

