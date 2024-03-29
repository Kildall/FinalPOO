﻿using System;
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

        #region Ventas
        public List<VentaDataGrid> GetVentas()
        {
            List<VentaDataGrid> listaVentas = new List<VentaDataGrid>();
            foreach (var venta in EmpresaContext.GetInstancia().GetContainer.Ventas.Where(x => x.Empresa.Id == empresa_id))
                listaVentas.Add(new VentaDataGrid(venta));

            return listaVentas;
        }

        public void AgregarVenta(VentaDataGrid venta)
        {
            venta.GetVentas().Empresa = GetEmpresaFromSession();
            venta.GetVentas().Productos.cantidad = venta.GetVentas().Productos.cantidad - venta.GetVentas().cantidad;
            EmpresaContext.GetInstancia().GetContainer.Ventas.Add(venta.GetVentas());
            EmpresaContext.GetInstancia().GetContainer.SaveChanges();
        }

        public void EliminarVenta(VentaDataGrid venta)
        {
            venta.GetVentas().Productos.cantidad = venta.GetVentas().Productos.cantidad + venta.GetVentas().cantidad;
            EmpresaContext.GetInstancia().GetContainer.Ventas.Remove(venta.GetVentas());
            EmpresaContext.GetInstancia().GetContainer.SaveChanges();
        }
        #endregion

        #region Categorias
        public List<Categoria> GetCategorias()
        {
            Usuario usuario = ControladorSeguridad.GetInstancia().usuarioLogueado;
            return EmpresaContext.GetInstancia().GetContainer.Categorias.Where(x => x.Empresa.Id == usuario.Id).ToList();
        }
        #endregion

        #region Clientes
        public void AgregarCliente(ClienteDataGrid cliente)
        {
            EmpresaContext.GetInstancia().GetContainer.Clientes.Add(cliente.GetCliente());
            EmpresaContext.GetInstancia().GetContainer.SaveChanges();
        }

        public void EliminarCliente(ClienteDataGrid cliente)
        {
            EmpresaContext.GetInstancia().GetContainer.Clientes.Remove(cliente.GetCliente());
            EmpresaContext.GetInstancia().GetContainer.SaveChanges();
        }

        public void ModificarCliente(ClienteDataGrid cliente)
        {
            EmpresaContext.GetInstancia().GetContainer.SaveChanges();
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

        public void AgregarEmpleado(EmpleadoDataGrid empleado)
        {
            EmpresaContext.GetInstancia().GetContainer.Empleados.Add(empleado.GetEmpleado());
            EmpresaContext.GetInstancia().GetContainer.SaveChanges();
        }

        public void ModificarEmpleado(EmpleadoDataGrid empleado)
        {
            EmpresaContext.GetInstancia().GetContainer.SaveChanges();
        }

        public void EliminarEmpleado(EmpleadoDataGrid empleado)
        {
            EmpresaContext.GetInstancia().GetContainer.Empleados.Remove(empleado.GetEmpleado());
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

        #endregion Empleados

        #region Empresas
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


        #endregion

        #region Productos
        public List<ProductoDataGrid> GetProductos()
        {
            List<ProductoDataGrid> listaProductos = new List<ProductoDataGrid>();
            foreach (var producto in EmpresaContext.GetInstancia().GetContainer.Productos.Where(x => x.Empresa.Id == empresa_id).ToList())
                listaProductos.Add(new ProductoDataGrid(producto));

            return listaProductos;
        }

        public void AgregarProducto(ProductoDataGrid producto)
        {
            EmpresaContext.GetInstancia().GetContainer.Productos.Add(producto.GetProductos());
            EmpresaContext.GetInstancia().GetContainer.SaveChanges();
        }

        public void EliminarProducto(ProductoDataGrid producto)
        {
            EmpresaContext.GetInstancia().GetContainer.Productos.Remove(producto.GetProductos());
            EmpresaContext.GetInstancia().GetContainer.SaveChanges();
        }

        public void ModificarProducto(ProductoDataGrid producto)
        {
            EmpresaContext.GetInstancia().GetContainer.SaveChanges();
        }
        #endregion
    }
}
