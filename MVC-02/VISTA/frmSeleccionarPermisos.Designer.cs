
namespace VISTA
{
    partial class frmSeleccionarPermisos
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
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFormularios = new System.Windows.Forms.ComboBox();
            this.lbPermisosSeleccionados = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnDeseleccionar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Location = new System.Drawing.Point(321, 105);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.Size = new System.Drawing.Size(383, 333);
            this.dgvPermisos.TabIndex = 0;
            this.dgvPermisos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermisos_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbFormularios);
            this.groupBox1.Location = new System.Drawing.Point(412, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por Formulario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formulario";
            // 
            // cbFormularios
            // 
            this.cbFormularios.FormattingEnabled = true;
            this.cbFormularios.Location = new System.Drawing.Point(70, 35);
            this.cbFormularios.Name = "cbFormularios";
            this.cbFormularios.Size = new System.Drawing.Size(121, 21);
            this.cbFormularios.TabIndex = 0;
            this.cbFormularios.SelectionChangeCommitted += new System.EventHandler(this.cbFormularios_SelectionChangeCommitted);
            // 
            // lbPermisosSeleccionados
            // 
            this.lbPermisosSeleccionados.FormattingEnabled = true;
            this.lbPermisosSeleccionados.Location = new System.Drawing.Point(12, 103);
            this.lbPermisosSeleccionados.Name = "lbPermisosSeleccionados";
            this.lbPermisosSeleccionados.Size = new System.Drawing.Size(149, 329);
            this.lbPermisosSeleccionados.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Permisos Seleccionados";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(167, 189);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(148, 28);
            this.btnSeleccionar.TabIndex = 4;
            this.btnSeleccionar.Text = "<- Seleccionar Permiso-";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnDeseleccionar
            // 
            this.btnDeseleccionar.Location = new System.Drawing.Point(167, 310);
            this.btnDeseleccionar.Name = "btnDeseleccionar";
            this.btnDeseleccionar.Size = new System.Drawing.Size(148, 28);
            this.btnDeseleccionar.TabIndex = 5;
            this.btnDeseleccionar.Text = "-Deseleccionar Permiso ->";
            this.btnDeseleccionar.UseVisualStyleBackColor = true;
            this.btnDeseleccionar.Click += new System.EventHandler(this.btnDeseleccionar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(279, 453);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(155, 37);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Finalizar";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmSeleccionarPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 502);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnDeseleccionar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPermisosSeleccionados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPermisos);
            this.Name = "frmSeleccionarPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Permisos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFormularios;
        private System.Windows.Forms.ListBox lbPermisosSeleccionados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnDeseleccionar;
        private System.Windows.Forms.Button btnVolver;
    }
}