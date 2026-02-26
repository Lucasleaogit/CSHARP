namespace CalculadoraSoftware
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
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnApaga = new System.Windows.Forms.Button();
            this.buttonvirg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxtDisplay.Location = new System.Drawing.Point(12, 12);
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ReadOnly = true;
            this.TxtDisplay.Size = new System.Drawing.Size(196, 32);
            this.TxtDisplay.TabIndex = 0;
            this.TxtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(13, 87);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(44, 35);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Numero_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(63, 87);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(44, 35);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Numero_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(113, 87);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(44, 35);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(63, 129);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 35);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(114, 129);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 35);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Numero_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 170);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(44, 35);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Numero_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(114, 170);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(44, 35);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Numero_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(63, 170);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(44, 35);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Numero_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(13, 210);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(44, 35);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Numero_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(164, 211);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(44, 32);
            this.btnIgual.TabIndex = 11;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(164, 50);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(44, 35);
            this.btnMenos.TabIndex = 12;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.Operador_Click);
            // 
            // btnMais
            // 
            this.btnMais.Location = new System.Drawing.Point(164, 88);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(44, 34);
            this.btnMais.TabIndex = 13;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.Operador_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(164, 129);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(44, 35);
            this.btnMult.TabIndex = 14;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.Operador_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(164, 170);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(44, 35);
            this.btnDiv.TabIndex = 15;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.Operador_Click);
            // 
            // btnApaga
            // 
            this.btnApaga.Location = new System.Drawing.Point(13, 49);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(44, 32);
            this.btnApaga.TabIndex = 16;
            this.btnApaga.Text = "C";
            this.btnApaga.UseVisualStyleBackColor = true;
            this.btnApaga.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // buttonvirg
            // 
            this.buttonvirg.Location = new System.Drawing.Point(63, 210);
            this.buttonvirg.Name = "buttonvirg";
            this.buttonvirg.Size = new System.Drawing.Size(44, 35);
            this.buttonvirg.TabIndex = 17;
            this.buttonvirg.Text = ",";
            this.buttonvirg.UseVisualStyleBackColor = true;
            this.buttonvirg.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 257);
            this.Controls.Add(this.buttonvirg);
            this.Controls.Add(this.btnApaga);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.TxtDisplay);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnApaga;
        private System.Windows.Forms.Button buttonvirg;
    }
}

