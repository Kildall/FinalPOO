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
using MODELO.Seguridad;
using MODELO;

namespace VISTA
{
    public partial class frmRegister : Form
    {
        private List<EmpresaDataGrid> empresas;
        public frmRegister()
        {
            InitializeComponent();
            empresas = ControladorEmpresa.GetInstancia().GetEmpresas();
            cbEmpresa.DataSource = empresas.Select(x => x.Nombre).ToList();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            //Agregar validaciones de datos con sus errores

            int respuesta = ControladorSeguridad.GetInstancia().Register(new Usuario()
            {
                nombre = tbNombre.Text,
                apellido = tbApellido.Text,
                dni = tbDNI.Text,
                contraseña = tbContraseña.Text,
                mail = tbEmail.Text,
                empresa_id = empresas[cbEmpresa.SelectedIndex].GetEmpresa().Id
            });

            switch (respuesta)
            {
                case 10:
                    //Error el mail ya existe (hay un label de error para esto)
                    lblError.Text = "El mail ingresado ya existe.";
                    lblError.Visible = true;
                    tbEmail.BackColor = Color.Red;
                    break;
                case 0:
                    //Mostrar mensaje de registro exitoso
                    MessageBox.Show("El usuario se ha registrado correctamente.");
                    //Mandar a la pantalla de logueo o el menu de inicio
                    //(Para elegir registro o para loguearse, no hay diferencia para mi)
                    this.Close();

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
