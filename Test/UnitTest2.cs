using Entidades.Excepciones;
using Entidades.Modelos;

namespace Test
{
    [TestClass]
    public class CompradorTests
    {
        [TestMethod]
        public void FacturarConProductos()
        {
            // Entorno
            Producto producto1 = new Producto("Producto1", 10, 2);
            Producto producto2 = new Producto("Producto2", 15, 3);

            List<Producto> productos = new List<Producto> { producto1, producto2 };
            Comprador comprador = new Comprador("Colo", "Barco");
            comprador.Productos = productos;

            // Accion
            string resultado = comprador.Facturar();

            // Resultado
            Assert.AreEqual("65", resultado); 
        }

        [TestMethod]
        [ExpectedException(typeof(ErrorCompraException))]
        public void FacturarSinProductos()
        {
            // 
            Comprador comprador = new Comprador("Colo", "Barco");
            comprador.Productos = new List<Producto>();

            //
            string resultado = comprador.Facturar();
        }

    }
}