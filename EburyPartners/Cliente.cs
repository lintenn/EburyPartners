using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EburyPartners
{
    internal class Cliente
    {

        private string DNI_NIF;
        private string primer_nombre;
        private string segundo_nombre;
        private DateTime fecha_nacimiento;
        private string calle;
        private string num_edificio;
        private string ciudad;
        private string codigo_postal;
        private string pais_cliente;
        private string estado_cliente;
        private int tipo_cliente;
        private List<Cuenta> cuentas;
        private List<Cuenta> autorizado;
        private List<Cliente> relacionados;


        public Cliente(string dNI_NIF)
        {
            DNI_NIF = dNI_NIF;
        }

        public string DNI_NIF1 { get => DNI_NIF; set => DNI_NIF = value; }
        public string Primer_nombre { get => primer_nombre; set => primer_nombre = value; }
        public string Segundo_nombre { get => segundo_nombre; set => segundo_nombre = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Num_edificio { get => num_edificio; set => num_edificio = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Codigo_postal { get => codigo_postal; set => codigo_postal = value; }
        public string Pais_cliente { get => pais_cliente; set => pais_cliente = value; }
        public string Estado_cliente { get => estado_cliente; set => estado_cliente = value; }
        public int Tipo_cliente { get => tipo_cliente; set => tipo_cliente = value; }
        internal List<Cuenta> Cuentas { get => cuentas; set => cuentas = value; }
        internal List<Cuenta> Autorizado { get => autorizado; set => autorizado = value; }
        internal List<Cliente> Relacionados { get => relacionados; set => relacionados = value; }

    }
}
