using Entidades.BaseDeDatos;
using Entidades.Excepciones;
using Entidades.Modelos;

namespace Forms
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                using (GestorBaseDeDatos gbd = new GestorBaseDeDatos())
                {
                    Vendedor v = gbd.vendedor.FirstOrDefault(u => u.Mail == txtCorreo.Text);

                    if (v is not null && txtContraseña.Text.Equals(v.Contraseña))
                    {
                        FormAplicacion formAplicacion = new FormAplicacion(v, this);
                        formAplicacion.Show();
                        this.Hide();
                    }
                    else
                    {
                        throw new BaseDeDatosExeption("Datos incorrectos, vuelva a intentar");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro(this);
            formRegistro.Show();
            this.Hide();

        }
    }
}