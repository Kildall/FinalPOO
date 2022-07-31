
namespace VISTA
{
    partial class UsuariosComponent
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.cbPerfiles = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbBusquedaDNI = new System.Windows.Forms.TextBox();
            this.cbBusquedaEmpresa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudDNI = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.groupbox.SuspendLayout();
            this.groupbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDNI)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(410, 102);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(577, 424);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.nudDNI);
            this.groupbox.Controls.Add(this.btnModificarUsuario);
            this.groupbox.Controls.Add(this.btnEliminarUsuario);
            this.groupbox.Controls.Add(this.cbEmpresa);
            this.groupbox.Controls.Add(this.cbPerfiles);
            this.groupbox.Controls.Add(this.label6);
            this.groupbox.Controls.Add(this.label5);
            this.groupbox.Controls.Add(this.label4);
            this.groupbox.Controls.Add(this.tbEmail);
            this.groupbox.Controls.Add(this.label3);
            this.groupbox.Controls.Add(this.label2);
            this.groupbox.Controls.Add(this.tbApellido);
            this.groupbox.Controls.Add(this.label1);
            this.groupbox.Controls.Add(this.tbNombre);
            this.groupbox.Location = new System.Drawing.Point(13, 132);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(381, 331);
            this.groupbox.TabIndex = 1;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Usuarios";
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Location = new System.Drawing.Point(204, 272);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(132, 26);
            this.btnModificarUsuario.TabIndex = 15;
            this.btnModificarUsuario.Text = "Modificar Usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(22, 272);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(132, 26);
            this.btnEliminarUsuario.TabIndex = 14;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Location = new System.Drawing.Point(112, 223);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(170, 21);
            this.cbEmpresa.TabIndex = 13;
            this.cbEmpresa.SelectionChangeCommitted += new System.EventHandler(this.cbEmpresa_SelectionChangeCommitted);
            // 
            // cbPerfiles
            // 
            this.cbPerfiles.FormattingEnabled = true;
            this.cbPerfiles.Location = new System.Drawing.Point(112, 183);
            this.cbPerfiles.Name = "cbPerfiles";
            this.cbPerfiles.Size = new System.Drawing.Size(170, 21);
            this.cbPerfiles.TabIndex = 12;
            this.cbPerfiles.SelectionChangeCommitted += new System.EventHandler(this.cbPerfiles_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Empresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Perfil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-Mail";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(112, 143);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(170, 20);
            this.tbEmail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(112, 63);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(170, 20);
            this.tbApellido.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(112, 23);
            this.tbNombre.MaxLength = 50;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(170, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.label8);
            this.groupbox2.Controls.Add(this.tbBusquedaDNI);
            this.groupbox2.Controls.Add(this.cbBusquedaEmpresa);
            this.groupbox2.Controls.Add(this.label7);
            this.groupbox2.Location = new System.Drawing.Point(410, 4);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(236, 92);
            this.groupbox2.TabIndex = 2;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "Busqueda";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Por DNI:";
            // 
            // tbBusquedaDNI
            // 
            this.tbBusquedaDNI.Location = new System.Drawing.Point(97, 66);
            this.tbBusquedaDNI.Name = "tbBusquedaDNI";
            this.tbBusquedaDNI.Size = new System.Drawing.Size(121, 20);
            this.tbBusquedaDNI.TabIndex = 2;
            this.tbBusquedaDNI.TextChanged += new System.EventHandler(this.tbBusquedaDNI_TextChanged);
            // 
            // cbBusquedaEmpresa
            // 
            this.cbBusquedaEmpresa.FormattingEnabled = true;
            this.cbBusquedaEmpresa.Location = new System.Drawing.Point(97, 19);
            this.cbBusquedaEmpresa.Name = "cbBusquedaEmpresa";
            this.cbBusquedaEmpresa.Size = new System.Drawing.Size(121, 21);
            this.cbBusquedaEmpresa.TabIndex = 1;
            this.cbBusquedaEmpresa.SelectionChangeCommitted += new System.EventHandler(this.cbBusquedaEmpresa_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Por Empresa: ";
            // 
            // nudDNI
            // 
            this.nudDNI.Location = new System.Drawing.Point(112, 104);
            this.nudDNI.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudDNI.Name = "nudDNI";
            this.nudDNI.Size = new System.Drawing.Size(170, 20);
            this.nudDNI.TabIndex = 16;
            // 
            // UsuariosComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "UsuariosComponent";
            this.Size = new System.Drawing.Size(990, 529);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UsuariosComponent_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.groupbox2.ResumeLayout(false);
            this.groupbox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDNI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.ComboBox cbPerfiles;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbBusquedaDNI;
        private System.Windows.Forms.ComboBox cbBusquedaEmpresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudDNI;
    }
}
