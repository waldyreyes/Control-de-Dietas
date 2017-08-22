namespace control_de_dietas
{
    partial class frmPrincipal
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
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCamion = new System.Windows.Forms.Button();
            this.btnRuta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Location = new System.Drawing.Point(278, 131);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(199, 56);
            this.btnEmpleado.TabIndex = 0;
            this.btnEmpleado.Text = "Busqueda Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(393, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Busqueda Dietas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCamion
            // 
            this.btnCamion.Location = new System.Drawing.Point(278, 211);
            this.btnCamion.Name = "btnCamion";
            this.btnCamion.Size = new System.Drawing.Size(415, 57);
            this.btnCamion.TabIndex = 2;
            this.btnCamion.Text = "Registrar Camión";
            this.btnCamion.UseVisualStyleBackColor = true;
            this.btnCamion.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(278, 291);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(199, 55);
            this.btnRuta.TabIndex = 3;
            this.btnRuta.Text = "Busqueda Rutas";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Crear Empleado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(494, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 55);
            this.button3.TabIndex = 5;
            this.button3.Text = "Crear Rutas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(788, 27);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 36);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(900, 427);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.btnCamion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCamion;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnSalir;
    }
}