namespace VISTA
{
    partial class frmJerarquia
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
            this.dgvSubordinados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEmpleadosSubordinados = new System.Windows.Forms.ListBox();
            this.btnEliminarSubordinados = new System.Windows.Forms.Button();
            this.btnAgregarSubordinados = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbEmpleadosSuperiores = new System.Windows.Forms.ListBox();
            this.btnEliminarSuperior = new System.Windows.Forms.Button();
            this.btnAgregarSuperior = new System.Windows.Forms.Button();
            this.dgvSuperiores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubordinados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuperiores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubordinados
            // 
            this.dgvSubordinados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubordinados.Location = new System.Drawing.Point(455, 15);
            this.dgvSubordinados.Name = "dgvSubordinados";
            this.dgvSubordinados.Size = new System.Drawing.Size(417, 190);
            this.dgvSubordinados.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbEmpleadosSubordinados);
            this.groupBox1.Controls.Add(this.btnEliminarSubordinados);
            this.groupBox1.Controls.Add(this.dgvSubordinados);
            this.groupBox1.Controls.Add(this.btnAgregarSubordinados);
            this.groupBox1.Location = new System.Drawing.Point(12, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 247);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subordinados";
            // 
            // lbEmpleadosSubordinados
            // 
            this.lbEmpleadosSubordinados.FormattingEnabled = true;
            this.lbEmpleadosSubordinados.Location = new System.Drawing.Point(52, 19);
            this.lbEmpleadosSubordinados.Name = "lbEmpleadosSubordinados";
            this.lbEmpleadosSubordinados.Size = new System.Drawing.Size(294, 186);
            this.lbEmpleadosSubordinados.TabIndex = 5;
            // 
            // btnEliminarSubordinados
            // 
            this.btnEliminarSubordinados.Location = new System.Drawing.Point(615, 218);
            this.btnEliminarSubordinados.Name = "btnEliminarSubordinados";
            this.btnEliminarSubordinados.Size = new System.Drawing.Size(118, 23);
            this.btnEliminarSubordinados.TabIndex = 4;
            this.btnEliminarSubordinados.Text = "Eliminar Subordinado";
            this.btnEliminarSubordinados.UseVisualStyleBackColor = true;
            this.btnEliminarSubordinados.Click += new System.EventHandler(this.btnEliminarSubordinados_Click);
            // 
            // btnAgregarSubordinados
            // 
            this.btnAgregarSubordinados.Location = new System.Drawing.Point(136, 218);
            this.btnAgregarSubordinados.Name = "btnAgregarSubordinados";
            this.btnAgregarSubordinados.Size = new System.Drawing.Size(118, 23);
            this.btnAgregarSubordinados.TabIndex = 3;
            this.btnAgregarSubordinados.Text = "Agregar Subordinado";
            this.btnAgregarSubordinados.UseVisualStyleBackColor = true;
            this.btnAgregarSubordinados.Click += new System.EventHandler(this.btnAgregarSubordinados_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbEmpleadosSuperiores);
            this.groupBox2.Controls.Add(this.btnEliminarSuperior);
            this.groupBox2.Controls.Add(this.btnAgregarSuperior);
            this.groupBox2.Controls.Add(this.dgvSuperiores);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(878, 247);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Superior";
            // 
            // lbEmpleadosSuperiores
            // 
            this.lbEmpleadosSuperiores.FormattingEnabled = true;
            this.lbEmpleadosSuperiores.Location = new System.Drawing.Point(52, 26);
            this.lbEmpleadosSuperiores.Name = "lbEmpleadosSuperiores";
            this.lbEmpleadosSuperiores.Size = new System.Drawing.Size(294, 186);
            this.lbEmpleadosSuperiores.TabIndex = 6;
            // 
            // btnEliminarSuperior
            // 
            this.btnEliminarSuperior.Location = new System.Drawing.Point(615, 218);
            this.btnEliminarSuperior.Name = "btnEliminarSuperior";
            this.btnEliminarSuperior.Size = new System.Drawing.Size(118, 23);
            this.btnEliminarSuperior.TabIndex = 2;
            this.btnEliminarSuperior.Text = "Eliminar Superior";
            this.btnEliminarSuperior.UseVisualStyleBackColor = true;
            this.btnEliminarSuperior.Click += new System.EventHandler(this.btnEliminarSuperior_Click);
            // 
            // btnAgregarSuperior
            // 
            this.btnAgregarSuperior.Location = new System.Drawing.Point(136, 218);
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
            this.dgvSuperiores.Location = new System.Drawing.Point(455, 15);
            this.dgvSuperiores.Name = "dgvSuperiores";
            this.dgvSuperiores.Size = new System.Drawing.Size(417, 197);
            this.dgvSuperiores.TabIndex = 0;
            // 
            // frmJerarquia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 521);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmJerarquia";
            this.Text = "Jerarquia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubordinados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuperiores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubordinados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbEmpleadosSubordinados;
        private System.Windows.Forms.Button btnEliminarSubordinados;
        private System.Windows.Forms.Button btnAgregarSubordinados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbEmpleadosSuperiores;
        private System.Windows.Forms.Button btnEliminarSuperior;
        private System.Windows.Forms.Button btnAgregarSuperior;
        private System.Windows.Forms.DataGridView dgvSuperiores;
    }
}