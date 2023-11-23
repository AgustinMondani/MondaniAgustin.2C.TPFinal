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
            // Arrange
            Producto producto1 = new Producto("Producto1", 10, 2);
            Producto producto2 = new Producto("Producto2", 15, 3);

            List<Producto> productos = new List<Producto> { producto1, producto2 };
            Comprador comprador = new Comprador("Colo", "Barco");
            comprador.Productos = productos;

            // Act
            string resultado = comprador.Facturar();

            // Assert
            Assert.AreEqual("65", resultado); // Ajusta el valor esperado según tu lógica de facturación
        }

        [TestMethod]
        [ExpectedException(typeof(ErrorCompraException))]
        public void FacturarSinProductos()
        {
            // Arrange
            Comprador comprador = new Comprador("Colo", "Barco");
            comprador.Productos = new List<Producto>();

            // Act
            string resultado = comprador.Facturar();
        }

    }
}