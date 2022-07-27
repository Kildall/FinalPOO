using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ProductoDataGrid
    {
        private Productos _producto;
        public string Nombre { get; private set; }
        public int Cantidad { get; private set; }
        public int Precio { get; private set; }

        public ProductoDataGrid(Productos producto)
        {
            this._producto = producto;
            this.Nombre = producto.nombre;
            this.Cantidad = producto.cantidad;
            this.Precio = producto.precio;
            
        }

        public Productos GetProductos()
        {
            return _producto;
        }
    }
}
