namespace VISTA
{
    partial class ClientesComponent
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
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.txtTelCliente = new System.Windows.Forms.TextBox();
            this.nudEdadCliente = new System.Windows.Forms.NumericUpDown();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dvgClientes = new System.Windows.Forms.DataGridView();
            this.gbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.btnEliminarCliente);
            this.gbClientes.Controls.Add(this.btnModificarCliente);
            this.gbClientes.Controls.Add(this.btnAgregarCliente);
            this.gbClientes.Controls.Add(this.txtTelCliente);
            this.gbClientes.Controls.Add(this.nudEdadCliente);
            this.gbClientes.Controls.Add(this.txtNombreCliente);
            this.gbClientes.Controls.Add(this.lblTelefono);
            this.gbClientes.Controls.Add(this.lblEdad);
            this.gbClientes.Controls.Add(this.lblNombre);
            this.gbClientes.Location = new System.Drawing.Point(15, 146);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(321, 212);
            this.gbClientes.TabIndex = 0;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "Clientes";
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(211, 166);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(93, 38);
            this.btnEliminarCliente.TabIndex = 8;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(112, 166);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(93, 38);
            this.btnModificarCliente.TabIndex = 7;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(13, 166);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(93, 38);
            this.btnAgregarCliente.TabIndex = 6;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // txtTelCliente
            // 
            this.txtTelCliente.Location = new System.Drawing.Point(57, 117);
            this.txtTelCliente.Name = "txtTelCliente";
            this.txtTelCliente.Size = new System.Drawing.Size(148, 20);
            this.txtTelCliente.TabIndex = 5;
            // 
            // nudEdadCliente
            // 
            this.nudEdadCliente.Location = new System.Drawing.Point(57, 76);
            this.nudEdadCliente.Name = "nudEdadCliente";
            this.nudEdadCliente.Size = new System.Drawing.Size(148, 20);
            this.nudEdadCliente.TabIndex = 4;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(57, 35);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(247, 20);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(2, 125);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(19, 83);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 1;
            this.lblEdad.Text = "Edad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // dvgClientes
            // 
            this.dvgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgClientes.Location = new System.Drawing.Point(355, 15);
            this.dvgClientes.Name = "dvgClientes";
            this.dvgClientes.Size = new System.Drawing.Size(619, 498);
            this.dvgClientes.TabIndex = 1;
            this.dvgClientes.SelectionChanged += new System.EventHandler(this.dvgClientes_SelectionChanged);
            // 
            // ClientesComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dvgClientes);
            this.Controls.Add(this.gbClientes);
            this.Name = "ClientesComponent";
            this.Size = new System.Drawing.Size(990, 529);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ClientesComponent_Paint);
            this.gbClientes.ResumeLayout(false);
            this.gbClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.NumericUpDown nudEdadCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtTelCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.DataGridView dvgClientes;
    }
}
