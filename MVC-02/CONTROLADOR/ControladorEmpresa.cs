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
        private static ControladorEmpresa _instancia;

        private ControladorEmpresa() { }


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
        
        /*public void AgregarEmpleado(Empleado empleado)
        {
            Empresa
        }*/

        #endregion Empleados

        public Empresa GetEmpresa()
        {
            //Devuelve la primera empresa (indice 1), osea la unica empresa
            return EmpresaContext.GetInstancia().GetContainer.Empresa.First(x => x.Id == 1);
        }
    }
}
