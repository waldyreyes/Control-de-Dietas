namespace control_de_dietas
{
    partial class frmBusquedaDietas
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rbtnFecha = new System.Windows.Forms.RadioButton();
            this.rbtnDestino = new System.Windows.Forms.RadioButton();
            this.rbtnAyudante = new System.Windows.Forms.RadioButton();
            this.rbtnChofer = new System.Windows.Forms.RadioButton();
            this.txtChofer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAyudante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCamion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.grpDetallesFaltantes = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.txtIdDestino = new System.Windows.Forms.TextBox();
            this.txtTotalGastado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.lblChofer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grbChoferMasViajado = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpDetallesFaltantes.SuspendLayout();
            this.grbChoferMasViajado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(561, 34);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(18, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 239);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 196);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(752, 35);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(658, 35);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 9;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(480, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rbtnFecha
            // 
            this.rbtnFecha.AutoSize = true;
            this.rbtnFecha.Location = new System.Drawing.Point(18, 34);
            this.rbtnFecha.Name = "rbtnFecha";
            this.rbtnFecha.Size = new System.Drawing.Size(55, 17);
            this.rbtnFecha.TabIndex = 18;
            this.rbtnFecha.TabStop = true;
            this.rbtnFecha.Text = "Fecha";
            this.rbtnFecha.UseVisualStyleBackColor = true;
            this.rbtnFecha.CheckedChanged += new System.EventHandler(this.rbtnFecha_CheckedChanged);
            this.rbtnFecha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtnChofer_MouseClick);
            // 
            // rbtnDestino
            // 
            this.rbtnDestino.AutoSize = true;
            this.rbtnDestino.Location = new System.Drawing.Point(142, 62);
            this.rbtnDestino.Name = "rbtnDestino";
            this.rbtnDestino.Size = new System.Drawing.Size(61, 17);
            this.rbtnDestino.TabIndex = 19;
            this.rbtnDestino.TabStop = true;
            this.rbtnDestino.Text = "Destino";
            this.rbtnDestino.UseVisualStyleBackColor = true;
            this.rbtnDestino.CheckedChanged += new System.EventHandler(this.rbtnDestino_CheckedChanged);
            this.rbtnDestino.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtnChofer_MouseClick);
            // 
            // rbtnAyudante
            // 
            this.rbtnAyudante.AutoSize = true;
            this.rbtnAyudante.Location = new System.Drawing.Point(18, 62);
            this.rbtnAyudante.Name = "rbtnAyudante";
            this.rbtnAyudante.Size = new System.Drawing.Size(118, 17);
            this.rbtnAyudante.TabIndex = 20;
            this.rbtnAyudante.TabStop = true;
            this.rbtnAyudante.Text = "Ayudante mas Viajó";
            this.rbtnAyudante.UseVisualStyleBackColor = true;
            this.rbtnAyudante.CheckedChanged += new System.EventHandler(this.rbtnAyudante_CheckedChanged);
            this.rbtnAyudante.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtnChofer_MouseClick);
            // 
            // rbtnChofer
            // 
            this.rbtnChofer.AutoSize = true;
            this.rbtnChofer.Location = new System.Drawing.Point(99, 34);
            this.rbtnChofer.Name = "rbtnChofer";
            this.rbtnChofer.Size = new System.Drawing.Size(104, 17);
            this.rbtnChofer.TabIndex = 21;
            this.rbtnChofer.TabStop = true;
            this.rbtnChofer.Text = "Chofer mas Viajó";
            this.rbtnChofer.UseVisualStyleBackColor = true;
            this.rbtnChofer.CheckedChanged += new System.EventHandler(this.rbtnChofer_CheckedChanged);
            this.rbtnChofer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbtnChofer_MouseClick);
            // 
            // txtChofer
            // 
            this.txtChofer.Location = new System.Drawing.Point(17, 50);
            this.txtChofer.Name = "txtChofer";
            this.txtChofer.Size = new System.Drawing.Size(151, 25);
            this.txtChofer.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(56, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chofer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(237, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ayudante";
            // 
            // txtAyudante
            // 
            this.txtAyudante.Location = new System.Drawing.Point(194, 50);
            this.txtAyudante.Name = "txtAyudante";
            this.txtAyudante.Size = new System.Drawing.Size(157, 25);
            this.txtAyudante.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(403, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Placa de Camión";
            // 
            // txtCamion
            // 
            this.txtCamion.Location = new System.Drawing.Point(378, 50);
            this.txtCamion.Name = "txtCamion";
            this.txtCamion.Size = new System.Drawing.Size(194, 25);
            this.txtCamion.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(631, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ruta o Destino";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(598, 50);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(194, 25);
            this.txtRuta.TabIndex = 11;
            // 
            // grpDetallesFaltantes
            // 
            this.grpDetallesFaltantes.Controls.Add(this.label4);
            this.grpDetallesFaltantes.Controls.Add(this.label1);
            this.grpDetallesFaltantes.Controls.Add(this.txtChofer);
            this.grpDetallesFaltantes.Controls.Add(this.txtRuta);
            this.grpDetallesFaltantes.Controls.Add(this.txtAyudante);
            this.grpDetallesFaltantes.Controls.Add(this.label2);
            this.grpDetallesFaltantes.Controls.Add(this.label3);
            this.grpDetallesFaltantes.Controls.Add(this.txtCamion);
            this.grpDetallesFaltantes.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetallesFaltantes.ForeColor = System.Drawing.Color.Blue;
            this.grpDetallesFaltantes.Location = new System.Drawing.Point(18, 356);
            this.grpDetallesFaltantes.Name = "grpDetallesFaltantes";
            this.grpDetallesFaltantes.Size = new System.Drawing.Size(805, 87);
            this.grpDetallesFaltantes.TabIndex = 22;
            this.grpDetallesFaltantes.TabStop = false;
            this.grpDetallesFaltantes.Text = "Detalles Faltantes";
            this.grpDetallesFaltantes.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Desde";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Hasta";
            // 
            // cmbDestino
            // 
            this.cmbDestino.Enabled = false;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(212, 64);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbDestino.TabIndex = 27;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged);
            this.cmbDestino.TextChanged += new System.EventHandler(this.cmbDestino_TextChanged);
            // 
            // txtIdDestino
            // 
            this.txtIdDestino.Location = new System.Drawing.Point(353, 65);
            this.txtIdDestino.Name = "txtIdDestino";
            this.txtIdDestino.ReadOnly = true;
            this.txtIdDestino.Size = new System.Drawing.Size(40, 20);
            this.txtIdDestino.TabIndex = 28;
            // 
            // txtTotalGastado
            // 
            this.txtTotalGastado.Location = new System.Drawing.Point(52, 489);
            this.txtTotalGastado.Name = "txtTotalGastado";
            this.txtTotalGastado.Size = new System.Drawing.Size(151, 20);
            this.txtTotalGastado.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(74, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Total Gastado";
            // 
            // cmbDesde
            // 
            this.cmbDesde.Enabled = false;
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(212, 33);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(121, 21);
            this.cmbDesde.TabIndex = 35;
            this.cmbDesde.SelectedIndexChanged += new System.EventHandler(this.cmbDesde_SelectedIndexChanged);
            this.cmbDesde.TextChanged += new System.EventHandler(this.cmbDesde_TextChanged);
            // 
            // cmbHasta
            // 
            this.cmbHasta.Enabled = false;
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(339, 34);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(121, 21);
            this.cmbHasta.TabIndex = 36;
            this.cmbHasta.TextChanged += new System.EventHandler(this.cmbHasta_TextChanged);
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChofer.ForeColor = System.Drawing.Color.Blue;
            this.lblChofer.Location = new System.Drawing.Point(26, 21);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(208, 16);
            this.lblChofer.TabIndex = 37;
            this.lblChofer.Text = "Chofer que más ha viajado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 38;
            // 
            // grbChoferMasViajado
            // 
            this.grbChoferMasViajado.Controls.Add(this.textBox1);
            this.grbChoferMasViajado.Controls.Add(this.lblChofer);
            this.grbChoferMasViajado.Location = new System.Drawing.Point(324, 458);
            this.grbChoferMasViajado.Name = "grbChoferMasViajado";
            this.grbChoferMasViajado.Size = new System.Drawing.Size(266, 91);
            this.grbChoferMasViajado.TabIndex = 39;
            this.grbChoferMasViajado.TabStop = false;
            // 
            // frmBusquedaDietas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 580);
            this.Controls.Add(this.grbChoferMasViajado);
            this.Controls.Add(this.cmbHasta);
            this.Controls.Add(this.cmbDesde);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalGastado);
            this.Controls.Add(this.txtIdDestino);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpDetallesFaltantes);
            this.Controls.Add(this.rbtnChofer);
            this.Controls.Add(this.rbtnAyudante);
            this.Controls.Add(this.rbtnDestino);
            this.Controls.Add(this.rbtnFecha);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmBusquedaDietas";
            this.Text = "frmBusquedaDietas";
            this.Load += new System.EventHandler(this.frmBusquedaDietas_Load);
            this.Click += new System.EventHandler(this.frmBusquedaDietas_Click);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpDetallesFaltantes.ResumeLayout(false);
            this.grpDetallesFaltantes.PerformLayout();
            this.grbChoferMasViajado.ResumeLayout(false);
            this.grbChoferMasViajado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rbtnFecha;
        private System.Windows.Forms.RadioButton rbtnDestino;
        private System.Windows.Forms.RadioButton rbtnAyudante;
        private System.Windows.Forms.RadioButton rbtnChofer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCamion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAyudante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChofer;
        private System.Windows.Forms.GroupBox grpDetallesFaltantes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.TextBox txtIdDestino;
        private System.Windows.Forms.TextBox txtTotalGastado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDesde;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grbChoferMasViajado;
    }
}