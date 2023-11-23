using Entidades.Excepciones;
using Entidades.Modelos;

namespace Test
{
    [TestClass]
    public class ProductoTests
    {
        [TestMethod]
        public void VenderProductoConStock()
        {
            // Entorno
            Producto producto = new Producto("Producto de prueba", 10, 50);
            int cantidadAVender = 20;

            // Accion
            Producto productoVendido = producto.VenderProducto(cantidadAVender);

            // Resultado
            Assert.IsNotNull(productoVendido);
            Assert.AreEqual(cantidadAVender, productoVendido.Stock);
            Assert.AreEqual(30, producto.Stock);
        }

        [TestMethod]
        public void VenderProductoConStockJUsto()
        {
            // 
            Producto producto = new Producto("Producto de prueba", 10, 5); 
            int cantidadAVender = 5;

            // 
            Producto productoVendido = producto.VenderProducto(cantidadAVender);

            // 
            Assert.IsNotNull(productoVendido); 
            Assert.AreEqual(cantidadAVender, productoVendido.Stock);
            Assert.AreEqual(0, producto.Stock); 
        }

        [TestMethod]
        [ExpectedException(typeof(FaltaDeStockException))]
        public void VenderProductoSinStock()
        {
            // 
            Producto producto = new Producto("Producto de prueba", 10, 5); 
            int cantidadAVender = 10;

            // 
            producto.VenderProducto(cantidadAVender);
        }
    }
}