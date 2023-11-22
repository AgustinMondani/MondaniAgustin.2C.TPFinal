using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Producto
    {
        private string nombre;
        private int precio;
        private int stock;

        public Producto(string nombre, int precio, int stock)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }

        [Key]
        public int ProductoId { get; set; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }

        public void AñadirStock(int cantidad)
        {
            Stock += cantidad;
        }

        public void ReducirStock(int cantidad)
        {
            Stock -= cantidad;
        }

        public bool CompararConProducto(string nombreProducto)
        {
            return Nombre == nombreProducto;
        }

        public bool VerificarVenta(int  cantidad)
        {
            if (cantidad < 1)
            {
                throw new FaltaDeStockException("Nose es una cantidad de unidades correcta");
            }
            return cantidad <= this.Stock;
        }

        public Producto VenderProducto(int cantidad)
        {
            if (VerificarVenta(cantidad))
            {
                ReducirStock(cantidad);
                return  new Producto(Nombre, Precio, cantidad);
            }
            throw new FaltaDeStockException("No hay suficiente stock");
        }

        

      
    }
}
