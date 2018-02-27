﻿namespace Presentacion
{ 
    partial class frmManProveedoresPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManProveedoresPrincipal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.dgvListadoProveedores = new System.Windows.Forms.DataGridView();
            this.IDPROV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHRAZON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPODOCU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRODOCU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHDIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHTIPOCLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHTELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnadir);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnVer);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(104, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 54);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.SystemColors.Window;
            this.btnAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.Location = new System.Drawing.Point(8, 17);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(80, 28);
            this.btnAnadir.TabIndex = 8;
            this.btnAnadir.Text = "&Añadir";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.Window;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(278, 17);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 28);
            this.btnImprimir.TabIndex = 13;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Window;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(98, 17);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 28);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.SystemColors.Window;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(188, 17);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(80, 28);
            this.btnVer.TabIndex = 10;
            this.btnVer.Text = "&Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(368, 17);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 28);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtParametro);
            this.groupBox2.Location = new System.Drawing.Point(12, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 43);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Búsqueda";
            // 
            // txtParametro
            // 
            this.txtParametro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParametro.Location = new System.Drawing.Point(67, 15);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(574, 20);
            this.txtParametro.TabIndex = 0;
            // 
            // dgvListadoProveedores
            // 
            this.dgvListadoProveedores.AllowUserToAddRows = false;
            this.dgvListadoProveedores.AllowUserToDeleteRows = false;
            this.dgvListadoProveedores.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPROV,
            this.CHRAZON,
            this.TIPODOCU,
            this.NRODOCU,
            this.CHDIRECCION,
            this.CHTIPOCLIENTE,
            this.CHTELEFONO});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoProveedores.Location = new System.Drawing.Point(12, 51);
            this.dgvListadoProveedores.Name = "dgvListadoProveedores";
            this.dgvListadoProveedores.ReadOnly = true;
            this.dgvListadoProveedores.Size = new System.Drawing.Size(647, 343);
            this.dgvListadoProveedores.TabIndex = 19;
            // 
            // IDPROV
            // 
            this.IDPROV.DataPropertyName = "p_inidcodigoclie";
            this.IDPROV.HeaderText = "CODIGO";
            this.IDPROV.Name = "IDPROV";
            this.IDPROV.ReadOnly = true;
            this.IDPROV.Width = 60;
            // 
            // CHRAZON
            // 
            this.CHRAZON.DataPropertyName = "razon";
            this.CHRAZON.HeaderText = "RAZON SOCIAL";
            this.CHRAZON.Name = "CHRAZON";
            this.CHRAZON.ReadOnly = true;
            this.CHRAZON.Width = 270;
            // 
            // TIPODOCU
            // 
            this.TIPODOCU.DataPropertyName = "tipodocu";
            this.TIPODOCU.HeaderText = "TIPO DOCUMENTO";
            this.TIPODOCU.Name = "TIPODOCU";
            this.TIPODOCU.ReadOnly = true;
            // 
            // NRODOCU
            // 
            this.NRODOCU.DataPropertyName = "nrodocumento";
            this.NRODOCU.HeaderText = "N° DOCUMENTO";
            this.NRODOCU.Name = "NRODOCU";
            this.NRODOCU.ReadOnly = true;
            this.NRODOCU.Width = 80;
            // 
            // CHDIRECCION
            // 
            this.CHDIRECCION.DataPropertyName = "chdireccion";
            this.CHDIRECCION.HeaderText = "DIRECCION";
            this.CHDIRECCION.Name = "CHDIRECCION";
            this.CHDIRECCION.ReadOnly = true;
            this.CHDIRECCION.Width = 200;
            // 
            // CHTIPOCLIENTE
            // 
            this.CHTIPOCLIENTE.DataPropertyName = "tipoclie";
            this.CHTIPOCLIENTE.HeaderText = "ACTIVIDAD ECONOMICA";
            this.CHTIPOCLIENTE.Name = "CHTIPOCLIENTE";
            this.CHTIPOCLIENTE.ReadOnly = true;
            this.CHTIPOCLIENTE.Width = 150;
            // 
            // CHTELEFONO
            // 
            this.CHTELEFONO.DataPropertyName = "telefono";
            this.CHTELEFONO.HeaderText = "TELEFONO";
            this.CHTELEFONO.Name = "CHTELEFONO";
            this.CHTELEFONO.ReadOnly = true;
            this.CHTELEFONO.Width = 80;
            // 
            // frmManProveedoresPrincipal
            // 
            this.AcceptButton = this.btnAnadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(671, 465);
            this.Controls.Add(this.dgvListadoProveedores);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManProveedoresPrincipal";
            this.Text = "MANTENIMIENTO DE PROVEEDORES";
            this.Load += new System.EventHandler(this.frmManProveedoresPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.DataGridView dgvListadoProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPROV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHRAZON;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPODOCU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRODOCU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHDIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHTIPOCLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHTELEFONO;
    }
}