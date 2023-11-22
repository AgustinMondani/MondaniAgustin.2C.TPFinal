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
            // Arrange (preparar)
            Producto producto = new Producto("Producto de prueba", 10, 50); // nombre, precio, stock inicial
            int cantidadAVender = 20;

            // Act (actuar)
            Producto productoVendido = producto.VenderProducto(cantidadAVender);

            // Assert (verificar)
            Assert.IsNotNull(productoVendido); // Se espera que el producto vendido no sea nulo
            Assert.AreEqual(cantidadAVender, productoVendido.Stock); // Se espera que la cantidad del producto vendido sea igual a la cantidad especificada
            Assert.AreEqual(30, producto.Stock); // Se espera que el stock restante sea igual al stock inicial menos la cantidad vendida
        }

        [TestMethod]
        public void VenderProductoConStockJUsto()
        {
            // Arrange (preparar)
            Producto producto = new Producto("Producto de prueba", 10, 5); // nombre, precio, stock inicial
            int cantidadAVender = 5;

            // Act (actuar)
            Producto productoVendido = producto.VenderProducto(cantidadAVender);

            // Assert (verificar)
            Assert.IsNotNull(productoVendido); // Se espera que el producto vendido no sea nulo
            Assert.AreEqual(cantidadAVender, productoVendido.Stock); // Se espera que la cantidad del producto vendido sea igual a la cantidad especificada
            Assert.AreEqual(0, producto.Stock); // Se espera que el stock restante sea igual al stock inicial menos la cantidad vendida
        }

        [TestMethod]
        [ExpectedException(typeof(FaltaDeStockException))]
        public void VenderProductoSinStock()
        {
            // Arrange
            Producto producto = new Producto("Producto de prueba", 10, 5); // nombre, precio, stock inicial
            int cantidadAVender = 10;

            // Act y Assert
            producto.VenderProducto(cantidadAVender);
        }
    }
}