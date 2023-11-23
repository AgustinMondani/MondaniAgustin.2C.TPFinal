using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Factura : Form
    {

        public Factura(Comprador comprador)
        {
            InitializeComponent();
            lblFacturaNumero.Text = new Random().Next(10000000, 99999999).ToString();
            if (comprador.Nombre is null || comprador.Apeliido is null)
            {
                lblClienteNombre.Text = "No se especificio nombre";
            }
            else
            {
                lblClienteNombre.Text = comprador.Nombre.ToString() + " " + comprador.Apeliido.ToString();
            }
            listProductos.View = View.Details;
            listProductos.Columns.Add("Nombre", 180);
            listProductos.Columns.Add("Cantidad", 90);
            listProductos.Columns.Add("Precio", 110);

            foreach (var producto in comprador.Productos)
            {
                ListViewItem item = new ListViewItem(producto.Nombre);
                item.SubItems.Add(producto.Stock.ToString());
                item.SubItems.Add($"${producto.Precio * producto.Stock}");
                listProductos.Items.Add(item);
            }

            lblTotalPrecio.Text = comprador.Facturar().ToString();
            comprador.Productos.Clear();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
