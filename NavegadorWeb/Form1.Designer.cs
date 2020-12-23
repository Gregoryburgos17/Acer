namespace NavegadorWeb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnatras = new System.Windows.Forms.Button();
            this.btnir = new System.Windows.Forms.Button();
            this.btnfavorito = new System.Windows.Forms.Button();
            this.cmbfavorito = new System.Windows.Forms.ComboBox();
            this.txtdirecion = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.txtdirecion);
            this.panel1.Controls.Add(this.cmbfavorito);
            this.panel1.Controls.Add(this.btnfavorito);
            this.panel1.Controls.Add(this.btnir);
            this.panel1.Controls.Add(this.btnatras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 67);
            this.panel1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 67);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(725, 303);
            this.webBrowser1.TabIndex = 1;
            // 
            // btnatras
            // 
            this.btnatras.Location = new System.Drawing.Point(12, 12);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(58, 49);
            this.btnatras.TabIndex = 0;
            this.btnatras.Text = "Atras";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // btnir
            // 
            this.btnir.Location = new System.Drawing.Point(493, 12);
            this.btnir.Name = "btnir";
            this.btnir.Size = new System.Drawing.Size(56, 49);
            this.btnir.TabIndex = 1;
            this.btnir.Text = "Ir";
            this.btnir.UseVisualStyleBackColor = true;
            this.btnir.Click += new System.EventHandler(this.btnir_Click);
            // 
            // btnfavorito
            // 
            this.btnfavorito.Location = new System.Drawing.Point(592, 12);
            this.btnfavorito.Name = "btnfavorito";
            this.btnfavorito.Size = new System.Drawing.Size(121, 21);
            this.btnfavorito.TabIndex = 2;
            this.btnfavorito.Text = "Favoritos";
            this.btnfavorito.UseVisualStyleBackColor = true;
            this.btnfavorito.Click += new System.EventHandler(this.btnfavorito_Click);
            // 
            // cmbfavorito
            // 
            this.cmbfavorito.FormattingEnabled = true;
            this.cmbfavorito.Location = new System.Drawing.Point(592, 40);
            this.cmbfavorito.Name = "cmbfavorito";
            this.cmbfavorito.Size = new System.Drawing.Size(121, 21);
            this.cmbfavorito.TabIndex = 3;
            this.cmbfavorito.SelectedIndexChanged += new System.EventHandler(this.cmbfavorito_SelectedIndexChanged);
            // 
            // txtdirecion
            // 
            this.txtdirecion.Location = new System.Drawing.Point(89, 27);
            this.txtdirecion.Name = "txtdirecion";
            this.txtdirecion.Size = new System.Drawing.Size(398, 20);
            this.txtdirecion.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 370);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NavegarRD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtdirecion;
        private System.Windows.Forms.ComboBox cmbfavorito;
        private System.Windows.Forms.Button btnfavorito;
        private System.Windows.Forms.Button btnir;
        private System.Windows.Forms.Button btnatras;
    }
}

