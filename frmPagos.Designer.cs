﻿namespace PagosPDF
{
    partial class frmPagos
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.lblNombres = new System.Windows.Forms.Label();
            this.cmbNombres = new System.Windows.Forms.ComboBox();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.opcionesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgPagos = new System.Windows.Forms.DataGridView();
            this.checkTodos = new System.Windows.Forms.CheckBox();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(52, 38);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "yyyy/MM/dd";
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(153, 32);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(169, 20);
            this.dtFecha.TabIndex = 1;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(52, 68);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(95, 13);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "Asistente de pago:";
            // 
            // cmbNombres
            // 
            this.cmbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombres.FormattingEnabled = true;
            this.cmbNombres.Location = new System.Drawing.Point(153, 65);
            this.cmbNombres.Name = "cmbNombres";
            this.cmbNombres.Size = new System.Drawing.Size(169, 21);
            this.cmbNombres.TabIndex = 3;
            this.cmbNombres.SelectedIndexChanged += new System.EventHandler(this.cmbNombres_SelectedIndexChanged);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(381, 24);
            this.menuPrincipal.TabIndex = 4;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // opcionesItem
            // 
            this.opcionesItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem1});
            this.opcionesItem.Name = "opcionesItem";
            this.opcionesItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesItem.Text = "Opciones";
            // 
            // configuraciónToolStripMenuItem1
            // 
            this.configuraciónToolStripMenuItem1.Name = "configuraciónToolStripMenuItem1";
            this.configuraciónToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.configuraciónToolStripMenuItem1.Text = "Base de Datos";
            this.configuraciónToolStripMenuItem1.Click += new System.EventHandler(this.configuraciónToolStripMenuItem1_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(159, 290);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgPagos
            // 
            this.dgPagos.AllowUserToAddRows = false;
            this.dgPagos.AllowUserToDeleteRows = false;
            this.dgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPagos.Location = new System.Drawing.Point(18, 124);
            this.dgPagos.Name = "dgPagos";
            this.dgPagos.ReadOnly = true;
            this.dgPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPagos.Size = new System.Drawing.Size(344, 155);
            this.dgPagos.TabIndex = 6;
            // 
            // checkTodos
            // 
            this.checkTodos.AutoSize = true;
            this.checkTodos.Location = new System.Drawing.Point(221, 101);
            this.checkTodos.Name = "checkTodos";
            this.checkTodos.Size = new System.Drawing.Size(141, 17);
            this.checkTodos.TabIndex = 7;
            this.checkTodos.Text = "Generar todos los pagos";
            this.checkTodos.UseVisualStyleBackColor = true;
            this.checkTodos.CheckedChanged += new System.EventHandler(this.checkTodos_CheckedChanged);
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 325);
            this.Controls.Add(this.checkTodos);
            this.Controls.Add(this.dgPagos);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cmbNombres);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.frmPagos_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.ComboBox cmbNombres;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem opcionesItem;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dgPagos;
        private System.Windows.Forms.CheckBox checkTodos;
    }
}

