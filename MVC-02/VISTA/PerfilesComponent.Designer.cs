
namespace VISTA
{
    partial class PerfilesComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPerfil = new System.Windows.Forms.GroupBox();
            this.btnAgregarPerfil = new System.Windows.Forms.Button();
            this.btnEliminarPermiso = new System.Windows.Forms.Button();
            this.btnAgregarPermiso = new System.Windows.Forms.Button();
            this.btnEliminarFormulario = new System.Windows.Forms.Button();
            this.btnAgregarFormulario = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPermisos = new System.Windows.Forms.ListBox();
            this.lbFormularios = new System.Windows.Forms.ListBox();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.dgvPerfiles = new System.Windows.Forms.DataGridView();
            this.btnCrearPerfil = new System.Windows.Forms.Button();
            this.gbPerfil.SuspendLayout();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPerfil
            // 
            this.gbPerfil.Controls.Add(this.btnAgregarPerfil);
            this.gbPerfil.Controls.Add(this.btnEliminarPermiso);
            this.gbPerfil.Controls.Add(this.btnAgregarPermiso);
            this.gbPerfil.Controls.Add(this.btnEliminarFormulario);
            this.gbPerfil.Controls.Add(this.btnAgregarFormulario);
            this.gbPerfil.Controls.Add(this.label6);
            this.gbPerfil.Controls.Add(this.label5);
            this.gbPerfil.Controls.Add(this.lbPermisos);
            this.gbPerfil.Controls.Add(this.lbFormularios);
            this.gbPerfil.Controls.Add(this.cbEmpresa);
            this.gbPerfil.Controls.Add(this.label4);
            this.gbPerfil.Controls.Add(this.label3);
            this.gbPerfil.Controls.Add(this.tbNombre);
            this.gbPerfil.Location = new System.Drawing.Point(3, 36);
            this.gbPerfil.Name = "gbPerfil";
            this.gbPerfil.Size = new System.Drawing.Size(408, 484);
            this.gbPerfil.TabIndex = 0;
            this.gbPerfil.TabStop = false;
            this.gbPerfil.Text = "Agregar Perfil";
            // 
            // btnAgregarPerfil
            // 
            this.btnAgregarPerfil.Location = new System.Drawing.Point(125, 442);
            this.btnAgregarPerfil.Name = "btnAgregarPerfil";
            this.btnAgregarPerfil.Size = new System.Drawing.Size(164, 29);
            this.btnAgregarPerfil.TabIndex = 13;
            this.btnAgregarPerfil.Text = "Modificar Perfil";
            this.btnAgregarPerfil.UseVisualStyleBackColor = true;
            this.btnAgregarPerfil.Click += new System.EventHandler(this.btnAgregarPerfil_Click);
            // 
            // btnEliminarPermiso
            // 
            this.btnEliminarPermiso.Location = new System.Drawing.Point(253, 367);
            this.btnEliminarPermiso.Name = "btnEliminarPermiso";
            this.btnEliminarPermiso.Size = new System.Drawing.Size(113, 29);
            this.btnEliminarPermiso.TabIndex = 12;
            this.btnEliminarPermiso.Text = "Eliminar Permiso";
            this.btnEliminarPermiso.UseVisualStyleBackColor = true;
            this.btnEliminarPermiso.Click += new System.EventHandler(this.btnEliminarPermiso_Click);
            // 
            // btnAgregarPermiso
            // 
            this.btnAgregarPermiso.Location = new System.Drawing.Point(253, 332);
            this.btnAgregarPermiso.Name = "btnAgregarPermiso";
            this.btnAgregarPermiso.Size = new System.Drawing.Size(113, 29);
            this.btnAgregarPermiso.TabIndex = 11;
            this.btnAgregarPermiso.Text = "Agregar Permiso";
            this.btnAgregarPermiso.UseVisualStyleBackColor = true;
            this.btnAgregarPermiso.Click += new System.EventHandler(this.btnAgregarPermiso_Click);
            // 
            // btnEliminarFormulario
            // 
            this.btnEliminarFormulario.Location = new System.Drawing.Point(48, 367);
            this.btnEliminarFormulario.Name = "btnEliminarFormulario";
            this.btnEliminarFormulario.Size = new System.Drawing.Size(113, 29);
            this.btnEliminarFormulario.TabIndex = 10;
            this.btnEliminarFormulario.Text = "Eliminar Formulario";
            this.btnEliminarFormulario.UseVisualStyleBackColor = true;
            this.btnEliminarFormulario.Click += new System.EventHandler(this.btnEliminarFormulario_Click);
            // 
            // btnAgregarFormulario
            // 
            this.btnAgregarFormulario.Location = new System.Drawing.Point(48, 332);
            this.btnAgregarFormulario.Name = "btnAgregarFormulario";
            this.btnAgregarFormulario.Size = new System.Drawing.Size(113, 29);
            this.btnAgregarFormulario.TabIndex = 9;
            this.btnAgregarFormulario.Text = "Agregar Formulario";
            this.btnAgregarFormulario.UseVisualStyleBackColor = true;
            this.btnAgregarFormulario.Click += new System.EventHandler(this.btnAgregarFormulario_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Permisos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Formularios";
            // 
            // lbPermisos
            // 
            this.lbPermisos.FormattingEnabled = true;
            this.lbPermisos.Location = new System.Drawing.Point(220, 127);
            this.lbPermisos.Name = "lbPermisos";
            this.lbPermisos.Size = new System.Drawing.Size(178, 199);
            this.lbPermisos.TabIndex = 6;
            // 
            // lbFormularios
            // 
            this.lbFormularios.FormattingEnabled = true;
            this.lbFormularios.Location = new System.Drawing.Point(18, 127);
            this.lbFormularios.Name = "lbFormularios";
            this.lbFormularios.Size = new System.Drawing.Size(172, 199);
            this.lbFormularios.TabIndex = 5;
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(84, 72);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(121, 21);
            this.cbEmpresa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(84, 34);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(121, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.dgvUsuarios);
            this.gbDatos.Controls.Add(this.dgvPerfiles);
            this.gbDatos.Location = new System.Drawing.Point(417, 3);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(570, 523);
            this.gbDatos.TabIndex = 1;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuarios con ese Perfil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Perfiles";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(274, 33);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(289, 484);
            this.dgvUsuarios.TabIndex = 1;
            // 
            // dgvPerfiles
            // 
            this.dgvPerfiles.AllowUserToAddRows = false;
            this.dgvPerfiles.AllowUserToDeleteRows = false;
            this.dgvPerfiles.AllowUserToResizeColumns = false;
            this.dgvPerfiles.AllowUserToResizeRows = false;
            this.dgvPerfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfiles.Location = new System.Drawing.Point(6, 33);
            this.dgvPerfiles.Name = "dgvPerfiles";
            this.dgvPerfiles.Size = new System.Drawing.Size(262, 484);
            this.dgvPerfiles.TabIndex = 0;
            this.dgvPerfiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerfiles_CellDoubleClick);
            // 
            // btnCrearPerfil
            // 
            this.btnCrearPerfil.Location = new System.Drawing.Point(128, 12);
            this.btnCrearPerfil.Name = "btnCrearPerfil";
            this.btnCrearPerfil.Size = new System.Drawing.Size(150, 26);
            this.btnCrearPerfil.TabIndex = 2;
            this.btnCrearPerfil.Text = "Crear Perfil";
            this.btnCrearPerfil.UseVisualStyleBackColor = true;
            this.btnCrearPerfil.Click += new System.EventHandler(this.btnCrearPerfil_Click);
            // 
            // PerfilesComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCrearPerfil);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.gbPerfil);
            this.Name = "PerfilesComponent";
            this.Size = new System.Drawing.Size(990, 529);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PerfilesComponent_Paint);
            this.gbPerfil.ResumeLayout(false);
            this.gbPerfil.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPerfil;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridView dgvPerfiles;
        private System.Windows.Forms.Button btnAgregarPerfil;
        private System.Windows.Forms.Button btnEliminarPermiso;
        private System.Windows.Forms.Button btnAgregarPermiso;
        private System.Windows.Forms.Button btnEliminarFormulario;
        private System.Windows.Forms.Button btnAgregarFormulario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbPermisos;
        private System.Windows.Forms.ListBox lbFormularios;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnCrearPerfil;
    }
}
