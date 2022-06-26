using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADOR
{
    public class ControladorEmpresa
    {
        private static ControladorEmpresa _instancia; //Una instancia del controlador

        private ControladorEmpresa() { }    //Constructor privado

        //Obtiene la instancia
        public static ControladorEmpresa GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladorEmpresa();
            }
            return _instancia;
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

        //Devuelve una lista de clientes (todos los que tiene la empresa)
        public List<Cliente> GetClientes()
        {
            return EmpresaContext.GetInstancia().GetContainer.Clientes.ToList();
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
        public List<Empleado> GetEmpleados()
        {
            return EmpresaContext.GetInstancia().GetContainer.Empleados.ToList();
        }

        public List<Categoria> GetCategorias()
        {
            return EmpresaContext.GetInstancia().GetContainer.Categorias.ToList();
        }

        #endregion Empleados

        public Empresa GetEmpresa()
        {
            //Devuelve la primera empresa (indice 1), osea la unica empresa}
            Empresa resultado = EmpresaContext.GetInstancia().GetContainer.Empresa.FirstOrDefault(x => x.Id == 1);
            if (resultado == null){
                EmpresaContext.GetInstancia().GetContainer.Empresa.Add(new Empresa() { nombre = "franco se la come" });
                EmpresaContext.GetInstancia().GetContainer.SaveChanges();
            }
            return EmpresaContext.GetInstancia().GetContainer.Empresa.FirstOrDefault(x => x.Id == 1);
        }
    }
}
