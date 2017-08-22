namespace control_de_dietas
{
    partial class frmCamion
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cantidad_gomas = new System.Windows.Forms.TextBox();
            this.txt_capacidad = new System.Windows.Forms.TextBox();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.txt_IdCamion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvCamion = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuacar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCamion)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Castellar", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(97, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(635, 58);
            this.label5.TabIndex = 25;
            this.label5.Text = "Registro de Camion";
            // 
            // txt_cantidad_gomas
            // 
            this.txt_cantidad_gomas.Location = new System.Drawing.Point(479, 39);
            this.txt_cantidad_gomas.Name = "txt_cantidad_gomas";
            this.txt_cantidad_gomas.Size = new System.Drawing.Size(118, 23);
            this.txt_cantidad_gomas.TabIndex = 24;
            // 
            // txt_capacidad
            // 
            this.txt_capacidad.Location = new System.Drawing.Point(333, 39);
            this.txt_capacidad.Name = "txt_capacidad";
            this.txt_capacidad.Size = new System.Drawing.Size(97, 23);
            this.txt_capacidad.TabIndex = 23;
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(140, 39);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(139, 23);
            this.txt_placa.TabIndex = 22;
            // 
            // txt_IdCamion
            // 
            this.txt_IdCamion.Location = new System.Drawing.Point(126, 152);
            this.txt_IdCamion.Name = "txt_IdCamion";
            this.txt_IdCamion.Size = new System.Drawing.Size(62, 20);
            this.txt_IdCamion.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Capacidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cantidad Gomas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Placa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_placa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_capacidad);
            this.groupBox1.Controls.Add(this.txt_cantidad_gomas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(107, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 80);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Camion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvCamion);
            this.groupBox2.Location = new System.Drawing.Point(107, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 175);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // dtgvCamion
            // 
            this.dtgvCamion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCamion.Location = new System.Drawing.Point(19, 16);
            this.dtgvCamion.Name = "dtgvCamion";
            this.dtgvCamion.Size = new System.Drawing.Size(588, 153);
            this.dtgvCamion.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Controls.Add(this.btnSalir);
            this.groupBox3.Controls.Add(this.btnBuacar);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(107, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(621, 80);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(414, 27);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 34);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar Camion";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(521, 27);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 34);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::control_de_dietas.Properties.Resources.Save_37110;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(6, 23);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(159, 42);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnBuacar
            // 
            this.btnBuacar.Image = global::control_de_dietas.Properties.Resources.seek_search_9539;
            this.btnBuacar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuacar.Location = new System.Drawing.Point(171, 27);
            this.btnBuacar.Name = "btnBuacar";
            this.btnBuacar.Size = new System.Drawing.Size(108, 34);
            this.btnBuacar.TabIndex = 10;
            this.btnBuacar.Text = "Buscar";
            this.btnBuacar.UseVisualStyleBackColor = true;
            this.btnBuacar.Click += new System.EventHandler(this.btnBuacar_Click_1);
            // 
            // frmCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(870, 494);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_IdCamion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmCamion";
            this.Text = "frmCamion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCamion)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cantidad_gomas;
        private System.Windows.Forms.TextBox txt_capacidad;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.TextBox txt_IdCamion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvCamion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuacar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
    }
}