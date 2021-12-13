using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EburyPartners
{
    internal class ConsultaFiltroCliente
    {
        private string DNI_NIF;
        private string estado_cliente;
        private string tipo_cliente;
        private DateTime fecha_nacimiento;
        private string primer_nombre;
        private string segundo_nombre;
        private string ciudad;
        private string calle;
        private string num_edificio;
        private string codigo_postal;
        private string pais_cliente;
        private string IBAN_propiedad;
        private string estado_propiedad;
        private string tipo_propiedad;
        private string IBAN_autorizado;
        private string estado_autorizado;
        private string tipo_autorizado;
        private string primer_nombre_relacionado;
        private string segundo_nombre_relacionado;
        private DateTime fecha_nacimiento_relacionado;
        private string ciudad_relacionado;
        private string calle_relacionado;
        private string num_edificio_relacionado;
        private string codigo_postal_relacionado;
        private string pais_cliente_relacionado;

        public ConsultaFiltroCliente(string dNI_NIF, string estado_cliente, string tipo_cliente, DateTime fecha_nacimiento, string primer_nombre, string segundo_nombre, string ciudad, string calle, string num_edificio, string codigo_postal, string pais_cliente, string iBAN_propiedad, string estado_propiedad, string tipo_propiedad, string iBAN_autorizado, string estado_autorizado, string tipo_autorizado, string primer_nombre_relacionado, string segundo_nombre_relacionado, DateTime fecha_nacimiento_relacionado, string ciudad_relacionado, string calle_relacionado, string num_edificio_relacionado, string codigo_postal_relacionado, string pais_cliente_relacionado)
        {
            this.DNI_NIF = dNI_NIF;
            this.estado_cliente = estado_cliente;
            this.tipo_cliente = tipo_cliente;
            this.fecha_nacimiento = fecha_nacimiento;
            this.primer_nombre = primer_nombre;
            this.segundo_nombre = segundo_nombre;
            this.ciudad = ciudad;
            this.calle = calle;
            this.num_edificio = num_edificio;
            this.codigo_postal = codigo_postal;
            this.pais_cliente = pais_cliente;
            this.IBAN_propiedad = iBAN_propiedad;
            this.estado_propiedad = estado_propiedad;
            this.tipo_propiedad = tipo_propiedad;
            this.IBAN_autorizado = iBAN_autorizado;
            this.estado_autorizado = estado_autorizado;
            this.tipo_autorizado = tipo_autorizado;
            this.primer_nombre_relacionado = primer_nombre_relacionado;
            this.segundo_nombre_relacionado = segundo_nombre_relacionado;
            this.fecha_nacimiento_relacionado = fecha_nacimiento_relacionado;
            this.ciudad_relacionado = ciudad_relacionado;
            this.calle_relacionado = calle_relacionado;
            this.num_edificio_relacionado = num_edificio_relacionado;
            this.codigo_postal_relacionado = codigo_postal_relacionado;
            this.pais_cliente_relacionado = pais_cliente_relacionado;
    }

        public string DNI_NIF1 { get => DNI_NIF; set => DNI_NIF = value; }
        public string Estado_cliente { get => estado_cliente; set => estado_cliente = value; }
        public string Tipo_cliente { get => tipo_cliente; set => tipo_cliente = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Primer_nombre { get => primer_nombre; set => primer_nombre = value; }
        public string Segundo_nombre { get => segundo_nombre; set => segundo_nombre = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Num_edificio { get => num_edificio; set => num_edificio = value; }
        public string Codigo_postal { get => codigo_postal; set => codigo_postal = value; }
        public string Pais_cliente { get => pais_cliente; set => pais_cliente = value; }
        public string IBAN_propiedad1 { get => IBAN_propiedad; set => IBAN_propiedad = value; }
        public string Estado_propiedad { get => estado_propiedad; set => estado_propiedad = value; }
        public string Tipo_propiedad { get => tipo_propiedad; set => tipo_propiedad = value; }
        public string IBAN_autorizado1 { get => IBAN_autorizado; set => IBAN_autorizado = value; }
        public string Estado_autorizado { get => estado_autorizado; set => estado_autorizado = value; }
        public string Tipo_autorizado { get => tipo_autorizado; set => tipo_autorizado = value; }
        public string Primer_nombre_relacionado { get => primer_nombre_relacionado; set => primer_nombre_relacionado = value; }
        public string Segundo_nombre_relacionado { get => segundo_nombre_relacionado; set => segundo_nombre_relacionado = value; }
        public DateTime Fecha_nacimiento_relacionado { get => fecha_nacimiento_relacionado; set => fecha_nacimiento_relacionado = value; }
        public string Ciudad_relacionado { get => ciudad_relacionado; set => ciudad_relacionado = value; }
        public string Calle_relacionado { get => calle_relacionado; set => calle_relacionado = value; }
        public string Num_edificio_relacionado { get => num_edificio_relacionado; set => num_edificio_relacionado = value; }
        public string Codigo_postal_relacionado { get => codigo_postal_relacionado; set => codigo_postal_relacionado = value; }
        public string Pais_cliente_relacionado { get => pais_cliente_relacionado; set => pais_cliente_relacionado = value; }
    }
}
