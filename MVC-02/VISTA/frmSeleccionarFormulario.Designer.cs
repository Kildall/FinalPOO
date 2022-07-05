
namespace VISTA
{
    partial class frmSeleccionarFormulario
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
            this.lbFormularios = new System.Windows.Forms.ListBox();
            this.btnSeleccionarFormulario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFormularios
            // 
            this.lbFormularios.FormattingEnabled = true;
            this.lbFormularios.Location = new System.Drawing.Point(12, 12);
            this.lbFormularios.Name = "lbFormularios";
            this.lbFormularios.Size = new System.Drawing.Size(228, 212);
            this.lbFormularios.TabIndex = 0;
            // 
            // btnSeleccionarFormulario
            // 
            this.btnSeleccionarFormulario.Location = new System.Drawing.Point(78, 239);
            this.btnSeleccionarFormulario.Name = "btnSeleccionarFormulario";
            this.btnSeleccionarFormulario.Size = new System.Drawing.Size(96, 28);
            this.btnSeleccionarFormulario.TabIndex = 1;
            this.btnSeleccionarFormulario.Text = "Seleccionar";
            this.btnSeleccionarFormulario.UseVisualStyleBackColor = true;
            this.btnSeleccionarFormulario.Click += new System.EventHandler(this.btnSeleccionarFormulario_Click);
            // 
            // frmSeleccionarFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 275);
            this.Controls.Add(this.btnSeleccionarFormulario);
            this.Controls.Add(this.lbFormularios);
            this.Name = "frmSeleccionarFormulario";
            this.Text = "Seleccionar Formulario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbFormularios;
        private System.Windows.Forms.Button btnSeleccionarFormulario;
    }
}