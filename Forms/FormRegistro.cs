using Entidades.BaseDeDatos;
using Entidades.Excepciones;
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

namespace Forms
{
    public partial class FormRegistro : Form
    {
        FrmInicio formInicio;
        public FormRegistro(FrmInicio form)
        {
            this.formInicio = form;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                using (GestorBaseDeDatos gbd = new GestorBaseDeDatos())
                {
                    Vendedor v = gbd.vendedor.FirstOrDefault(u => u.Mail == txtCorreo.Text);

                    if (v is not null && txtCorreo.Text.Equals(v.Mail))
                    {
                        throw new BaseDeDatosExeption("Este mail ya fue registrado");
                    }
                    else
                    {
                        if (txtCorreo.Text.Contains("@"))
                        {
                            Vendedor vendedor = new Vendedor()
                            {
                                Nombre = txtNombre.Text,
                                Apeliido = txtApellido.Text,
                                Contraseña = txtContraseña.Text,
                                Mail = txtCorreo.Text
                            };
                            gbd.Add(vendedor).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                            gbd.SaveChanges();
                            this.Close();
                            this.formInicio.Hide();

                            FormAplicacion formAplicacion = new FormAplicacion(vendedor, formInicio);
                            formAplicacion.Show();
                        }
                        else
                        {
                            throw new BaseDeDatosExeption("No es un mail valido");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {
            formInicio.Show();
        }
    }
}
