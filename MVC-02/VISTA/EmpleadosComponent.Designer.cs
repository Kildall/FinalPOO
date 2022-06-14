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
            this.dvgEmpleados = new System.Windows.Forms.DataGridView();
            this.gbxEmpleados = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldoBruto = new System.Windows.Forms.Label();
            this.btnMostarSub = new System.Windows.Forms.Button();
            this.btnAgregarSub = new System.Windows.Forms.Button();
            this.btnEliminarEmpl = new System.Windows.Forms.Button();
            this.btnModificarEmpl = new System.Windows.Forms.Button();
            this.btnAgregarEmpl = new System.Windows.Forms.Button();
            this.txtSaldoEmpl = new System.Windows.Forms.TextBox();
            this.nudEdadEmpl = new System.Windows.Forms.NumericUpDown();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmpleados)).BeginInit();
            this.gbxEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadEmpl)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgEmpleados
            // 
            this.dvgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEmpleados.Location = new System.Drawing.Point(355, 15);
            this.dvgEmpleados.Name = "dvgEmpleados";
            this.dvgEmpleados.Size = new System.Drawing.Size(619, 498);
            this.dvgEmpleados.TabIndex = 2;
            // 
            // gbxEmpleados
            // 
            this.gbxEmpleados.Controls.Add(this.txtSaldo);
            this.gbxEmpleados.Controls.Add(this.lblSaldoBruto);
            this.gbxEmpleados.Controls.Add(this.btnMostarSub);
            this.gbxEmpleados.Controls.Add(this.btnAgregarSub);
            this.gbxEmpleados.Controls.Add(this.btnEliminarEmpl);
            this.gbxEmpleados.Controls.Add(this.btnModificarEmpl);
            this.gbxEmpleados.Controls.Add(this.btnAgregarEmpl);
            this.gbxEmpleados.Controls.Add(this.txtSaldoEmpl);
            this.gbxEmpleados.Controls.Add(this.nudEdadEmpl);
            this.gbxEmpleados.Controls.Add(this.txtNombreCliente);
            this.gbxEmpleados.Controls.Add(this.lblSaldo);
            this.gbxEmpleados.Controls.Add(this.lblEdad);
            this.gbxEmpleados.Controls.Add(this.lblNombre);
            this.gbxEmpleados.Location = new System.Drawing.Point(16, 115);
            this.gbxEmpleados.Name = "gbxEmpleados";
            this.gbxEmpleados.Size = new System.Drawing.Size(321, 296);
            this.gbxEmpleados.TabIndex = 3;
            this.gbxEmpleados.TabStop = false;
            this.gbxEmpleados.Text = "Clientes";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(87, 150);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(148, 20);
            this.txtSaldo.TabIndex = 12;
            // 
            // lblSaldoBruto
            // 
            this.lblSaldoBruto.AutoSize = true;
            this.lblSaldoBruto.Location = new System.Drawing.Point(6, 153);
            this.lblSaldoBruto.Name = "lblSaldoBruto";
            this.lblSaldoBruto.Size = new System.Drawing.Size(61, 13);
            this.lblSaldoBruto.TabIndex = 11;
            this.lblSaldoBruto.Text = "Saldo bruto";
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
            // 
            // btnModificarEmpl
            // 
            this.btnModificarEmpl.Location = new System.Drawing.Point(111, 200);
            this.btnModificarEmpl.Name = "btnModificarEmpl";
            this.btnModificarEmpl.Size = new System.Drawing.Size(93, 38);
            this.btnModificarEmpl.TabIndex = 7;
            this.btnModificarEmpl.Text = "Modificar";
            this.btnModificarEmpl.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEmpl
            // 
            this.btnAgregarEmpl.Location = new System.Drawing.Point(12, 200);
            this.btnAgregarEmpl.Name = "btnAgregarEmpl";
            this.btnAgregarEmpl.Size = new System.Drawing.Size(93, 38);
            this.btnAgregarEmpl.TabIndex = 6;
            this.btnAgregarEmpl.Text = "Agregar";
            this.btnAgregarEmpl.UseVisualStyleBackColor = true;
            // 
            // txtSaldoEmpl
            // 
            this.txtSaldoEmpl.Location = new System.Drawing.Point(87, 110);
            this.txtSaldoEmpl.Name = "txtSaldoEmpl";
            this.txtSaldoEmpl.Size = new System.Drawing.Size(148, 20);
            this.txtSaldoEmpl.TabIndex = 5;
            // 
            // nudEdadEmpl
            // 
            this.nudEdadEmpl.Location = new System.Drawing.Point(87, 71);
            this.nudEdadEmpl.Name = "nudEdadEmpl";
            this.nudEdadEmpl.Size = new System.Drawing.Size(148, 20);
            this.nudEdadEmpl.TabIndex = 4;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(87, 35);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(210, 20);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(18, 117);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(49, 13);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Telefono";
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
            this.Controls.Add(this.dvgEmpleados);
            this.Name = "EmpleadosComponent";
            this.Size = new System.Drawing.Size(990, 529);
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmpleados)).EndInit();
            this.gbxEmpleados.ResumeLayout(false);
            this.gbxEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadEmpl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgEmpleados;
        private System.Windows.Forms.GroupBox gbxEmpleados;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldoBruto;
        private System.Windows.Forms.Button btnMostarSub;
        private System.Windows.Forms.Button btnAgregarSub;
        private System.Windows.Forms.Button btnEliminarEmpl;
        private System.Windows.Forms.Button btnModificarEmpl;
        private System.Windows.Forms.Button btnAgregarEmpl;
        private System.Windows.Forms.TextBox txtSaldoEmpl;
        private System.Windows.Forms.NumericUpDown nudEdadEmpl;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblNombre;
    }
}
