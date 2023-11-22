using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Vendedor
    {
        private string nombre;
        private string apellido;
        private string contraseña;
        private int comision = 0;
        private string mail;

        public Vendedor(string nombre, string apellido, string contraseña, string mail)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.contraseña = contraseña.ToLower();
            this.mail = mail;
        }

        public Vendedor() { }

        [Key]
        public int VendedorId { get; set; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apeliido { get => apellido; set => apellido = value; }
        public int Comision { get => comision; set => comision = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Mail { get => mail; set => mail = value; }

        public void Vender(int comsion)
        {
                this.comision += comsion * 10 / 100;
        }


    }
}
