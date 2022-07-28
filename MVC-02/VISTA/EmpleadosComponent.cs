using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODELO;
using CONTROLADOR;

namespace VISTA
{
    public partial class EmpleadosComponent : UserControl
    {
        List<EmpleadoDataGrid> ListaEmpleados = new List<EmpleadoDataGrid>();
        List<Categoria> ListaCategorias = new List<Categoria>();
        int categoriaSeleccionada; //Indice
        int indiceEmpleado;
        EmpleadoDataGrid empleado = null;



        public EmpleadosComponent()
        {
            InitializeComponent();
            ListarEmpleados();
            MostrarCategorias();
            var permisos = ControladorSeguridad.GetInstancia().GetPermisosByFormulario("frmEmpleados");
            foreach (var control in GetButtonControls(this))
            {
                if (permisos.Contains(control.Name))
                {
                    control.Enabled = true;
                }
                else
                {
                    control.Enabled = false;
                }
            }
        }
        //Usar recursion para obtener todos los hijos de un control
        private List<Control> GetButtonControls(Control padre)
        {
            List<Control> controles = new List<Control>();
            //Caso base es el caso en donde no haya hijos ya que no entra al foreach
            foreach (Control c in padre.Controls)
            {
                controles.AddRange(GetButtonControls(c));
                if (c is Button)
                    controles.Add(c);
            }
            //En el caso base, devuelve la lista vacia, si no, devuelve los controles
            return controles;
        }

        public void ListarEmpleados()
        {
            dgvEmpleados.DataSource = null;
            ListaEmpleados = ControladorEmpresa.GetInstancia().GetEmpleados();
            dgvEmpleados.DataSource = ListaEmpleados;
        }

        //Muestra las categorias en el ComboBox
        public void MostrarCategorias()
        {
            ListaCategorias = ControladorEmpresa.GetInstancia().GetCategorias();

            cbxCategoria.Items.Clear();
            foreach (Categoria x in ListaCategorias)    // Agrego las categorias al ComboBox
            {
                cbxCategoria.Items.Add(x.nombre);
            }
        }

        //Asigna el empleado seleccionado en el dgv
        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                indiceEmpleado = dgvEmpleados.SelectedRows[0].Index; //Asigna el indice del empleado seleccionado
            }
        }

        public EmpleadoDataGrid EmpleadoSeleccionado() //Devuelve el Empleado seleccionado en el dgv
        {
            return ListaEmpleados.ElementAt(indiceEmpleado);
        }

        //AGREGAR EMPLEADO
        private void btnAgregarEmpl_Click(object sender, EventArgs e)
        {
            //Validaciones para agregar Empleado

            if (String.IsNullOrEmpty(txtNombreEmp.Text) || !txtNombreEmp.Text.ToCharArray().All(x => char.IsLetter(x)))
            {
                MessageBox.Show("El nombre ingresado es inválido.");
                return;
            }

            if (nudEdadEmp.Value <= 0)
            {
                MessageBox.Show("La edad ingresada es inválida.");
                return;
            }

            if (nudSalarioEmp.Value <= 0)
            {
                MessageBox.Show("El salario ingresado es inválido.");
                return;
            }

            if (cbxCategoria.SelectedIndex <= -1)
            {
                MessageBox.Show("La categoria seleccionada es inválida.");
                return;
            }

            EmpleadoDataGrid empleado = new EmpleadoDataGrid(new Empleado()
            {
                nombre = txtNombreEmp.Text,
                edad = int.Parse(nudEdadEmp.Text),
                salario = (int)(long)(nudEdadEmp.Value),
                Categoria = ListaCategorias.ElementAt(categoriaSeleccionada),
                Empresa = ControladorEmpresa.GetInstancia().GetEmpresaFromSession()
            });

            ControladorEmpresa.GetInstancia().AgregarEmpleado(empleado);
            ListarEmpleados();
        }

        //MODIFICAR EMPLEADO
        private void btnModificarEmpl_Click(object sender, EventArgs e)
        {
            if (empleado == null) { MessageBox.Show("Seleccione un empleado."); return; };
            empleado.GetEmpleado().nombre = txtNombreEmp.Text;
            empleado.GetEmpleado().edad = int.Parse(nudEdadEmp.Text);
            empleado.GetEmpleado().salario = (int)(long)(nudEdadEmp.Value);

            empleado.GetEmpleado().Categoria = ListaCategorias.ElementAt(cbxCategoria.SelectedIndex);

            ControladorEmpresa.GetInstancia().ModificarEmpleado(empleado);
            ListarEmpleados();

            btnAgregarEmpleado.Enabled = true;
            btnEliminarEmpleado.Enabled = true;
            empleado = null;

            LimpiarCampos();
        }

        //ELIMINAR EMPLEADO
        private void btnEliminarEmpl_Click(object sender, EventArgs e)
        {
            EmpleadoDataGrid empleado = EmpleadoSeleccionado();

            if (empleado == null) { MessageBox.Show("Seleccione un empleado."); return; };

            if (
                MessageBox.Show($"Desea eliminar el Empleado: {empleado.Nombre}",
                "Eliminar empleado", MessageBoxButtons.OKCancel) == DialogResult.OK
                )
            {
                ControladorEmpresa.GetInstancia().EliminarEmpleado(empleado);
                ListarEmpleados();
                LimpiarCampos();
            }
        }

        private void EmpleadosComponent_Paint(object sender, PaintEventArgs e)
        {
            ListarEmpleados();
        }

        private void LimpiarCampos()
        {
            txtNombreEmp.Text = null;
            nudEdadEmp.Value = 0;
            nudSalarioEmp.Value = 0;
            cbxCategoria.Text = null;
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            empleado = ListaEmpleados.ElementAt(indiceEmpleado);

            txtNombreEmp.Text = empleado.Nombre;
            nudEdadEmp.Value = empleado.Edad;
            nudSalarioEmp.Value = empleado.Salario;
            cbxCategoria.Text = empleado.Categoria;

            btnAgregarEmpleado.Enabled = false;
            btnEliminarEmpleado.Enabled = false;
        }
    }
}
