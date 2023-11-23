using Entidades.Excepciones;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Comprador : IPersona
    {
        private string nombre;
        private string apellido;
        private List<Producto> productos = new List<Producto>();

        public Comprador() { }
        public Comprador(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apeliido { get => apellido; set => apellido = value; }
        public List<Producto> Productos { get => productos; set => productos = value; }
        string IPersona.nombre { get => nombre; set => nombre = value; }
        string IPersona.apellido { get => apellido; set => apellido = value; }

        public void comprar(Producto producto, int cantidad)
        {
            Productos.Add(producto.VenderProducto(cantidad));
        }

        public string Facturar()
        {
            
            if(this.Productos.Count <1) 
            {
                throw new ErrorCompraException("No hay productos comprados"); 
            }
            int totalGastado = 0;
            int cantidaDeProductosComprados = 0;
            foreach (Producto producto in Productos)
            {
                totalGastado += producto.Stock * producto.Precio;
            }
            return totalGastado.ToString();
        }
    }
}
