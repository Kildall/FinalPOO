using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR;

namespace VISTA
{
    public partial class frmLogin : Form
    {
        public bool successLogin = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int respuesta = ControladorSeguridad.GetInstancia().Login(tbEmail.Text, tbContraseña.Text);
            switch (respuesta)
            {
                case 0:
                    //Pasar al formulario correcto. (cerrar este y abrir el que corresponde)
                    successLogin = true;
                    this.Close();
                    
                    break;

                case 20:
                    //Mostrar error email no existe. (hay un label de error)
                    successLogin = false;
                    MessageBox.Show("Los datos ingresados son incorrectos. Compruebe si su mail y contraseña son válidos."
                        , "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case 40:
                    //Mostrar error contraseña incorrecta (hay un label de error)
                    successLogin = false;
                    MessageBox.Show("Los datos ingresados son incorrectos. Compruebe si su mail y contraseña son válidos."
                        , "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                default:
                    throw new Exception("Codigo de respuesta invalido.");
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
