using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    internal class VentaDataGrid
    {
        private readonly Ventas _venta;
        public string Cliente { get; set; }
        public string Empleado { get; set; }
        public string Total { get; set; }
        public string Cantidad { get; set; }

        public string Producto { get; set; }

        public VentaDataGrid(Ventas venta)
        {
            _venta = venta;
            Cliente = venta.Cliente.nombre;
            Empleado = venta.Empleado.nombre;
            Total = venta.total.ToString();
            Cantidad = venta.Productos.Count.ToString();
            Producto = venta.Productos.ToList()[0].nombre;

        }

        public Ventas GetVentas()
        {
            return _venta;
        }
    }
}
