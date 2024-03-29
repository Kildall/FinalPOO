﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class VentaDataGrid
    {
        private Ventas _venta;
        public string Cliente { get; set; }
        public string Empleado { get; set; }
        public int Total { get; set; }
        public int Cantidad { get; set; }

        public string Producto { get; set; }

        public VentaDataGrid(Ventas venta)
        {
            if (venta == null) return;
            _venta = venta;
            Cliente = venta.Cliente.nombre;
            Empleado = venta.Empleado.nombre;
            Total = venta.total;
            Cantidad = venta.cantidad;
            Producto = venta.Productos.nombre;

        }

        public VentaDataGrid()
        {

        }

        public void CrearVenta()
        {
            _venta = new Ventas();
        }

        public Ventas GetVentas()
        {
            return _venta;
        }
    }
}
