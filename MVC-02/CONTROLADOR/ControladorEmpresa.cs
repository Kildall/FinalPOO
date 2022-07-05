﻿using System;
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
        public List<ClienteDataGrid> GetClientes()
        {
            List<ClienteDataGrid> listaClientes = new List<ClienteDataGrid>();
            foreach (var cliente in EmpresaContext.GetInstancia().GetContainer.Clientes)
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
            foreach (var empleado in EmpresaContext.GetInstancia().GetContainer.Empleados) 
                listaEmpleados.Add(new EmpleadoDataGrid(empleado));
            
            return listaEmpleados;
        }

        public List<Categoria> GetCategorias()
        {
            return EmpresaContext.GetInstancia().GetContainer.Categorias.ToList();
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
            var empresa_id = ControladorSeguridad.GetInstancia().usuarioLogueado.empresa_id;
            return EmpresaContext.GetInstancia().GetContainer.Empresa.First(x => x.Id == empresa_id);
            
        }

        public Empresa GetEmpresaById(int id)
        {
            return EmpresaContext.GetInstancia().GetContainer.Empresa.FirstOrDefault(x => x.Id == id);
        }

        public List<ProductoDataGrid> GetProductos()
        {
            List<ProductoDataGrid> listaProductos = new List<ProductoDataGrid>();
            foreach(var producto in EmpresaContext.GetInstancia().GetContainer.Productos.ToList())
                listaProductos.Add(new ProductoDataGrid(producto));

            return listaProductos;
        }

        public void AgregarProducto(Productos producto)
        {
            EmpresaContext.GetInstancia().GetContainer.Productos.Add(producto);
            EmpresaContext.GetInstancia().GetContainer.SaveChanges();
        }
    }
}
