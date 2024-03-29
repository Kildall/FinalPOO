﻿namespace VISTA
{
    partial class EmpleadosComponent
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.gbxEmpleados = new System.Windows.Forms.GroupBox();
            this.nudSalarioEmp = new System.Windows.Forms.NumericUpDown();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.nudEdadEmp = new System.Windows.Forms.NumericUpDown();
            this.txtNombreEmp = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.gbxEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalarioEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEmpleados.Location = new System.Drawing.Point(355, 15);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ShowCellErrors = false;
            this.dgvEmpleados.ShowCellToolTips = false;
            this.dgvEmpleados.ShowEditingIcon = false;
            this.dgvEmpleados.ShowRowErrors = false;
            this.dgvEmpleados.Size = new System.Drawing.Size(619, 498);
            this.dgvEmpleados.TabIndex = 2;
            this.dgvEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellDoubleClick);
            this.dgvEmpleados.SelectionChanged += new System.EventHandler(this.dgvEmpleados_SelectionChanged);
            // 
            // gbxEmpleados
            // 
            this.gbxEmpleados.Controls.Add(this.nudSalarioEmp);
            this.gbxEmpleados.Controls.Add(this.cbxCategoria);
            this.gbxEmpleados.Controls.Add(this.lblCategoria);
            this.gbxEmpleados.Controls.Add(this.btnEliminarEmpleado);
            this.gbxEmpleados.Controls.Add(this.btnModificarEmpleado);
            this.gbxEmpleados.Controls.Add(this.btnAgregarEmpleado);
            this.gbxEmpleados.Controls.Add(this.nudEdadEmp);
            this.gbxEmpleados.Controls.Add(this.txtNombreEmp);
            this.gbxEmpleados.Controls.Add(this.lblSalario);
            this.gbxEmpleados.Controls.Add(this.lblEdad);
            this.gbxEmpleados.Controls.Add(this.lblNombre);
            this.gbxEmpleados.Location = new System.Drawing.Point(16, 115);
            this.gbxEmpleados.Name = "gbxEmpleados";
            this.gbxEmpleados.Size = new System.Drawing.Size(321, 262);
            this.gbxEmpleados.TabIndex = 3;
            this.gbxEmpleados.TabStop = false;
            this.gbxEmpleados.Text = "Empleados";
            // 
            // nudSalarioEmp
            // 
            this.nudSalarioEmp.Location = new System.Drawing.Point(87, 110);
            this.nudSalarioEmp.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSalarioEmp.Name = "nudSalarioEmp";
            this.nudSalarioEmp.Size = new System.Drawing.Size(148, 20);
            this.nudSalarioEmp.TabIndex = 14;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(87, 149);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(148, 21);
            this.cbxCategoria.TabIndex = 12;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(15, 152);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 11;
            this.lblCategoria.Text = "Categoria";
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(210, 200);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(93, 38);
            this.btnEliminarEmpleado.TabIndex = 8;
            this.btnEliminarEmpleado.Text = "Eliminar";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpl_Click);
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.Location = new System.Drawing.Point(111, 200);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(93, 38);
            this.btnModificarEmpleado.TabIndex = 7;
            this.btnModificarEmpleado.Text = "Modificar";
            this.btnModificarEmpleado.UseVisualStyleBackColor = true;
            this.btnModificarEmpleado.Click += new System.EventHandler(this.btnModificarEmpl_Click);
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(12, 200);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(93, 38);
            this.btnAgregarEmpleado.TabIndex = 6;
            this.btnAgregarEmpleado.Text = "Agregar";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpl_Click);
            // 
            // nudEdadEmp
            // 
            this.nudEdadEmp.Location = new System.Drawing.Point(87, 76);
            this.nudEdadEmp.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudEdadEmp.Name = "nudEdadEmp";
            this.nudEdadEmp.Size = new System.Drawing.Size(148, 20);
            this.nudEdadEmp.TabIndex = 4;
            // 
            // txtNombreEmp
            // 
            this.txtNombreEmp.Location = new System.Drawing.Point(87, 39);
            this.txtNombreEmp.Name = "txtNombreEmp";
            this.txtNombreEmp.Size = new System.Drawing.Size(210, 20);
            this.txtNombreEmp.TabIndex = 3;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(28, 117);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salario";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(35, 78);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 1;
            this.lblEdad.Text = "Edad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // EmpleadosComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxEmpleados);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "EmpleadosComponent";
            this.Size = new System.Drawing.Size(990, 529);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EmpleadosComponent_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.gbxEmpleados.ResumeLayout(false);
            this.gbxEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalarioEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.GroupBox gbxEmpleados;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnModificarEmpleado;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.NumericUpDown nudEdadEmp;
        private System.Windows.Forms.TextBox txtNombreEmp;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.NumericUpDown nudSalarioEmp;
    }
}
