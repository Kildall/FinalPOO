namespace VISTA
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
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnMostarSub = new System.Windows.Forms.Button();
            this.btnAgregarSub = new System.Windows.Forms.Button();
            this.btnEliminarEmpl = new System.Windows.Forms.Button();
            this.btnModificarEmpl = new System.Windows.Forms.Button();
            this.btnAgregarEmpl = new System.Windows.Forms.Button();
            this.txtSalarioEmp = new System.Windows.Forms.TextBox();
            this.nudEdadEmp = new System.Windows.Forms.NumericUpDown();
            this.txtNombreEmp = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.gbxEmpleados.SuspendLayout();
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
            this.gbxEmpleados.Controls.Add(this.cbxCategoria);
            this.gbxEmpleados.Controls.Add(this.lblCategoria);
            this.gbxEmpleados.Controls.Add(this.btnMostarSub);
            this.gbxEmpleados.Controls.Add(this.btnAgregarSub);
            this.gbxEmpleados.Controls.Add(this.btnEliminarEmpl);
            this.gbxEmpleados.Controls.Add(this.btnModificarEmpl);
            this.gbxEmpleados.Controls.Add(this.btnAgregarEmpl);
            this.gbxEmpleados.Controls.Add(this.txtSalarioEmp);
            this.gbxEmpleados.Controls.Add(this.nudEdadEmp);
            this.gbxEmpleados.Controls.Add(this.txtNombreEmp);
            this.gbxEmpleados.Controls.Add(this.lblSalario);
            this.gbxEmpleados.Controls.Add(this.lblEdad);
            this.gbxEmpleados.Controls.Add(this.lblNombre);
            this.gbxEmpleados.Location = new System.Drawing.Point(16, 115);
            this.gbxEmpleados.Name = "gbxEmpleados";
            this.gbxEmpleados.Size = new System.Drawing.Size(321, 296);
            this.gbxEmpleados.TabIndex = 3;
            this.gbxEmpleados.TabStop = false;
            this.gbxEmpleados.Text = "Empleados";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(87, 144);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(148, 21);
            this.cbxCategoria.TabIndex = 12;
            this.cbxCategoria.SelectionChangeCommitted += new System.EventHandler(this.cbxCategoria_SelectionChangeCommitted);
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
            // btnMostarSub
            // 
            this.btnMostarSub.Location = new System.Drawing.Point(162, 241);
            this.btnMostarSub.Name = "btnMostarSub";
            this.btnMostarSub.Size = new System.Drawing.Size(93, 38);
            this.btnMostarSub.TabIndex = 10;
            this.btnMostarSub.Text = "Mostar Subordinados";
            this.btnMostarSub.UseVisualStyleBackColor = true;
            // 
            // btnAgregarSub
            // 
            this.btnAgregarSub.Location = new System.Drawing.Point(63, 241);
            this.btnAgregarSub.Name = "btnAgregarSub";
            this.btnAgregarSub.Size = new System.Drawing.Size(93, 38);
            this.btnAgregarSub.TabIndex = 9;
            this.btnAgregarSub.Text = "Agregar Subordinados";
            this.btnAgregarSub.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEmpl
            // 
            this.btnEliminarEmpl.Location = new System.Drawing.Point(210, 200);
            this.btnEliminarEmpl.Name = "btnEliminarEmpl";
            this.btnEliminarEmpl.Size = new System.Drawing.Size(93, 38);
            this.btnEliminarEmpl.TabIndex = 8;
            this.btnEliminarEmpl.Text = "Eliminar";
            this.btnEliminarEmpl.UseVisualStyleBackColor = true;
            this.btnEliminarEmpl.Click += new System.EventHandler(this.btnEliminarEmpl_Click);
            // 
            // btnModificarEmpl
            // 
            this.btnModificarEmpl.Location = new System.Drawing.Point(111, 200);
            this.btnModificarEmpl.Name = "btnModificarEmpl";
            this.btnModificarEmpl.Size = new System.Drawing.Size(93, 38);
            this.btnModificarEmpl.TabIndex = 7;
            this.btnModificarEmpl.Text = "Modificar";
            this.btnModificarEmpl.UseVisualStyleBackColor = true;
            this.btnModificarEmpl.Click += new System.EventHandler(this.btnModificarEmpl_Click);
            // 
            // btnAgregarEmpl
            // 
            this.btnAgregarEmpl.Location = new System.Drawing.Point(12, 200);
            this.btnAgregarEmpl.Name = "btnAgregarEmpl";
            this.btnAgregarEmpl.Size = new System.Drawing.Size(93, 38);
            this.btnAgregarEmpl.TabIndex = 6;
            this.btnAgregarEmpl.Text = "Agregar";
            this.btnAgregarEmpl.UseVisualStyleBackColor = true;
            this.btnAgregarEmpl.Click += new System.EventHandler(this.btnAgregarEmpl_Click);
            // 
            // txtSalarioEmp
            // 
            this.txtSalarioEmp.Location = new System.Drawing.Point(87, 110);
            this.txtSalarioEmp.Name = "txtSalarioEmp";
            this.txtSalarioEmp.Size = new System.Drawing.Size(148, 20);
            this.txtSalarioEmp.TabIndex = 5;
            // 
            // nudEdadEmp
            // 
            this.nudEdadEmp.Location = new System.Drawing.Point(87, 71);
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
            this.txtNombreEmp.Location = new System.Drawing.Point(87, 35);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.gbxEmpleados.ResumeLayout(false);
            this.gbxEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.GroupBox gbxEmpleados;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnMostarSub;
        private System.Windows.Forms.Button btnAgregarSub;
        private System.Windows.Forms.Button btnEliminarEmpl;
        private System.Windows.Forms.Button btnModificarEmpl;
        private System.Windows.Forms.Button btnAgregarEmpl;
        private System.Windows.Forms.TextBox txtSalarioEmp;
        private System.Windows.Forms.NumericUpDown nudEdadEmp;
        private System.Windows.Forms.TextBox txtNombreEmp;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cbxCategoria;
    }
}
