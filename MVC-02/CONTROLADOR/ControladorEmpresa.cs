using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using MODELO.Seguridad;

namespace CONTROLADOR
{
    public class ControladorEmpresa
    {
        private static ControladorEmpresa _instancia; //Una instancia del controlador
        public int empresa_id { get; set; }
        private ControladorEmpresa() //Constructor privado
        {
        }

        //Obtiene la instancia
        public static ControladorEmpresa GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladorEmpresa();
                
            }
            return _instancia;
        }

        public List<VentaDataGrid> GetVentas()
        {
            List<VentaDataGrid> listaVentas = new List<VentaDataGrid>();
            foreach (var venta in EmpresaContext.GetInstancia().GetContainer.Ventas.Where(x => x.Empresa.Id == empresa_id))
                listaVentas.Add(new VentaDataGrid(venta));

            return listaVentas;
        }

        #region Clientes
        public void AgregarCliente(Cliente cliente)
        {
            EmpresaContext.GetInstancia().GetContainer.Clientes.Add(cliente);
            EmpresaContext.GetInstancia().GetContainer.SaveChanges();
        }

        public void EliminarCliente(Cliente cliente)
        {
            EmpresaContext.GetInstancia().GetContainer.Clientes.Remove(cliente);
            EmpresaContext.GetInstancia().GetContainer.SaveChanges();
        }

        public void ModificarCliente(Cliente cliente)
        {
            EmpresaContext.GetInstancia().GetContainer.SaveChanges();
        }

        public void AgregarVenta(VentaDataGrid venta)
        {
            try
            {
                venta.GetVentas().Empresa = GetEmpresaFromSession();
                EmpresaContext.GetInstancia().GetContainer.Ventas.Add(venta.GetVentas());
                EmpresaContext.GetInstancia().GetContainer.SaveChanges();
            }
            catch (Exception e)
            {

                throw;
            }
        }

        //Devuelve una lista de clientes (todos los que tiene la empresa)
        public List<ClienteDataGrid> GetClientes()
        {
            List<ClienteDataGrid> listaClientes = new List<ClienteDataGrid>();
            foreach (var cliente in EmpresaContext.GetInstancia().GetContainer.Clientes.Where(x => x.Empresa.Id == empresa_id))
                listaClientes.Add(new ClienteDataGrid(cliente));

            return listaClientes;
        }

        #endregion Clientes

        #region Empleados

        public void AgregarEmpleado(Empleado empleado)
        {
            EmpresaContext.GetInstancia().GetContainer.Empleados.Add(empleado);
            EmpresaContext.GetInstancia().GetContainer.SaveChanges();
        }

        public void ModificarEmpleado(Empleado empleado)
        {
            EmpresaContext.GetInstancia().GetContainer.SaveChanges();
        }

        public void EliminarEmpleado(Empleado empleado)
        {
            EmpresaContext.GetInstancia().GetContainer.Empleados.Remove(empleado);
            EmpresaContext.GetInstancia().GetContainer.SaveChanges();
        }

        //Devuelve una lista de empleados
        public List<EmpleadoDataGrid> GetEmpleados()
        {
            List<EmpleadoDataGrid> listaEmpleados = new List<EmpleadoDataGrid>();
            foreach (var empleado in EmpresaContext.GetInstancia().GetContainer.Empleados.Where(x => x.Empresa.Id == empresa_id)) 
                listaEmpleados.Add(new EmpleadoDataGrid(empleado));
            
            return listaEmpleados;
        }

        public List<Categoria> GetCategorias()
        {
            Usuario usuario = ControladorSeguridad.GetInstancia().usuarioLogueado;
            return EmpresaContext.GetInstancia().GetContainer.Categorias.Where(x => x.Empresa.Id == usuario.Id).ToList();
        }

        #endregion Empleados



        public List<EmpresaDataGrid> GetEmpresas()
        {
            List<EmpresaDataGrid> listaEmpresas = new List<EmpresaDataGrid>();
            foreach (var empresas in EmpresaContext.GetInstancia().GetContainer.Empresa)
                listaEmpresas.Add(new EmpresaDataGrid(empresas));

            return listaEmpresas;
        }

        public Empresa GetEmpresaFromSession()
        {
            return EmpresaContext.GetInstancia().GetContainer.Empresa.First(x => x.Id == empresa_id);
            
        }

        public Empresa GetEmpresaById(int id)
        {
            return EmpresaContext.GetInstancia().GetContainer.Empresa.FirstOrDefault(x => x.Id == id);
        }

        public List<ProductoDataGrid> GetProductos()
        {
            List<ProductoDataGrid> listaProductos = new List<ProductoDataGrid>();
            foreach(var producto in EmpresaContext.GetInstancia().GetContainer.Productos.Where(x=> x.Empresa.Id == empresa_id).ToList())
                listaProductos.Add(new ProductoDataGrid(producto));

            return listaProductos;
        }

        public void AgregarProducto(Productos producto)
        {
            EmpresaContext.GetInstancia().GetContainer.Productos.Add(producto);
            EmpresaContext.GetInstancia().GetContainer.SaveChanges();
        }

        public void EliminarProducto(Productos producto)
        {
            EmpresaContext.GetInstancia().GetContainer.Productos.Remove(producto);
            EmpresaContext.GetInstancia().GetContainer.SaveChanges();
        }
    }
}
