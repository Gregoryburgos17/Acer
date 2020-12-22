namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pantalla = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.btnigu = new System.Windows.Forms.Button();
            this.btnce = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pantalla
            // 
            this.pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantalla.Location = new System.Drawing.Point(12, 50);
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.Size = new System.Drawing.Size(234, 31);
            this.pantalla.TabIndex = 0;
            this.pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 179);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(42, 38);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(60, 179);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(42, 38);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(108, 179);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(42, 38);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 135);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(42, 38);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(60, 135);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(42, 38);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(108, 135);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(42, 38);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 93);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(42, 38);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(60, 93);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(42, 38);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(108, 92);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(42, 38);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(12, 221);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(138, 38);
            this.btn10.TabIndex = 10;
            this.btn10.Text = "0";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btnsuma
            // 
            this.btnsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuma.Location = new System.Drawing.Point(204, 93);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(42, 38);
            this.btnsuma.TabIndex = 11;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btndiv
            // 
            this.btndiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.Location = new System.Drawing.Point(156, 177);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(42, 38);
            this.btndiv.TabIndex = 12;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnpunto
            // 
            this.btnpunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpunto.Location = new System.Drawing.Point(156, 221);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(42, 38);
            this.btnpunto.TabIndex = 13;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = true;
            this.btnpunto.Click += new System.EventHandler(this.btnpunto_Click);
            // 
            // btnmul
            // 
            this.btnmul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmul.Location = new System.Drawing.Point(204, 135);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(42, 38);
            this.btnmul.TabIndex = 14;
            this.btnmul.Text = "X";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btnmenos
            // 
            this.btnmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenos.Location = new System.Drawing.Point(156, 134);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(42, 38);
            this.btnmenos.TabIndex = 15;
            this.btnmenos.Text = "-";
            this.btnmenos.UseVisualStyleBackColor = true;
            this.btnmenos.Click += new System.EventHandler(this.btnmenos_Click);
            // 
            // btnigu
            // 
            this.btnigu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigu.Location = new System.Drawing.Point(204, 181);
            this.btnigu.Name = "btnigu";
            this.btnigu.Size = new System.Drawing.Size(42, 78);
            this.btnigu.TabIndex = 16;
            this.btnigu.Text = "=";
            this.btnigu.UseVisualStyleBackColor = true;
            this.btnigu.Click += new System.EventHandler(this.btnigu_Click);
            // 
            // btnce
            // 
            this.btnce.Location = new System.Drawing.Point(156, 92);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(42, 38);
            this.btnce.TabIndex = 17;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = true;
            this.btnce.Click += new System.EventHandler(this.btnce_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "CALCULADORA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnce);
            this.Controls.Add(this.btnigu);
            this.Controls.Add(this.btnmenos);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.pantalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnpunto;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Button btnigu;
        private System.Windows.Forms.Button btnce;
        private System.Windows.Forms.Label label1;
    }
}

