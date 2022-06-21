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
            this.dgvSuperiores = new System.Windows.Forms.DataGridView();
            this.btnAgregarSuperior = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubordinados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuperiores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubordinados
            // 
            this.dgvSubordinados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubordinados.Location = new System.Drawing.Point(452, 12);
            this.dgvSubordinados.Name = "dgvSubordinados";
            this.dgvSubordinados.Size = new System.Drawing.Size(336, 322);
            this.dgvSubordinados.TabIndex = 0;
            // 
            // dgvSuperiores
            // 
            this.dgvSuperiores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuperiores.Location = new System.Drawing.Point(12, 12);
            this.dgvSuperiores.Name = "dgvSuperiores";
            this.dgvSuperiores.Size = new System.Drawing.Size(312, 322);
            this.dgvSuperiores.TabIndex = 1;
            // 
            // btnAgregarSuperior
            // 
            this.btnAgregarSuperior.Location = new System.Drawing.Point(331, 40);
            this.btnAgregarSuperior.Name = "btnAgregarSuperior";
            this.btnAgregarSuperior.Size = new System.Drawing.Size(115, 23);
            this.btnAgregarSuperior.TabIndex = 2;
            this.btnAgregarSuperior.Text = "button1";
            this.btnAgregarSuperior.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmJerarquia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregarSuperior);
            this.Controls.Add(this.dgvSuperiores);
            this.Controls.Add(this.dgvSubordinados);
            this.Name = "frmJerarquia";
            this.Text = "frmJerarquia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubordinados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuperiores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubordinados;
        private System.Windows.Forms.DataGridView dgvSuperiores;
        private System.Windows.Forms.Button btnAgregarSuperior;
        private System.Windows.Forms.Button button2;
    }
}