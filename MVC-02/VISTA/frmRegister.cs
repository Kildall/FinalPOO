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
using System.Text.RegularExpressions;

namespace VISTA
{
    public partial class frmRegister : Form
    {
        private List<EmpresaDataGrid> empresas;
        public frmRegister()
        {
            InitializeComponent();
            empresas = ControladorEmpresa.GetInstancia().GetEmpresas();
            var listaEmpresas = empresas.Select(x => x.Nombre).ToList();
            listaEmpresas.Insert(0, "-");
            cbEmpresa.DataSource = listaEmpresas;
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            //Agregar validaciones de datos con sus errores

            if (!ValidateEmail(tbEmail.Text))
            {
                MessageBox.Show("El mail ingresado es inválido.");
                return;
            }

            if (String.IsNullOrEmpty(tbNombre.Text) || !tbNombre.Text.ToCharArray().All(x => char.IsLetter(x)))
            {
                MessageBox.Show("El nombre ingresado es inválido.");
                return;
            }

            if (String.IsNullOrEmpty(tbApellido.Text) || !tbApellido.Text.ToCharArray().All(x => char.IsLetter(x)))
            {
                MessageBox.Show("El apellido ingresado es inválido.");
                return;
            }

            if (nudDNI.Value >= 99999999 || nudDNI.Value <= 100000)
            {
                MessageBox.Show("El DNI ingresado es inválido.");
                return;
            }

            if (tbContraseña.Text.Length < 8 ||
                String.IsNullOrEmpty(tbContraseña.Text) ||
                !tbContraseña.Text.ToCharArray().Any(x=> char.IsUpper(x)) ||
                !tbContraseña.Text.ToCharArray().Any(x => char.IsDigit(x)))
            {
                MessageBox.Show("La contraseña ingresada es inválida.");
                return;
            }

            if (tbContraseña.Text != tbRepetirContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            if (cbEmpresa.SelectedIndex < 1)
            {
                MessageBox.Show("Seleccione una empresa.");
                return;
            }

            int respuesta = ControladorSeguridad.GetInstancia().Register(new Usuario()
            {
                nombre = tbNombre.Text,
                apellido = tbApellido.Text,
                dni = (long)nudDNI.Value,
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
                    tbEmail.ForeColor = Color.Red;
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

        public bool ValidateEmail(string email)
        {
            Regex validateEmailRegex = new Regex("^\\S+@\\S+\\.\\S+$");
            return validateEmailRegex.IsMatch(email);
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateEmail(tbEmail.Text))
            {
                tbEmail.ForeColor = Color.Red;
            }
            else
            {
                tbEmail.ForeColor = Color.Black;
            }
        }
    }
}
