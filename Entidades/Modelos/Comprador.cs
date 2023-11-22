using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Comprador
    {
        private string nombre;
        private string apellido;
        public List<Producto> productos = new List<Producto>();

        public Comprador() { }
        public Comprador(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apeliido { get => apellido; set => apellido = value; }
        public void comprar(Producto producto, int cantidad)
        {
            productos.Add(producto.VenderProducto(cantidad));
        }

        public string Facturar()
        {
            if(this.productos.Count <1) 
            {
                throw new ErrorCompraException("No hay productos comprados"); 
            }
            int totalGastado = 0;
            int cantidaDeProductosComprados = 0;
            foreach (Producto producto in productos)
            {
                totalGastado += producto.Stock * producto.Precio;
            }
            return totalGastado.ToString();

            
        }
    }
}
