using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms;
using Entidades.BaseDeDatos;
using Entidades.Excepciones;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Linq.Expressions;

namespace Forms
{
    public partial class FormAplicacion : Form
    {
        Comprador comprador = new Comprador();
        Vendedor vendedorActual;
        FrmInicio formInicio;

        public FormAplicacion(Vendedor user, FrmInicio form)
        {
            this.formInicio = form;
            this.vendedorActual = user;
            InitializeComponent();
            lblUsuario.Text = (user.Nombre + " " + user.Apeliido);
            CargarCmb(ProductosCargar());
            InicializarList();

        }

        public List<Producto> ProductosCargar()
        {
            List<Producto> listaProductos = new List<Producto>();
            using (var gbd = new GestorBaseDeDatos())
            {
                var productos = gbd.producto.ToList();
                foreach (var producto in productos)
                {
                    listaProductos.Add(new Producto(producto.Nombre, producto.Precio, producto.Stock));
                }
            }
            return listaProductos;
        }
        public void CargarCmb(List<Producto> listaProductos)
        {
            List<Producto> productos = ProductosCargar();
            foreach (Producto producto in productos)
            {
                cmbNombreProducto.Items.Add(producto.Nombre);
            }
        }

        private void cmbNombreProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActulizarStockEnPantalla();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            try
            {

                if (comprador.productos.Count() == 0)
                {
                    comprador.Nombre = txtClienteNombre.Text;
                    comprador.Apeliido = txtClienteApellido.Text;
                    comprador.productos.Clear();
                    InicializarList();
                }
                else
                {
                    throw new ClienteException("Cliente registrado, sin finalizar la compra");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                using (GestorBaseDeDatos gbd = new GestorBaseDeDatos())
                {
                    Producto producto = gbd.producto.FirstOrDefault(u => u.Nombre == cmbNombreProducto.SelectedItem.ToString());
                    if (int.TryParse(txtCantidad.Text, out int cantidad))
                    {
                        comprador.comprar(producto, cantidad);
                        ActualizarList();
                        gbd.SaveChanges();
                        ActulizarStockEnPantalla();

                    }
                    else
                    {
                        throw new Exception("Cantidad incorrercta");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarList()
        {
            InicializarList();
            foreach (var producto in comprador.productos)
            {
                ListViewItem item = new ListViewItem(producto.Nombre);
                item.SubItems.Add(producto.Stock.ToString());
                item.SubItems.Add($"${producto.Precio * producto.Stock}");
                listProductos.Items.Add(item);
            }
        }

        private void InicializarList()
        {
            listProductos.Clear();
            listProductos.View = View.Details;
            listProductos.Columns.Add("Nombre", 120);
            listProductos.Columns.Add("Cantidad", 50);
            listProductos.Columns.Add("Precio", 70);
        }

        private void ActulizarStockEnPantalla()
        {
            using (GestorBaseDeDatos gbd = new GestorBaseDeDatos())
            {
                Producto producto = gbd.producto.FirstOrDefault(u => u.Nombre == cmbNombreProducto.SelectedItem.ToString());
                lblPrecioUnitario.Text = producto.Precio.ToString();
                lblStockProducto.Text = producto.Stock.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string total = comprador.Facturar();
                int comision = int.Parse(total);
                Factura FrmFactura = new Factura(comprador);
                FrmFactura.Show();
                this.Show();
                ActualizarList();
                using (GestorBaseDeDatos gbd = new GestorBaseDeDatos())
                {
                    Vendedor vendedor = gbd.vendedor.FirstOrDefault(u => u.Mail == vendedorActual.Mail);
                    vendedor.Vender(comision);
                    gbd.SaveChanges();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCargarCsv_Click(object sender, EventArgs e)
        {
            List<Producto> productos = new List<Producto>();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = Path.Combine(path, "MondaniAgustin.2C.TPFinal");

            string archivoJson = "CargaDeProductos.json";
            string rutaCompleta = Path.Combine(path, archivoJson);

            try
            {
                if (File.Exists(rutaCompleta))
                {
                    using (StreamReader sr = new StreamReader(rutaCompleta))
                    {
                        string jsonString = sr.ReadToEnd();
                        productos = JsonSerializer.Deserialize<List<Producto>>(jsonString);
                    }

                    using (GestorBaseDeDatos gbd = new GestorBaseDeDatos())
                    {
                        foreach (Producto p in productos)
                        {
                            gbd.Add(p).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                        }
                        gbd.SaveChanges();
                        File.WriteAllText(rutaCompleta, string.Empty);
                    }
                }
                else
                {
                    MessageBox.Show("Archivo inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la carga del archivo, verifique haber cargado bien los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormAplicacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult salir = MessageBox.Show("Desea cerrar la aplicacion?", "cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.No)
            {
                e.Cancel = true;
            }
            if (salir == DialogResult.Yes)
            {
                formInicio.Close();
            }

        }
    }
}
