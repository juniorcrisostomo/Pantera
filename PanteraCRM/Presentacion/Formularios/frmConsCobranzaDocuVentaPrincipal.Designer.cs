﻿namespace Presentacion
{ 
    partial class frmConsCobranzaDocuVentaPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsCobranzaDocuVentaPrincipal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtCodDocu = new System.Windows.Forms.TextBox();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipDoc = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPlanilla = new System.Windows.Forms.DataGridView();
            this.CODIPLANILLA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODPLANILLA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHFECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODRECIBO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUIMPORT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHTIPREF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHNUMREF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMone2 = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMone = new System.Windows.Forms.TextBox();
            this.txtCancela = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRazon);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtImporte);
            this.groupBox1.Controls.Add(this.txtMoneda);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.cboTipoDoc);
            this.groupBox1.Controls.Add(this.txtCodDocu);
            this.groupBox1.Controls.Add(this.txtNroDoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTipDoc);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(10, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(767, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtRazon
            // 
            this.txtRazon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtRazon.ForeColor = System.Drawing.Color.Blue;
            this.txtRazon.Location = new System.Drawing.Point(256, 47);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.ReadOnly = true;
            this.txtRazon.Size = new System.Drawing.Size(393, 20);
            this.txtRazon.TabIndex = 14;
            this.txtRazon.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Razón Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Importe";
            // 
            // txtImporte
            // 
            this.txtImporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtImporte.ForeColor = System.Drawing.Color.Blue;
            this.txtImporte.Location = new System.Drawing.Point(587, 23);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(62, 20);
            this.txtImporte.TabIndex = 10;
            this.txtImporte.TabStop = false;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMoneda
            // 
            this.txtMoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtMoneda.ForeColor = System.Drawing.Color.Blue;
            this.txtMoneda.Location = new System.Drawing.Point(550, 23);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.ReadOnly = true;
            this.txtMoneda.Size = new System.Drawing.Size(31, 20);
            this.txtMoneda.TabIndex = 9;
            this.txtMoneda.TabStop = false;
            this.txtMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtFecha.ForeColor = System.Drawing.Color.Blue;
            this.txtFecha.Location = new System.Drawing.Point(363, 23);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(83, 20);
            this.txtFecha.TabIndex = 8;
            this.txtFecha.TabStop = false;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(63, 23);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(58, 21);
            this.cboTipoDoc.TabIndex = 0;
            // 
            // txtCodDocu
            // 
            this.txtCodDocu.Location = new System.Drawing.Point(127, 23);
            this.txtCodDocu.Name = "txtCodDocu";
            this.txtCodDocu.Size = new System.Drawing.Size(110, 20);
            this.txtCodDocu.TabIndex = 1;
            this.txtCodDocu.Enter += new System.EventHandler(this.txtCodDocu_Enter);
            this.txtCodDocu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodDocu_KeyPress);
            this.txtCodDocu.Validated += new System.EventHandler(this.txtCodDocu_Validated);
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtNroDoc.ForeColor = System.Drawing.Color.Blue;
            this.txtNroDoc.Location = new System.Drawing.Point(63, 47);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.ReadOnly = true;
            this.txtNroDoc.Size = new System.Drawing.Size(100, 20);
            this.txtNroDoc.TabIndex = 5;
            this.txtNroDoc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doc. Vta.";
            // 
            // lblTipDoc
            // 
            this.lblTipDoc.AutoSize = true;
            this.lblTipDoc.Location = new System.Drawing.Point(6, 51);
            this.lblTipDoc.Name = "lblTipDoc";
            this.lblTipDoc.Size = new System.Drawing.Size(36, 13);
            this.lblTipDoc.TabIndex = 4;
            this.lblTipDoc.Text = "R.U.C";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnProcesar);
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Location = new System.Drawing.Point(673, 9);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(88, 75);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.SystemColors.Window;
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Location = new System.Drawing.Point(4, 10);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(80, 28);
            this.btnProcesar.TabIndex = 0;
            this.btnProcesar.Text = "&Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(4, 43);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 28);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPlanilla);
            this.groupBox2.Location = new System.Drawing.Point(10, 95);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(767, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvPlanilla
            // 
            this.dgvPlanilla.AllowUserToAddRows = false;
            this.dgvPlanilla.AllowUserToDeleteRows = false;
            this.dgvPlanilla.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIPLANILLA,
            this.CODPLANILLA,
            this.CHFECHA,
            this.CODRECIBO,
            this.NUIMPORT,
            this.CHTIPREF,
            this.CHNUMREF});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlanilla.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPlanilla.Location = new System.Drawing.Point(6, 13);
            this.dgvPlanilla.Name = "dgvPlanilla";
            this.dgvPlanilla.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanilla.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPlanilla.RowHeadersVisible = false;
            this.dgvPlanilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanilla.Size = new System.Drawing.Size(755, 256);
            this.dgvPlanilla.TabIndex = 0;
            // 
            // CODIPLANILLA
            // 
            this.CODIPLANILLA.HeaderText = "CODIPLANILLA";
            this.CODIPLANILLA.Name = "CODIPLANILLA";
            this.CODIPLANILLA.ReadOnly = true;
            this.CODIPLANILLA.Visible = false;
            // 
            // CODPLANILLA
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.CODPLANILLA.DefaultCellStyle = dataGridViewCellStyle2;
            this.CODPLANILLA.HeaderText = "PLANILLA";
            this.CODPLANILLA.Name = "CODPLANILLA";
            this.CODPLANILLA.ReadOnly = true;
            // 
            // CHFECHA
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.CHFECHA.DefaultCellStyle = dataGridViewCellStyle3;
            this.CHFECHA.HeaderText = "FECHA";
            this.CHFECHA.Name = "CHFECHA";
            this.CHFECHA.ReadOnly = true;
            // 
            // CODRECIBO
            // 
            this.CODRECIBO.HeaderText = "RECIBO";
            this.CODRECIBO.Name = "CODRECIBO";
            this.CODRECIBO.ReadOnly = true;
            // 
            // NUIMPORT
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.NUIMPORT.DefaultCellStyle = dataGridViewCellStyle4;
            this.NUIMPORT.HeaderText = "IMPORTE";
            this.NUIMPORT.Name = "NUIMPORT";
            this.NUIMPORT.ReadOnly = true;
            // 
            // CHTIPREF
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(232)))));
            this.CHTIPREF.DefaultCellStyle = dataGridViewCellStyle5;
            this.CHTIPREF.HeaderText = "TIP. REF.";
            this.CHTIPREF.Name = "CHTIPREF";
            this.CHTIPREF.ReadOnly = true;
            this.CHTIPREF.Width = 160;
            // 
            // CHNUMREF
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(232)))));
            this.CHNUMREF.DefaultCellStyle = dataGridViewCellStyle6;
            this.CHNUMREF.HeaderText = "NRO. REF.";
            this.CHNUMREF.Name = "CHNUMREF";
            this.CHNUMREF.ReadOnly = true;
            this.CHNUMREF.Width = 160;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMone2);
            this.groupBox3.Controls.Add(this.txtSaldo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtMone);
            this.groupBox3.Controls.Add(this.txtCancela);
            this.groupBox3.Location = new System.Drawing.Point(10, 369);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(767, 62);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // txtMone2
            // 
            this.txtMone2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtMone2.ForeColor = System.Drawing.Color.Blue;
            this.txtMone2.Location = new System.Drawing.Point(472, 22);
            this.txtMone2.Name = "txtMone2";
            this.txtMone2.ReadOnly = true;
            this.txtMone2.Size = new System.Drawing.Size(30, 20);
            this.txtMone2.TabIndex = 16;
            this.txtMone2.TabStop = false;
            this.txtMone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtSaldo.ForeColor = System.Drawing.Color.Blue;
            this.txtSaldo.Location = new System.Drawing.Point(508, 22);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(101, 20);
            this.txtSaldo.TabIndex = 15;
            this.txtSaldo.TabStop = false;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total Cancelado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Saldo";
            // 
            // txtMone
            // 
            this.txtMone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtMone.ForeColor = System.Drawing.Color.Blue;
            this.txtMone.Location = new System.Drawing.Point(218, 22);
            this.txtMone.Name = "txtMone";
            this.txtMone.ReadOnly = true;
            this.txtMone.Size = new System.Drawing.Size(30, 20);
            this.txtMone.TabIndex = 7;
            this.txtMone.TabStop = false;
            this.txtMone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCancela
            // 
            this.txtCancela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtCancela.ForeColor = System.Drawing.Color.Blue;
            this.txtCancela.Location = new System.Drawing.Point(254, 22);
            this.txtCancela.Name = "txtCancela";
            this.txtCancela.ReadOnly = true;
            this.txtCancela.Size = new System.Drawing.Size(101, 20);
            this.txtCancela.TabIndex = 6;
            this.txtCancela.TabStop = false;
            this.txtCancela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmConsCobranzaDocuVentaPrincipal
            // 
            this.AcceptButton = this.btnProcesar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(789, 442);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsCobranzaDocuVentaPrincipal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CONSULTA DE COBRANZA POR DOCUMENTO DE VENTA";
            this.Load += new System.EventHandler(this.frmConsCobranzaDocuVentaPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipDoc;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.TextBox txtCodDocu;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.DataGridView dgvPlanilla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMone;
        private System.Windows.Forms.TextBox txtCancela;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtMone2;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIPLANILLA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODPLANILLA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHFECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODRECIBO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUIMPORT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHTIPREF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHNUMREF;
    }
}