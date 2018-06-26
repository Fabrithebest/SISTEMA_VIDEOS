namespace SISTEMA_VIDEOS
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
            this.button2 = new System.Windows.Forms.Button();
            this.lblWrongUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.rdbcon = new System.Windows.Forms.RadioButton();
            this.rdbSin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(249, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 24);
            this.button2.TabIndex = 14;
            this.button2.Text = "Siguiente";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lblWrongUser
            // 
            this.lblWrongUser.AutoSize = true;
            this.lblWrongUser.BackColor = System.Drawing.Color.Transparent;
            this.lblWrongUser.Location = new System.Drawing.Point(102, 130);
            this.lblWrongUser.Name = "lblWrongUser";
            this.lblWrongUser.Size = new System.Drawing.Size(35, 13);
            this.lblWrongUser.TabIndex = 12;
            this.lblWrongUser.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(74, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(73, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Iniciar Sesión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(74, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuario:";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(143, 107);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(100, 20);
            this.txtContra.TabIndex = 6;
            // 
            // txtUsu
            // 
            this.txtUsu.Location = new System.Drawing.Point(143, 107);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(100, 20);
            this.txtUsu.TabIndex = 7;
            // 
            // rdbcon
            // 
            this.rdbcon.AutoSize = true;
            this.rdbcon.BackColor = System.Drawing.Color.Transparent;
            this.rdbcon.Location = new System.Drawing.Point(76, 255);
            this.rdbcon.Name = "rdbcon";
            this.rdbcon.Size = new System.Drawing.Size(61, 17);
            this.rdbcon.TabIndex = 17;
            this.rdbcon.TabStop = true;
            this.rdbcon.Text = "Internet";
            this.rdbcon.UseVisualStyleBackColor = false;
            // 
            // rdbSin
            // 
            this.rdbSin.AutoSize = true;
            this.rdbSin.BackColor = System.Drawing.Color.Transparent;
            this.rdbSin.Location = new System.Drawing.Point(273, 255);
            this.rdbSin.Name = "rdbSin";
            this.rdbSin.Size = new System.Drawing.Size(79, 17);
            this.rdbSin.TabIndex = 16;
            this.rdbSin.TabStop = true;
            this.rdbSin.Text = "Sin Internet";
            this.rdbSin.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(397, 293);
            this.Controls.Add(this.rdbSin);
            this.Controls.Add(this.rdbcon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblWrongUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblWrongUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.RadioButton rdbcon;
        private System.Windows.Forms.RadioButton rdbSin;
    }
}

