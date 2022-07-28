namespace VISTA
{
    partial class JerarquiaComponent
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbEmpleadosSubordinados = new System.Windows.Forms.ListBox();
            this.btnEliminarSuperior = new System.Windows.Forms.Button();
            this.btnAgregarSuperior = new System.Windows.Forms.Button();
            this.dgvSuperiores = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEmpleados = new System.Windows.Forms.ListBox();
            this.btnEliminarSubordinado = new System.Windows.Forms.Button();
            this.btnAgregarSubordinado = new System.Windows.Forms.Button();
            this.dgvSubordinados = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuperiores)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubordinados)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.lbEmpleadosSubordinados);
            this.groupBox2.Controls.Add(this.btnEliminarSuperior);
            this.groupBox2.Controls.Add(this.btnAgregarSuperior);
            this.groupBox2.Controls.Add(this.dgvSuperiores);
            this.groupBox2.Location = new System.Drawing.Point(375, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 244);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Superior";
            // 
            // lbEmpleadosSubordinados
            // 
            this.lbEmpleadosSubordinados.FormattingEnabled = true;
            this.lbEmpleadosSubordinados.Location = new System.Drawing.Point(54, 19);
            this.lbEmpleadosSubordinados.Name = "lbEmpleadosSubordinados";
            this.lbEmpleadosSubordinados.Size = new System.Drawing.Size(118, 186);
            this.lbEmpleadosSubordinados.TabIndex = 6;
            // 
            // btnEliminarSuperior
            // 
            this.btnEliminarSuperior.Location = new System.Drawing.Point(310, 211);
            this.btnEliminarSuperior.Name = "btnEliminarSuperior";
            this.btnEliminarSuperior.Size = new System.Drawing.Size(118, 23);
            this.btnEliminarSuperior.TabIndex = 2;
            this.btnEliminarSuperior.Text = "Eliminar Superior";
            this.btnEliminarSuperior.UseVisualStyleBackColor = true;
            this.btnEliminarSuperior.Click += new System.EventHandler(this.btnEliminarSuperior_Click);
            // 
            // btnAgregarSuperior
            // 
            this.btnAgregarSuperior.Location = new System.Drawing.Point(54, 211);
            this.btnAgregarSuperior.Name = "btnAgregarSuperior";
            this.btnAgregarSuperior.Size = new System.Drawing.Size(118, 23);
            this.btnAgregarSuperior.TabIndex = 1;
            this.btnAgregarSuperior.Text = "Agregar Superior";
            this.btnAgregarSuperior.UseVisualStyleBackColor = true;
            this.btnAgregarSuperior.Click += new System.EventHandler(this.btnAgregarSuperior_Click);
            // 
            // dgvSuperiores
            // 
            this.dgvSuperiores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuperiores.Location = new System.Drawing.Point(178, 19);
            this.dgvSuperiores.Name = "dgvSuperiores";
            this.dgvSuperiores.Size = new System.Drawing.Size(383, 186);
            this.dgvSuperiores.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lbEmpleados);
            this.groupBox1.Controls.Add(this.btnEliminarSubordinado);
            this.groupBox1.Controls.Add(this.btnAgregarSubordinado);
            this.groupBox1.Controls.Add(this.dgvSubordinados);
            this.groupBox1.Location = new System.Drawing.Point(375, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 244);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subordinados";
            // 
            // lbEmpleados
            // 
            this.lbEmpleados.FormattingEnabled = true;
            this.lbEmpleados.Location = new System.Drawing.Point(54, 19);
            this.lbEmpleados.Name = "lbEmpleados";
            this.lbEmpleados.Size = new System.Drawing.Size(118, 186);
            this.lbEmpleados.TabIndex = 6;
            // 
            // btnEliminarSubordinado
            // 
            this.btnEliminarSubordinado.Location = new System.Drawing.Point(310, 211);
            this.btnEliminarSubordinado.Name = "btnEliminarSubordinado";
            this.btnEliminarSubordinado.Size = new System.Drawing.Size(118, 23);
            this.btnEliminarSubordinado.TabIndex = 2;
            this.btnEliminarSubordinado.Text = "EliminarSubordinado";
            this.btnEliminarSubordinado.UseVisualStyleBackColor = true;
            this.btnEliminarSubordinado.Click += new System.EventHandler(this.btnEliminarSubordinado_Click);
            // 
            // btnAgregarSubordinado
            // 
            this.btnAgregarSubordinado.Location = new System.Drawing.Point(54, 211);
            this.btnAgregarSubordinado.Name = "btnAgregarSubordinado";
            this.btnAgregarSubordinado.Size = new System.Drawing.Size(118, 23);
            this.btnAgregarSubordinado.TabIndex = 1;
            this.btnAgregarSubordinado.Text = "Agregar Subordinado";
            this.btnAgregarSubordinado.UseVisualStyleBackColor = true;
            this.btnAgregarSubordinado.Click += new System.EventHandler(this.btnAgregarSubordinado_Click);
            // 
            // dgvSubordinados
            // 
            this.dgvSubordinados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubordinados.Location = new System.Drawing.Point(178, 19);
            this.dgvSubordinados.Name = "dgvSubordinados";
            this.dgvSubordinados.Size = new System.Drawing.Size(383, 186);
            this.dgvSubordinados.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl1);
            this.groupBox3.Controls.Add(this.dgvEmpleados);
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 505);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Empleados";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 28);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(277, 13);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "*Haga clic en un empleado para modificar sus relaciones.";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(6, 61);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(344, 434);
            this.dgvEmpleados.TabIndex = 7;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
            // 
            // JerarquiaComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "JerarquiaComponent";
            this.Size = new System.Drawing.Size(990, 529);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.JerarquiaComponent_Paint);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuperiores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubordinados)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbEmpleadosSubordinados;
        private System.Windows.Forms.Button btnEliminarSuperior;
        private System.Windows.Forms.Button btnAgregarSuperior;
        private System.Windows.Forms.DataGridView dgvSuperiores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbEmpleados;
        private System.Windows.Forms.Button btnEliminarSubordinado;
        private System.Windows.Forms.Button btnAgregarSubordinado;
        private System.Windows.Forms.DataGridView dgvSubordinados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label lbl1;
    }
}
